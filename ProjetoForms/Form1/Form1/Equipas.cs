using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Form1
{
    public partial class Equipas : Form
    {
        private string connectionString = "Server=mednat.ieeta.pt\\\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";

        public Equipas()
        {
            InitializeComponent();
            LoadTeams();
        }

        private void Equipas_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Nickname FROM PokeCup_Jogador"; // Correct table name
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable playersTable = new DataTable();
                adapter.Fill(playersTable);

                comboBoxPlayer.DataSource = playersTable;
                comboBoxPlayer.DisplayMember = "Nickname";
                comboBoxPlayer.ValueMember = "Nickname";
            }
        }

        private void comboBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPokemons();
        }

        private void comboBoxTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPokemons();
        }

        // Open PokemonForm
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxTier.SelectedItem == null || string.IsNullOrEmpty(comboBoxTier.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select a tier before proceeding.", "Tier Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string player = comboBoxPlayer.SelectedValue?.ToString() ?? "DefaultPlayer";
            string tier = comboBoxTier.SelectedItem?.ToString() ?? "DefaultTier";
            AddPokemonEscolhidoPopUp form = new AddPokemonEscolhidoPopUp(player, tier); // Pass the selected tier
            form.Show(); // Or form.ShowDialog(); depending on the desired behavior
        }



        private void LoadPokemons()
        {
            if (comboBoxPlayer.SelectedValue == null || comboBoxTier.SelectedItem == null) return;

            string player = comboBoxPlayer.SelectedValue?.ToString() ?? "DefaultPlayer";
            string tier = comboBoxTier.SelectedItem?.ToString() ?? "DefaultTier";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT EscolhidoID, Nome FROM GetPokemonsFromJogadorAndTier('{player}', '{tier}')";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable pokemonsTable = new DataTable();
                adapter.Fill(pokemonsTable);

                listBoxPokemons.DataSource = pokemonsTable;
                listBoxPokemons.DisplayMember = "Nome"; // Display Pokémon names
                listBoxPokemons.ValueMember = "EscolhidoID"; // Use Pokémon IDs as values
            }
        }

        private void buttonCreateTeam_Click(object sender, EventArgs e)
        {
            if (listBoxPokemons.SelectedItems.Count < 6)
            {
                MessageBox.Show("Please select 6 pokemons to create a team.");
                return;
            }

            string player = comboBoxPlayer.SelectedValue.ToString();
            string tier = comboBoxTier.SelectedItem.ToString();

            // Collect the selected Pokemon IDs
            var selectedPokemons = listBoxPokemons.SelectedItems.Cast<DataRowView>()
                                     .Select(item => item["EscolhidoID"].ToString())
                                     .ToArray();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("CreateEquipaPokemons", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@jogador", player);
                command.Parameters.AddWithValue("@tier", tier);
                for (int i = 0; i < 6; i++)
                {
                    command.Parameters.AddWithValue($"@pokemon{i + 1}", selectedPokemons[i]);
                }

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Team created successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating team: " + ex.Message);
                }
            }
        }

        private void LoadTeams()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM PokeCup_EquipaPokemons;";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        // Lista
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
