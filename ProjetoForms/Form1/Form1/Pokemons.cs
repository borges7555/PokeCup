using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Form1
{
    public partial class Pokemons : Form
    {
        private ImageList imageList;

        public Pokemons()
        {
            InitializeComponent();
            ConfigureListView();
            ConfigurePictureBox();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadPokemons();
        }

        private void ConfigureListView()
        {
            listViewPokemons.View = View.Details;
            listViewPokemons.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listViewPokemons.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            listViewPokemons.Columns.Add("Tipo1", 100, HorizontalAlignment.Left);
            listViewPokemons.Columns.Add("Tipo2", 100, HorizontalAlignment.Left);
            listViewPokemons.Columns.Add("Tier", 50, HorizontalAlignment.Left);
            listViewPokemons.Columns.Add("Imagem", 0, HorizontalAlignment.Left); // Adicionando a coluna de Imagem com largura 0 para armazenar o caminho da imagem
            listViewPokemons.FullRowSelect = true;
            listViewPokemons.GridLines = true;
            listViewPokemons.SelectedIndexChanged += listViewPokemons_SelectedIndexChanged;

            imageList = new ImageList();
            imageList.ImageSize = new Size(64, 64);
            listViewPokemons.LargeImageList = imageList;
        }

        private void ConfigurePictureBox()
        {
            pictureBoxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadPokemons()
        {
            string connectionString = "Server=mednat.ieeta.pt\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";

            string query = "SELECT * FROM PokeCup_Pokemons";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    listViewPokemons.Items.Clear();
                    imageList.Images.Clear();
                    int imageIndex = 0;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["ID"].ToString());
                        item.SubItems.Add(row["Nome"].ToString());
                        item.SubItems.Add(row["Tipo1"].ToString());
                        item.SubItems.Add(row["Tipo2"].ToString());
                        item.SubItems.Add(row["Tier"].ToString());
                        item.SubItems.Add(row["Imagem"].ToString()); // Adicionando o caminho da imagem como um subitem

                        string imagePath = row["Imagem"].ToString();
                        if (System.IO.File.Exists(imagePath))
                        {
                            imageList.Images.Add(Image.FromFile(imagePath));
                            item.ImageIndex = imageIndex++;
                        }
                        else
                        {
                            Console.WriteLine($"Image not found at path: {imagePath}");
                        }

                        listViewPokemons.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void listViewPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPokemons.SelectedItems.Count > 0)
            {
                string imagePath = listViewPokemons.SelectedItems[0].SubItems[5].Text;
                if (System.IO.File.Exists(imagePath))
                {
                    //MessageBox.Show("Image found at path: " + imagePath);
                    pictureBoxPokemon.Image = Image.FromFile(imagePath);
                }
                else
                {
                    //MessageBox.Show("Image not found at path: " + imagePath);
                    pictureBoxPokemon.Image = null;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //AddPokemonPopUp addPokemonForm = new AddPokemonPopUp();
            //if (addPokemonForm.ShowDialog() == DialogResult.OK)
            //{
            // Lógica para adicionar o Pokémon ao sistema
            //}
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBoxPokemon_Click(object sender, EventArgs e)
        {

        }
    }
}
