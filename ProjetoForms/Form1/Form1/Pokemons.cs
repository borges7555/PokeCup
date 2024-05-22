using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;

namespace Form1
{
    public partial class Pokemons : Form
    {
        public Pokemons()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Defina sua string de conexão aqui
            string connectionString = "Server=mednat.ieeta.pt\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";


            // Crie a consulta SQL
            string query = "SELECT * FROM PokeCup_Pokemons";

            try
            {
                // Use SqlConnection, SqlDataAdapter e DataTable para preencher o DataGridView
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPokemonForm addPokemonForm = new AddPokemonForm();
            if (addPokemonForm.ShowDialog() == DialogResult.OK)
            {
                // Lógica para adicionar o Pokémon ao seu sistema
                // Utilize as propriedades públicas do addPokemonForm para obter os valores
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
