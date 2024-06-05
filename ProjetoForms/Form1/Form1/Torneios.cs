using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Form1.ConnectToServer;

namespace Form1
{
    public partial class Torneios : Form
    {
        public Torneios()
        {
            InitializeComponent();
            ConfigureListView();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadTorneios();
        }

        private void ConfigureListView()
        {
            listViewTorneios.View = View.Details;
            listViewTorneios.Columns.Add("ID", -2, HorizontalAlignment.Left);
            listViewTorneios.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listViewTorneios.Columns.Add("Tier", -2, HorizontalAlignment.Left);
            listViewTorneios.Columns.Add("Data", -2, HorizontalAlignment.Left);
            listViewTorneios.Columns.Add("Localizacao", -2, HorizontalAlignment.Left);
            listViewTorneios.Columns.Add("Num_Max_Jogadores", -2, HorizontalAlignment.Left);
            listViewTorneios.FullRowSelect = true;
            listViewTorneios.GridLines = true;
        }

        private void LoadTorneios()
        {
            string connectionString = ConnectionStringProvider.ConnectionString;
            string query = "SELECT * FROM PokeCup_Torneio";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    listViewTorneios.Items.Clear();

                    foreach (DataRow row in dataTable.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["ID"].ToString());
                        item.SubItems.Add(row["Nome"].ToString());
                        item.SubItems.Add(row["Tier"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(row["Data"]).ToString("yyyy-MM-dd"));
                        item.SubItems.Add(row["Localizacao"].ToString());
                        item.SubItems.Add(row["Num_Max_Jogadores"].ToString());

                        listViewTorneios.Items.Add(item);
                    }

                    // Ajustar a largura das colunas
                    foreach (ColumnHeader column in listViewTorneios.Columns)
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

        private void button5_Click(object sender, EventArgs e)
        {
            AddTorneioPopUp createTournamentForm = new AddTorneioPopUp();
            createTournamentForm.ShowDialog();
            LoadTorneios(); // Recarrega os dados após criar um novo torneio
        }

        private void buttonSimularTorneio_Click(object sender, EventArgs e)
        {
            CriarPartidasPopUp simularTorneioPopup = new CriarPartidasPopUp();
            simularTorneioPopup.ShowDialog();
        }

        private void listViewTorneios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
