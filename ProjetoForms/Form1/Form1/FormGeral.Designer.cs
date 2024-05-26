using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;

namespace Form1
{
    partial class FormGeral
    {
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button btnForm3;

        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnForm1 = new Button();
            btnForm2 = new Button();
            btnForm3 = new Button();
            panelMain = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.LightGray;
            panelSidebar.Controls.Add(button6);
            panelSidebar.Controls.Add(button5);
            panelSidebar.Controls.Add(button4);
            panelSidebar.Controls.Add(button3);
            panelSidebar.Controls.Add(button2);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(btnForm1);
            panelSidebar.Controls.Add(btnForm2);
            panelSidebar.Controls.Add(btnForm3);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(85, 450);
            panelSidebar.TabIndex = 1;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(0, 184);
            button6.Name = "button6";
            button6.Size = new Size(85, 23);
            button6.TabIndex = 8;
            button6.Text = "Rondas";
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 161);
            button5.Name = "button5";
            button5.Size = new Size(85, 23);
            button5.TabIndex = 7;
            button5.Text = "Partidas";
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(0, 138);
            button4.Name = "button4";
            button4.Size = new Size(85, 23);
            button4.TabIndex = 6;
            button4.Text = "Resultados";
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 115);
            button3.Name = "button3";
            button3.Size = new Size(85, 23);
            button3.TabIndex = 5;
            button3.Text = "Server";
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 92);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 4;
            button2.Text = "Pokemons";
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 69);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 3;
            button1.Text = "Equipas";
            button1.Click += button1_Click;
            // 
            // btnForm1
            // 
            btnForm1.Dock = DockStyle.Top;
            btnForm1.Location = new Point(0, 46);
            btnForm1.Name = "btnForm1";
            btnForm1.Size = new Size(85, 23);
            btnForm1.TabIndex = 0;
            btnForm1.Text = "Jogadores";
            btnForm1.Click += btnForm1_Click;
            // 
            // btnForm2
            // 
            btnForm2.Dock = DockStyle.Top;
            btnForm2.Location = new Point(0, 23);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(85, 23);
            btnForm2.TabIndex = 1;
            btnForm2.Text = "Torneios";
            btnForm2.Click += btnForm2_Click;
            // 
            // btnForm3
            // 
            btnForm3.Dock = DockStyle.Top;
            btnForm3.Location = new Point(0, 0);
            btnForm3.Name = "btnForm3";
            btnForm3.Size = new Size(85, 23);
            btnForm3.TabIndex = 2;
            btnForm3.Text = "Home";
            btnForm3.Click += btnForm3_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(85, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(715, 450);
            panelMain.TabIndex = 0;
            // 
            // FormGeral
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "FormGeral";
            Load += MainForm_Load;
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}