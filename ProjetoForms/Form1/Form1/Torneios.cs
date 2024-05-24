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
    public partial class Torneios : Form
    {
        public Torneios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Defina sua string de conexão aqui
            string connectionString = "Server=mednat.ieeta.pt\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";


            // Crie a consulta SQL
            string query = "SELECT * FROM PokeCup_Torneio";

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


        // Botão criar torneio
        private void button5_Click(object sender, EventArgs e)
        {
            AddTorneioPopUp createTournamentForm = new AddTorneioPopUp();
            createTournamentForm.ShowDialog();

        }

        private void buttonSimularTorneio_Click(object sender, EventArgs e)
        {
            SimularTorneioPopUp simularTorneioPopup = new SimularTorneioPopUp();
            simularTorneioPopup.ShowDialog();
        }
    }
}
