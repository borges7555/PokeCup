using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Form1
{
    public partial class Equipas : Form
    {
        private string connectionString = "Server=mednat.ieeta.pt\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";

        public Equipas()
        {
            InitializeComponent();
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

        private void LoadPokemons()
        {
            if (comboBoxPlayer.SelectedValue == null || comboBoxTier.SelectedItem == null) return;

            string player = comboBoxPlayer.SelectedValue.ToString();
            string tier = comboBoxTier.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT * FROM GetPokemonsFromJogadorAndTier('{player}', '{tier}')"; // Adjusted query
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable pokemonsTable = new DataTable();
                adapter.Fill(pokemonsTable);

                // Debugging output to ensure DataTable is populated
                Console.WriteLine($"Rows Count: {pokemonsTable.Rows.Count}");
                foreach (DataRow row in pokemonsTable.Rows)
                {
                    Console.WriteLine($"{row["Pokemons_Nome"]}");
                }

                listBoxPokemons.DataSource = pokemonsTable;
                listBoxPokemons.DisplayMember = "Pokemons_Nome";
                listBoxPokemons.ValueMember = "Pokemons_Nome"; // Updated to match the actual column name
            }
        }

        private void buttonCreateTeam_Click(object sender, EventArgs e)
        {
            if (comboBoxPlayer.SelectedValue == null || comboBoxTier.SelectedItem == null || listBoxPokemons.SelectedItems.Count != 6)
            {
                MessageBox.Show("Please select a player, tier, and exactly 6 Pokémon.");
                return;
            }

            string player = comboBoxPlayer.SelectedValue.ToString();
            string tier = comboBoxTier.SelectedItem.ToString();
            string[] pokemonNames = new string[6];
            for (int i = 0; i < 6; i++)
            {
                pokemonNames[i] = ((DataRowView)listBoxPokemons.SelectedItems[i])["Pokemons_Nome"].ToString();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("CreateEquipaPokemons", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@jogador", player);
                command.Parameters.AddWithValue("@tier", tier);
                for (int i = 0; i < 6; i++)
                {
                    command.Parameters.AddWithValue($"@pokemon{i + 1}", pokemonNames[i]);
                }

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Team created successfully!");
        }
    }
}
