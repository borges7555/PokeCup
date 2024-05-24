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
    public partial class PokemonForm : Form
    {
        public string SelectedPokemon { get; private set; }
        public string[] SelectedAtaques { get; private set; }
        public string SelectedItem { get; private set; }

        private string connectionString = "Server=mednat.ieeta.pt\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";


        public PokemonForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Carregar Pokémon
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM GetPokemonsFromTier('Uber');", connection);
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
            SelectedPokemon = comboBoxPokemon.SelectedItem.ToString();
            SelectedAtaques = new string[]
            {
            comboBoxAtaque1.SelectedItem.ToString(),
            comboBoxAtaque2.SelectedItem.ToString(),
            comboBoxAtaque3.SelectedItem.ToString(),
            comboBoxAtaque4.SelectedItem.ToString()
            };
            SelectedItem = comboBoxItem.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }
    }

}
