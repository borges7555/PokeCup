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
            LoadJogadores();
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
                    LoadJogadores(); // Recarrega os dados após criar um novo jogador
                }
            }
        }

        private void CreateJogador(string nickname, float wl)
        {
            string connectionString = ConnectionStringProvider.ConnectionString;
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

        private void LoadJogadores()
        {
            string connectionString = ConnectionStringProvider.ConnectionString;

            string query = "SELECT * FROM PokeCup_Jogador";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    listBoxJogadores.Items.Clear();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string jogadorInfo = $"Nickname: {row["Nickname"]}, W/L: {row["W_L"]}";
                        listBoxJogadores.Items.Add(jogadorInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void listBoxJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemoverJogador_Click(object sender, EventArgs e)
        {
            if (listBoxJogadores.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um jogador para remover.");
                return;
            }

            string jogadorInfo = listBoxJogadores.SelectedItem.ToString();
            string nickname = jogadorInfo.Split(',')[0].Split(':')[1].Trim();

            string connectionString = ConnectionStringProvider.ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DeleteJogador", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Nickname", nickname);
                        command.ExecuteNonQuery();
                    }
                }
                LoadJogadores(); // Recarrega os dados após remover um jogador
                MessageBox.Show("Jogador removido com sucesso.");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000) // Número de erro para RAISERROR
                {
                    MessageBox.Show(ex.Message); // Mostra a mensagem de erro definida no RAISERROR
                }
                else
                {
                    MessageBox.Show("Erro ao remover jogador: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
    }
}
