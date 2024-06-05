using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Form1.ConnectToServer;

namespace Form1
{
    public partial class Rondas : Form
    {
        public Rondas()
        {
            InitializeComponent();
            ConfigureListView();
            LoadRondas();
        }

        private string connectionString = ConnectionStringProvider.ConnectionString;

        private void ConfigureListView()
        {
            listViewRondas.View = View.Details;
            listViewRondas.Columns.Add("Numero", -2, HorizontalAlignment.Left);
            listViewRondas.Columns.Add("Num_Pokemons_Vivos_J1", -2, HorizontalAlignment.Left);
            listViewRondas.Columns.Add("Num_Pokemons_Vivos_J2", -2, HorizontalAlignment.Left);
            listViewRondas.Columns.Add("Partida_Numero", -2, HorizontalAlignment.Left);
            listViewRondas.Columns.Add("Torneio_ID", -2, HorizontalAlignment.Left);
            listViewRondas.Columns.Add("Jogador_Nickname_Vencedor", -2, HorizontalAlignment.Left);
            listViewRondas.FullRowSelect = true;
            listViewRondas.GridLines = true;
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

                    listViewRondas.Items.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["Numero"].ToString());
                        item.SubItems.Add(row["Num_Pokemons_Vivos_J1"].ToString());
                        item.SubItems.Add(row["Num_Pokemons_Vivos_J2"].ToString());
                        item.SubItems.Add(row["Partida_Numero"].ToString());
                        item.SubItems.Add(row["Torneio_ID"].ToString());
                        item.SubItems.Add(row["Jogador_Nickname_Vencedor"].ToString());
                        listViewRondas.Items.Add(item);
                    }

                    // Ajustar a largura das colunas
                    foreach (ColumnHeader column in listViewRondas.Columns)
                    {
                        column.Width = -2; // Auto ajuste da largura da coluna
                    }
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

        private void listViewRondas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código para lidar com a seleção de itens no ListView (se necessário)
        }
    }
}
