namespace Form1
{
    partial class Equipas
    {
        private System.ComponentModel.IContainer components = null;

        // Add controls
        private ComboBox comboBoxPlayer;
        private ComboBox comboBoxTier;
        private ListBox listBoxPokemons;
        private Button buttonCreateTeam;

        private void InitializeComponent()
        {
            comboBoxPlayer = new ComboBox();
            comboBoxTier = new ComboBox();
            listBoxPokemons = new ListBox();
            buttonCreateTeam = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxPlayer
            // 
            comboBoxPlayer.Location = new Point(50, 138);
            comboBoxPlayer.Name = "comboBoxPlayer";
            comboBoxPlayer.Size = new Size(200, 23);
            comboBoxPlayer.TabIndex = 0;
            comboBoxPlayer.SelectedIndexChanged += comboBoxPlayer_SelectedIndexChanged;
            // 
            // comboBoxTier
            // 
            comboBoxTier.Items.AddRange(new object[] { "Uber", "OU", "UU", "PU", "NU", "RU" });
            comboBoxTier.Location = new Point(50, 209);
            comboBoxTier.Name = "comboBoxTier";
            comboBoxTier.Size = new Size(200, 23);
            comboBoxTier.TabIndex = 1;
            comboBoxTier.SelectedIndexChanged += comboBoxTier_SelectedIndexChanged;
            // 
            // listBoxPokemons
            // 
            listBoxPokemons.ItemHeight = 15;
            listBoxPokemons.Location = new Point(50, 291);
            listBoxPokemons.Name = "listBoxPokemons";
            listBoxPokemons.SelectionMode = SelectionMode.MultiExtended;
            listBoxPokemons.Size = new Size(200, 139);
            listBoxPokemons.TabIndex = 2;
            // 
            // buttonCreateTeam
            // 
            buttonCreateTeam.Location = new Point(50, 461);
            buttonCreateTeam.Name = "buttonCreateTeam";
            buttonCreateTeam.Size = new Size(200, 23);
            buttonCreateTeam.TabIndex = 3;
            buttonCreateTeam.Text = "Create Team";
            buttonCreateTeam.Click += buttonCreateTeam_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(50, 28);
            label4.Name = "label4";
            label4.Size = new Size(173, 37);
            label4.TabIndex = 5;
            label4.Text = "Criar Equipa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(50, 102);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 6;
            label1.Text = "Jogador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(50, 176);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 7;
            label2.Text = "Tier";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(50, 255);
            label3.Name = "label3";
            label3.Size = new Size(159, 21);
            label3.TabIndex = 8;
            label3.Text = "Pokemons Escolhidos";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(281, 291);
            button1.Name = "button1";
            button1.Size = new Size(48, 42);
            button1.TabIndex = 9;
            button1.Text = "+";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Equipas
            // 
            ClientSize = new Size(544, 548);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(comboBoxPlayer);
            Controls.Add(comboBoxTier);
            Controls.Add(listBoxPokemons);
            Controls.Add(buttonCreateTeam);
            Name = "Equipas";
            Text = "Equipas";
            Load += Equipas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
