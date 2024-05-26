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
    public partial class ResultadosTorneios : Form
    {
        public ResultadosTorneios()
        {
            InitializeComponent();
            LoadTorneios();
            LoadJogadores();
        }

        private string connectionString = "Server=mednat.ieeta.pt\\\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";


        private void dataGridViewJogadoresParticiparam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxTorneios_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadJogadores();
        }

        private void LoadTorneios()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PokeCup_Torneio";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable playersTable = new DataTable();
                adapter.Fill(playersTable);

                comboBoxTorneios.DataSource = playersTable;
                comboBoxTorneios.DisplayMember = "Nome";
                comboBoxTorneios.ValueMember = "ID";
            }
        }

        private void dataGridViewBatalhas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadJogadores()
        {
            string selectedTorneioID = comboBoxTorneios.SelectedValue?.ToString() ?? "DefaultTorneio";

            if (selectedTorneioID == "DefaultTorneio")
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Jogador_Nickname FROM PokeCup_TorneioJogador WHERE Torneio_ID = @TorneioID;";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@TorneioID", selectedTorneioID);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewJogadoresParticiparam.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEscolherRondas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewRondasResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxEscolherBatalha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
