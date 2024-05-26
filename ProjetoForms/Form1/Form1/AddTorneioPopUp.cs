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
    public partial class AddTorneioPopUp : Form
    {
        public AddTorneioPopUp()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
        }

        private void NomeTorneio_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNomeTorneio_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Uber", "OU", "UU", "PU", "NU", "RU" });
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Gather form inputs
            string nome = textBoxNomeTorneio.Text;
            string tier = comboBox1.SelectedItem?.ToString();
            DateTime data = dateTimePicker1.Value;
            string localizacao = texBoxLocalizacao.Text;
            string nMaxText = textBoxNMaxJogadores.Text;

            // Validation checks
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(tier) || string.IsNullOrEmpty(localizacao) || string.IsNullOrEmpty(nMaxText))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(nMaxText, out int nMax))
            {
                MessageBox.Show("O número máximo de jogadores deve ser um valor inteiro válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Format the date
            string dataFormatted = data.ToString("yyyy-MM-dd");

            // Debug message boxes
            //MessageBox.Show($"nome: {nome}");
            //MessageBox.Show($"tier: {tier}");
            //MessageBox.Show($"data: {dataFormatted}");
            //MessageBox.Show($"localizacao: {localizacao}");
            //MessageBox.Show($"nMax: {nMax}");

            // Connection string and database insertion
            string connectionString = "Server=mednat.ieeta.pt\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("CreateTorneio", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@tier", tier);
                command.Parameters.AddWithValue("@data", dataFormatted);
                command.Parameters.AddWithValue("@localizacao", localizacao);
                command.Parameters.AddWithValue("@nmax", nMax);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Torneio criado com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar torneio: " + ex.Message);
                }
            }
        }


    }
}
