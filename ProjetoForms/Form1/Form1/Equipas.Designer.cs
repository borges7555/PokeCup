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
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            listBoxPokemons.Size = new Size(200, 124);
            listBoxPokemons.TabIndex = 2;
            listBoxPokemons.SelectedIndexChanged += listBoxPokemons_SelectedIndexChanged;
            // 
            // buttonCreateTeam
            // 
            buttonCreateTeam.Location = new Point(50, 445);
            buttonCreateTeam.Name = "buttonCreateTeam";
            buttonCreateTeam.Size = new Size(200, 39);
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
            button1.Size = new Size(48, 41);
            button1.TabIndex = 9;
            button1.Text = "+";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(379, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(475, 221);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(379, 102);
            label5.Name = "label5";
            label5.Size = new Size(183, 37);
            label5.TabIndex = 21;
            label5.Text = "Lista Equipas";
            // 
            // Equipas
            // 
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(903, 548);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(comboBoxPlayer);
            Controls.Add(comboBoxTier);
            Controls.Add(listBoxPokemons);
            Controls.Add(buttonCreateTeam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Equipas";
            Text = "Equipas";
            Load += Equipas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label5;
    }
}
