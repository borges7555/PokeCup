using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Form1.ConnectToServer;

namespace Form1
{
    public partial class Ataques : Form
    {
        public Ataques()
        {
            InitializeComponent();
            ConfigureListView();
        }

        private void Ataques_Load(object sender, EventArgs e)
        {
            LoadAtaques();
        }

        private void ConfigureListView()
        {
            listViewAtaques.View = View.Details;
            listViewAtaques.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listViewAtaques.Columns.Add("Tipo", -2, HorizontalAlignment.Left);
            listViewAtaques.Columns.Add("Poder", -2, HorizontalAlignment.Left);
            listViewAtaques.Columns.Add("Accuracy", -2, HorizontalAlignment.Left);
            listViewAtaques.Columns.Add("Categoria", -2, HorizontalAlignment.Left);
            listViewAtaques.FullRowSelect = true;
            listViewAtaques.GridLines = true;
        }

        private void LoadAtaques()
        {
            string connectionString = ConnectionStringProvider.ConnectionString;
            string query = "SELECT * FROM PokeCup_Ataque";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    listViewAtaques.Items.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["Nome"].ToString());
                        item.SubItems.Add(row["Tipo"].ToString());
                        item.SubItems.Add(row["Poder"].ToString());
                        item.SubItems.Add(row["Accuracy"].ToString());
                        item.SubItems.Add(row["Categoria"].ToString());
                        listViewAtaques.Items.Add(item);
                    }

                    // Ajustar a largura das colunas
                    foreach (ColumnHeader column in listViewAtaques.Columns)
                    {
                        column.Width = -2; // Auto ajuste da largura da coluna
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void listViewAtaques_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código para lidar com a seleção de itens no ListView (se necessário)
        }
    }
}
