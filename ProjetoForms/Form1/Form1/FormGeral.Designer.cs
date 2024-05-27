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

        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            button6 = new Button();
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnForm1 = new Button();
            btnForm2 = new Button();
            panelMain = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = SystemColors.ButtonFace;
            panelSidebar.Controls.Add(button6);
            panelSidebar.Controls.Add(button7);
            panelSidebar.Controls.Add(button5);
            panelSidebar.Controls.Add(button4);
            panelSidebar.Controls.Add(button3);
            panelSidebar.Controls.Add(button2);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Controls.Add(btnForm1);
            panelSidebar.Controls.Add(btnForm2);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(113, 638);
            panelSidebar.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSalmon;
            button6.Dock = DockStyle.Top;
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(0, 320);
            button6.Name = "button6";
            button6.Size = new Size(113, 40);
            button6.TabIndex = 11;
            button6.Text = "Server";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_2;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Highlight;
            button7.Dock = DockStyle.Top;
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(0, 280);
            button7.Name = "button7";
            button7.Size = new Size(113, 40);
            button7.TabIndex = 10;
            button7.Text = "Pokemons";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Highlight;
            button5.Dock = DockStyle.Top;
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(0, 240);
            button5.Name = "button5";
            button5.Size = new Size(113, 40);
            button5.TabIndex = 9;
            button5.Text = "Itens";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Dock = DockStyle.Top;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(0, 200);
            button4.Name = "button4";
            button4.Size = new Size(113, 40);
            button4.TabIndex = 6;
            button4.Text = "Ataques";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Desktop;
            button3.Dock = DockStyle.Top;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(0, 160);
            button3.Name = "button3";
            button3.Size = new Size(113, 40);
            button3.TabIndex = 5;
            button3.Text = "Resultados";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Desktop;
            button2.Dock = DockStyle.Top;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(0, 120);
            button2.Name = "button2";
            button2.Size = new Size(113, 40);
            button2.TabIndex = 4;
            button2.Text = "Rondas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.Dock = DockStyle.Top;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(0, 80);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 3;
            button1.Text = "Equipas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnForm1
            // 
            btnForm1.BackColor = SystemColors.Desktop;
            btnForm1.Dock = DockStyle.Top;
            btnForm1.ForeColor = SystemColors.ButtonFace;
            btnForm1.Location = new Point(0, 40);
            btnForm1.Name = "btnForm1";
            btnForm1.Size = new Size(113, 40);
            btnForm1.TabIndex = 0;
            btnForm1.Text = "Jogadores";
            btnForm1.UseVisualStyleBackColor = false;
            btnForm1.Click += btnForm1_Click;
            // 
            // btnForm2
            // 
            btnForm2.BackColor = SystemColors.Desktop;
            btnForm2.Dock = DockStyle.Top;
            btnForm2.ForeColor = SystemColors.ButtonFace;
            btnForm2.Location = new Point(0, 0);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(113, 40);
            btnForm2.TabIndex = 1;
            btnForm2.Text = "Torneios";
            btnForm2.UseVisualStyleBackColor = false;
            btnForm2.Click += btnForm2_Click;
            // 
            // panelMain
            // 
            panelMain.AutoSize = true;
            panelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(113, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1072, 638);
            panelMain.TabIndex = 0;
            panelMain.Paint += panelMain_Paint;
            // 
            // FormGeral
            // 
            ClientSize = new Size(1185, 638);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "FormGeral";
            Load += MainForm_Load;
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button7;
        private Button button5;
        private Button button6;
    }
}