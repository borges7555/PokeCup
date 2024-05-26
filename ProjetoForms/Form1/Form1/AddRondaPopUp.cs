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
    public partial class AddRondaPopUp : Form
    {
        public AddRondaPopUp()
        {
            InitializeComponent();
            LoadTorneios();
        }

        private string connectionString = "Server=mednat.ieeta.pt\\\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";

        private void comboBoxTorneios_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                comboBoxTorneios.ValueMember = "Nome";
            }
        }

        private void buttonSimular_Click(object sender, EventArgs e)
        {
            // Obter o torneio selecionado
            string selectedTorneio = comboBoxTorneios.SelectedValue?.ToString() ?? "DefaultTorneio";

            // Obter o ID do torneio a partir do nome
            int selectedTorneioId = GetTorneioId(selectedTorneio);
        }

        private int GetTorneioId(string selectedTorneio)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID FROM PokeCup_Torneio WHERE Nome = @Nome";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", selectedTorneio);
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return -1; // Indica que o torneio não foi encontrado
        }
    }
}
