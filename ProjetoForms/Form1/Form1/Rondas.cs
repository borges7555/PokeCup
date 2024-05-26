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
    public partial class Rondas : Form
    {
        public Rondas()
        {
            InitializeComponent();
            LoadRondas();
        }

        private string connectionString = "Server=mednat.ieeta.pt\\\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";


        private void dataGridViewRondas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadRondas()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM PokeCup_Ronda;";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewRondas.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        private void buttonCriarRonda_Click(object sender, EventArgs e)
        {
            AddRondaPopUp createRondaPopUp = new AddRondaPopUp();
            createRondaPopUp.ShowDialog();
        }
    }
}
