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
    public partial class Ataques : Form
    {
        public Ataques()
        {
            InitializeComponent();
        }

        private void dataGridViewAtaques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ataques_Load(object sender, EventArgs e)
        {
            // Defina sua string de conexão aqui
            string connectionString = "Server=mednat.ieeta.pt\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";


            // Crie a consulta SQL
            string query = "SELECT * FROM PokeCup_Ataque";

            try
            {
                // Use SqlConnection, SqlDataAdapter e DataTable para preencher o DataGridView
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewAtaques.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
    }
}
