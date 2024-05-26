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

namespace Form1
{
    public partial class ResultadosTorneios : Form
    {
        public ResultadosTorneios()
        {
            InitializeComponent();
            LoadTorneios();
        }

        private string connectionString = "Server=mednat.ieeta.pt\\\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";


        private void dataGridViewJogadoresParticiparam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxTorneios_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadJogadores();
            LoadBatalhas();
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
                comboBoxTorneios.ValueMember = "ID";
            }
        }

        private void dataGridViewBatalhas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadJogadores()
        {
            string selectedTorneioID = comboBoxTorneios.SelectedValue?.ToString() ?? "DefaultTorneio";

            if (selectedTorneioID == "DefaultTorneio")
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Jogador_Nickname FROM PokeCup_TorneioJogador WHERE Torneio_ID = @TorneioID;";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@TorneioID", selectedTorneioID);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewJogadoresParticiparam.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        private void LoadBatalhas()
        {
            string selectedTorneioID = comboBoxTorneios.SelectedValue?.ToString() ?? "DefaultTorneio";

            if (selectedTorneioID == "DefaultTorneio")
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Numero, Torneio_ID, Jogador_Nickname_1, Jogador_Nickname_2 FROM PokeCup_Partida WHERE Torneio_ID = @TorneioID";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@TorneioID", selectedTorneioID);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Adicionar coluna concatenada para exibir as partidas de forma organizada
                    dataTable.Columns.Add("Descricao", typeof(string), "'Partida ' + Convert(Numero, 'System.String') + ': ' + Jogador_Nickname_1 + ' vs ' + Jogador_Nickname_2");

                    comboBoxEscolherBatalha.DataSource = dataTable;
                    comboBoxEscolherBatalha.DisplayMember = "Descricao"; // Usar a nova coluna concatenada
                    comboBoxEscolherBatalha.ValueMember = "Numero"; // Usar o número da partida como valor

                    dataGridViewJogadoresParticiparam.DataSource = dataTable; // Exibir as partidas na data grid view
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        private void LoadRondas()
        {
            string selectedTorneioID = comboBoxTorneios.SelectedValue?.ToString() ?? "DefaultTorneio";
            string selectedPartida = comboBoxEscolherBatalha.SelectedValue?.ToString() ?? "DefaultTorneio";

            if (selectedTorneioID == "DefaultTorneio")
            {
                return;
            }

            if (selectedPartida == "DefaultTorneio")
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Numero, Num_Pokemons_Vivos_J1, Num_Pokemons_Vivos_J2, Jogador_Nickname_Vencedor FROM PokeCup_Ronda WHERE Torneio_ID = @TorneioID AND Partida_Numero = @PartidaNumero";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@TorneioID", selectedTorneioID);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@PartidaNumero", selectedPartida);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Adicionar coluna concatenada para exibir as rondas de forma organizada
                    dataTable.Columns.Add("Descricao", typeof(string), "'Ronda ' + Convert(Numero, 'System.String') + ': ' + Jogador_Nickname_Vencedor + ' com ' + Convert(Num_Pokemons_Vivos_J1, 'System.String') + ' vs ' + Convert(Num_Pokemons_Vivos_J2, 'System.String') + ' pokémons vivos'");

                    comboBoxEscolherRondas.DataSource = dataTable;
                    comboBoxEscolherRondas.DisplayMember = "Descricao"; // Usar a nova coluna concatenada
                    comboBoxEscolherRondas.ValueMember = "Numero"; // Usar o número da ronda como valor

                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Erro ao carregar as rondas: " + ex.Message);
                }
            }
        }

        private void LoadResultados()
        {
            string selectedTorneioID = comboBoxTorneios.SelectedValue?.ToString() ?? "DefaultTorneio";
            string selectedPartida = comboBoxEscolherBatalha.SelectedValue?.ToString() ?? "DefaultTorneio";
            string selectedRonda = comboBoxEscolherRondas.SelectedValue?.ToString() ?? "DefaultTorneio";

            if (selectedTorneioID == "DefaultTorneio")
            {
                return;
            }
            if (selectedPartida == "DefaultTorneio")
            {
                return;
            }
            if (selectedRonda == "DefaultTorneio")
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM PokeCup_ResultadoFinal WHERE Torneio_ID = @TorneioID AND Partida_Numero = @PartidaNumero";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@TorneioID", selectedTorneioID);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@PartidaNumero", selectedPartida);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridViewRondasResultados.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Erro ao carregar os resultados: " + ex.Message);
                }
            }
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEscolherRondas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewRondasResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxEscolherBatalha_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRondas();
            LoadResultados();
        }
    }
}
