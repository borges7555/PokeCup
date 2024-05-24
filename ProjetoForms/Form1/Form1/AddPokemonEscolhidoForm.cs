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
    // PokemonForm.cs
    public partial class AddPokemonEscolhidoForm : Form
    {
        public string SelectedPokemon { get; private set; }
        public string[] SelectedAtaques { get; private set; }
        public string SelectedItem { get; private set; }
        public string SelectedTier { get; private set; }

        public string SelectedPlayer { get; private set; }

        private string connectionString = "Server=mednat.ieeta.pt\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";


        public AddPokemonEscolhidoForm(string player, string tier) // Constructor to accept tier
        {
            InitializeComponent();
            SelectedPlayer = player;
            SelectedTier = tier;
            LoadData(); // Call LoadData after setting SelectedTier
        }

        private void LoadData()
        {
            //MessageBox.Show($"Selected Player: {SelectedPlayer}");
            //MessageBox.Show($"Selected Tier: {SelectedTier}");
            // Carregar Pokémon
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand($"SELECT * FROM GetPokemonsFromTier('{SelectedTier}');", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxPokemon.Items.Add(reader["Nome"].ToString());
                    }
                }
            }

            // Carregar Ataques
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM PokeCup_Ataque;", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxAtaque1.Items.Add(reader["Nome"].ToString());
                        comboBoxAtaque2.Items.Add(reader["Nome"].ToString());
                        comboBoxAtaque3.Items.Add(reader["Nome"].ToString());
                        comboBoxAtaque4.Items.Add(reader["Nome"].ToString());
                    }
                }
            }

            // Carregar Itens
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM PokeCup_Item;", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxItem.Items.Add(reader["Nome"].ToString());
                    }
                }
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = comboBoxPokemon.SelectedItem?.ToString() ?? "";
                string ataque1 = comboBoxAtaque1.SelectedItem?.ToString() ?? "";
                string ataque2 = comboBoxAtaque2.SelectedItem?.ToString() ?? "";
                string ataque3 = comboBoxAtaque3.SelectedItem?.ToString() ?? "";
                string ataque4 = comboBoxAtaque4.SelectedItem?.ToString() ?? "";
                string item = comboBoxItem.SelectedItem?.ToString() ?? "";
                string jogador = SelectedPlayer;

                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(ataque1) || string.IsNullOrEmpty(ataque2) || string.IsNullOrEmpty(ataque3) || string.IsNullOrEmpty(ataque4) || string.IsNullOrEmpty(item))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.");
                    return;
                }

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("EXEC CreatePokemonEscolhido @nome, @ataque1, @ataque2, @ataque3, @ataque4, @item, @jogador", connection);
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@ataque1", ataque1);
                    command.Parameters.AddWithValue("@ataque2", ataque2);
                    command.Parameters.AddWithValue("@ataque3", ataque3);
                    command.Parameters.AddWithValue("@ataque4", ataque4);
                    command.Parameters.AddWithValue("@item", item);
                    command.Parameters.AddWithValue("@jogador", jogador);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Pokémon criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void comboBoxPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
