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

            string player = comboBoxPlayer.SelectedValue?.ToString() ?? "DefaultPlayer";
            string tier = comboBoxTier.SelectedItem?.ToString() ?? "DefaultTier";

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
            try
            {
                string player = comboBoxPlayer.SelectedValue?.ToString();
                string tier = comboBoxTier.SelectedItem?.ToString();

                if (player == null || tier == null || listBoxPokemons.Items.Count != 6)
                {
                    MessageBox.Show("Please select a player, tier, and exactly 6 Pokémon.");
                    return;
                }

                // Assuming listBoxPokemons contains Pokémon IDs as DataRowView
                List<int> pokemonIds = new List<int>();

                foreach (var item in listBoxPokemons.Items)
                {
                    if (item is DataRowView dataRowView)
                    {
                        var pokemonId = dataRowView["ID"]; // Correct column name for ID
                        if (pokemonId != null && int.TryParse(pokemonId.ToString(), out int id))
                        {
                            pokemonIds.Add(id);
                        }
                        else
                        {
                            MessageBox.Show($"Invalid Pokémon ID format: {pokemonId}");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Invalid item type in list: {item.GetType()}");
                        return;
                    }
                }

                if (pokemonIds.Count != 6)
                {
                    MessageBox.Show("Failed to retrieve all Pokémon IDs.");
                    return;
                }

                // Debugging: Print Pokémon IDs
                string ids = string.Join(", ", pokemonIds);
                MessageBox.Show($"Pokémon IDs to insert: {ids}");

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "EXEC CreateEquipaPokemons @jogador, @tier, @pokemon1, @pokemon2, @pokemon3, @pokemon4, @pokemon5, @pokemon6";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@jogador", player);
                    command.Parameters.AddWithValue("@tier", tier);
                    command.Parameters.AddWithValue("@pokemon1", pokemonIds[0]);
                    command.Parameters.AddWithValue("@pokemon2", pokemonIds[1]);
                    command.Parameters.AddWithValue("@pokemon3", pokemonIds[2]);
                    command.Parameters.AddWithValue("@pokemon4", pokemonIds[3]);
                    command.Parameters.AddWithValue("@pokemon5", pokemonIds[4]);
                    command.Parameters.AddWithValue("@pokemon6", pokemonIds[5]);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Team created successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the team: {ex.Message}");
            }
        }








        // Equipas.cs
        private void buttonAddPokemon_Click(object sender, EventArgs e)
        {
            using (var form = new PokemonForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Chamar a stored procedure com os dados selecionados
                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        var command = new SqlCommand("EXEC CreatePokemonEscolhido @nome, @ataque1, @ataque2, @ataque3, @ataque4, @item, @jogador", connection);
                        command.Parameters.AddWithValue("@nome", form.SelectedPokemon);
                        command.Parameters.AddWithValue("@ataque1", form.SelectedAtaques[0]);
                        command.Parameters.AddWithValue("@ataque2", form.SelectedAtaques[1]);
                        command.Parameters.AddWithValue("@ataque3", form.SelectedAtaques[2]);
                        command.Parameters.AddWithValue("@ataque4", form.SelectedAtaques[3]);
                        command.Parameters.AddWithValue("@item", form.SelectedItem);
                        command.Parameters.AddWithValue("@jogador", "Joaquim"); // Substitua pelo jogador real

                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PokemonForm form = new PokemonForm();
            form.Show(); // Ou form.ShowDialog(); dependendo do comportamento desejado
        }
    }
}
