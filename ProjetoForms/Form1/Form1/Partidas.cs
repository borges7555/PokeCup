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
    public partial class Partidas : Form
    {
        public Partidas()
        {
            InitializeComponent();
            LoadPartidas();
        }

        private string connectionString = ConnectionStringProvider.ConnectionString;

        private void dataGridViewPartidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadPartidas()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM PokeCup_Partida;";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewPartidas.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }
    }
}
