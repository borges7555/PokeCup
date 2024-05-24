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
    public partial class Jogadores : Form
    {
        public Jogadores()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Defina sua string de conexão aqui
            string connectionString = "Server=mednat.ieeta.pt\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";


            // Crie a consulta SQL
            string query = "SELECT * FROM PokeCup_Jogador";

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
            using (AddJogadorPopUp addJogadorForm = new AddJogadorPopUp())
            {
                if (addJogadorForm.ShowDialog() == DialogResult.OK)
                {
                    string nickname = addJogadorForm.Nickname;
                    float wl = addJogadorForm.WL;
                    CreateJogador(nickname, wl);
                }
            }
        }

        private void CreateJogador(string nickname, float wl)
        {
            string connectionString = "Server=mednat.ieeta.pt\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("CreateJogador", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nickname", nickname);
                    command.Parameters.AddWithValue("@w_l", wl);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
