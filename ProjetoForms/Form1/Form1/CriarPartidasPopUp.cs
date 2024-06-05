using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Form1.ConnectToServer;

namespace Form1
{
    public partial class CriarPartidasPopUp : Form
    {
        public CriarPartidasPopUp()
        {
            InitializeComponent();
            LoadTorneios();
            LoadJogadores();
        }

        public class Jogador
        {
            public string Nome { get; set; }
            public int WL { get; set; }
        }

        private string connectionString = ConnectionStringProvider.ConnectionString;

        private void buttonSimular_Click(object sender, EventArgs e)
        {
            // Obter o torneio selecionado
            string selectedTorneio = comboBoxTorneios.SelectedValue?.ToString() ?? "DefaultTorneio";

            // Obter o ID do torneio a partir do nome
            int selectedTorneioId = GetTorneioId(selectedTorneio);

            // Verificar se o torneio já tem jogadores
            if (TorneioTemJogadores(selectedTorneioId))
            {
                MessageBox.Show("O torneio já tem jogadores.");
                return;
            }

            // Obter o número máximo de jogadores para o torneio selecionado
            int maxPlayers = GetMaxPlayers(selectedTorneio);

            // Verificar se o número de jogadores selecionados corresponde ao máximo permitido
            if (listBoxJogadores.SelectedItems.Count != maxPlayers)
            {
                MessageBox.Show($"Please select {maxPlayers} players");
                return;
            }

            // Lista de jogadores selecionados
            List<Jogador> jogadores = new List<Jogador>();

            // Adicionar jogadores à lista
            foreach (DataRowView selectedRow in listBoxJogadores.SelectedItems)
            {
                string nickname = selectedRow["Nickname"].ToString();
                int wl = int.Parse(selectedRow["W_L"].ToString());
                jogadores.Add(new Jogador { Nome = nickname, WL = wl });
            }

            // Ordenar jogadores por WL
            var jogadoresOrdenados = jogadores.OrderBy(j => j.WL).ToList();

            // Obter o ID do torneio
            int torneioId = GetTorneioId(selectedTorneio);

            // Verificar se o ID do torneio foi encontrado
            if (torneioId == -1)
            {
                MessageBox.Show("Torneio não encontrado.");
                return;
            }

            // Adicionar jogadores ao torneio
            foreach (var jogador in jogadoresOrdenados)
            {
                AddJogadorToTorneio(torneioId, jogador.Nome);
            }

            // Criar partidas
            int partidaNum = 1;
            StringBuilder debugMessage = new StringBuilder();
            debugMessage.AppendLine($"Torneio ID: {torneioId}");
            debugMessage.AppendLine("Partidas Criadas:");

            for (int i = 0; i < jogadoresOrdenados.Count; i += 2)
            {
                var jogador1 = jogadoresOrdenados[i];
                var jogador2 = jogadoresOrdenados[i + 1];

                // Criar a partida
                CreatePartida(partidaNum, torneioId, jogador1.Nome, jogador2.Nome);
                debugMessage.AppendLine($"Partida {partidaNum}: {jogador1.Nome} vs {jogador2.Nome}");
                partidaNum++;
            }

            MessageBox.Show(debugMessage.ToString(), "Debug Info");

            this.Close();
        }

        private bool TorneioTemJogadores(int torneioId)
        {
            // Verificar no banco de dados se o torneio já tem jogadores
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM PokeCup_TorneioJogador WHERE Torneio_ID = @TorneioId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TorneioId", torneioId);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }


        private int GetTorneioId(string selectedTorneio)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID FROM PokeCup_Torneio WHERE Nome = @Nome";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", selectedTorneio);
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return -1; // Indica que o torneio não foi encontrado
        }

        private void AddJogadorToTorneio(int torneioId, string jogador)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("AddJogadorToTorneio", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@torneioid", torneioId);
                    command.Parameters.AddWithValue("@jogador", jogador);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void CreatePartida(int num, int torneioId, string jogador1, string jogador2)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("CreatePartida", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@num", num);
                    command.Parameters.AddWithValue("@torneioid", torneioId);
                    command.Parameters.AddWithValue("@jogador1", jogador1);
                    command.Parameters.AddWithValue("@jogador2", jogador2);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void LoadTorneios()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PokeCup_Torneio";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable playersTable = new DataTable();
                adapter.Fill(playersTable);

                comboBoxTorneios.DataSource = playersTable;
                comboBoxTorneios.DisplayMember = "Nome";
                comboBoxTorneios.ValueMember = "Nome";
            }
        }

        private void comboBoxJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void listBoxJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadJogadores()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PokeCup_Jogador";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable playersTable = new DataTable();
                adapter.Fill(playersTable);

                listBoxJogadores.DataSource = playersTable;
                listBoxJogadores.DisplayMember = "Nickname";
                listBoxJogadores.ValueMember = "Nickname";
            }
        }


        private int GetMaxPlayers(string tournamentName)
        {
            int maxPlayers = 0;

            string query = "SELECT Num_Max_Jogadores FROM PokeCup_Torneio WHERE Nome = @Nome";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", tournamentName);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        maxPlayers = reader.GetInt32(0);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the maximum number of players: {ex.Message}");
            }

            return maxPlayers;
        }


        private void comboBoxTorneios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obter o torneio selecionado
            string selectedTorneio = comboBoxTorneios.SelectedValue?.ToString() ?? "DefaultTorneio";

            // Obter o número máximo de jogadores para o torneio selecionado
            int maxPlayers = GetMaxPlayers(selectedTorneio);

            // Muda a label labelEscolherJogadores
            labelEscolherJogadores.Text = $"Selecione {maxPlayers} jogadores";
        }




    }
}
