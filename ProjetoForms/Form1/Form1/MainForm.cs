using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Carregar o formulário inicial no painel principal
            LoadForm(new HomePage());
        }

        private void LoadForm(Form form)
        {
            // Limpa o painel principal
            panelMain.Controls.Clear();

            // Ajusta o formulário ao painel principal
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            LoadForm(new Jogadores());
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            LoadForm(new Torneios());
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            LoadForm(new HomePage());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new Equipas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new Pokemons());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm(new ConnectToServer());
        }
    }

}