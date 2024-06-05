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
    public partial class ResultadosTorneios : Form
    {
        public ResultadosTorneios()
        {
            InitializeComponent();
            LoadTorneios();
        }

        private string connectionString = ConnectionStringProvider.ConnectionString;


        private void dataGridViewJogadoresParticiparam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxTorneios_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadJogadores();
            LoadBatalhas();
            LoadVencedor();
        }

        private void LoadTorneios()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PokeCup_Torneio";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable torneiosTable = new DataTable();
                adapter.Fill(torneiosTable);

                // Adicionar a linha "Escolher Torneio" ao DataTable
                DataRow newRow = torneiosTable.NewRow();
                newRow["ID"] = 0;
                newRow["Nome"] = "Escolher Torneio";
                torneiosTable.Rows.InsertAt(newRow, 0);

                comboBoxTorneios.DataSource = torneiosTable;
                comboBoxTorneios.DisplayMember = "Nome";
                comboBoxTorneios.ValueMember = "ID";

                // Definir a seleção inicial para "Escolher Torneio"
                comboBoxTorneios.SelectedIndex = 0;
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

                    listBoxJogadores.Items.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        listBoxJogadores.Items.Add(row["Jogador_Nickname"].ToString());
                    }
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
                    string query = @"
                SELECT 
                    Numero, 
                    Torneio_ID, 
                    Jogador_Nickname_1, 
                    Jogador_Nickname_2, 
                    Jogador_Nickname_Vencedor, 
                    Num_Rondas_Ganhas_J1, 
                    Num_Rondas_Ganhas_J2
                FROM 
                    View_PartidaResultado
                WHERE 
                    Torneio_ID = @TorneioID";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@TorneioID", selectedTorneioID);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Adicionar coluna concatenada para exibir as partidas de forma organizada
                    dataTable.Columns.Add("Descricao", typeof(string));
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string descricaoPartida = $"Partida {row["Numero"]}: {row["Jogador_Nickname_1"]} vs {row["Jogador_Nickname_2"]}";
                        if (!DBNull.Value.Equals(row["Jogador_Nickname_Vencedor"]))
                        {
                            descricaoPartida += $" - Vencedor: {row["Jogador_Nickname_Vencedor"]} (J1: {row["Num_Rondas_Ganhas_J1"]} vs J2: {row["Num_Rondas_Ganhas_J2"]})";
                        }
                        row["Descricao"] = descricaoPartida;
                    }

                    // Adicionar item padrão ao DataTable
                    DataRow defaultRow = dataTable.NewRow();
                    defaultRow["Numero"] = 0; // ou outro valor que faça sentido como padrão
                    defaultRow["Descricao"] = "Selecione uma Partida";
                    dataTable.Rows.InsertAt(defaultRow, 0);

                    comboBoxEscolherBatalha.DataSource = dataTable;
                    comboBoxEscolherBatalha.DisplayMember = "Descricao"; // Usar a nova coluna concatenada
                    comboBoxEscolherBatalha.ValueMember = "Numero"; // Usar o número da partida como valor

                    comboBoxEscolherBatalha.SelectedIndex = 0; // Selecionar o item padrão
                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
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
                    string query = @"
                SELECT 
                    Numero, 
                    Num_Pokemons_Vivos_J1, 
                    Num_Pokemons_Vivos_J2, 
                    Jogador_Nickname_Vencedor, 
                    Jogador_Nickname_1, 
                    Jogador_Nickname_2
                FROM 
                    View_RondaDetalhes
                WHERE 
                    Torneio_ID = @TorneioID AND Partida_Numero = @PartidaNumero";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@TorneioID", selectedTorneioID);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@PartidaNumero", selectedPartida);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    listBoxRondas.Items.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string descricaoRonda = $"Ronda {row["Numero"]}: {row["Jogador_Nickname_1"]} ({row["Num_Pokemons_Vivos_J1"]} pokémons vivos) vs {row["Jogador_Nickname_2"]} ({row["Num_Pokemons_Vivos_J2"]} pokémons vivos) - Vencedor: {row["Jogador_Nickname_Vencedor"]}";
                        listBoxRondas.Items.Add(descricaoRonda);
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Erro ao carregar as rondas: " + ex.Message);
                }
            }
        }






        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoadVencedor()
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
                    string query = @"
                SELECT TOP 1 Jogador_Nickname_Vencedor 
                FROM PokeCup_ResultadoFinal 
                WHERE Torneio_ID = @TorneioID 
                ORDER BY Partida_Numero DESC";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TorneioID", selectedTorneioID);

                    string vencedor = (string)command.ExecuteScalar();

                    if (!string.IsNullOrEmpty(vencedor))
                    {
                        label5.Text = $"Vencedor: {vencedor}";
                    }
                    else
                    {
                        label5.Text = "Vencedor: ______";
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Erro ao carregar o vencedor: " + ex.Message);
                }
            }
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
        }

        private void listBoxRondas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
