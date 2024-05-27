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
    public partial class FormGeral : Form
    {
        public FormGeral()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Carregar o formulário inicial no painel principal
            LoadForm(new ConnectToServer());
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
            LoadForm(new Rondas());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm(new ResultadosTorneios());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadForm(new Ataques());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadForm(new Partidas());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadForm(new Rondas());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            LoadForm(new Itens());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadForm(new Pokemons());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            LoadForm(new ConnectToServer());
        }
    }

}