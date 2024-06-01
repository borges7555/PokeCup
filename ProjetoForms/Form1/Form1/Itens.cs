using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Form1
{
    public partial class Itens : Form
    {
        public Itens()
        {
            InitializeComponent();
            ConfigureListView();
        }

        private void Itens_Load(object sender, EventArgs e)
        {
            LoadItens();
        }

        private void ConfigureListView()
        {
            listViewItens.View = View.Details;
            listViewItens.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listViewItens.Columns.Add("Descricao", -2, HorizontalAlignment.Left);
            listViewItens.FullRowSelect = true;
            listViewItens.GridLines = true;
        }

        private void LoadItens()
        {
            string connectionString = "Server=mednat.ieeta.pt\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";
            string query = "SELECT * FROM PokeCup_Item";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    listViewItens.Items.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["Nome"].ToString());
                        item.SubItems.Add(row["Descricao"].ToString());
                        listViewItens.Items.Add(item);
                    }

                    // Ajustar a largura das colunas
                    foreach (ColumnHeader column in listViewItens.Columns)
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

        private void listViewItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
