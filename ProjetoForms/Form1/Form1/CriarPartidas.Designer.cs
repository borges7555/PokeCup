namespace Form1
{
    partial class CriarPartidas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            EscolherTorneio = new Label();
            comboBoxTorneios = new ComboBox();
            labelEscolherJogadores = new Label();
            buttonSimular = new Button();
            listBoxJogadores = new ListBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(38, 39);
            label4.Name = "label4";
            label4.Size = new Size(192, 37);
            label4.TabIndex = 13;
            label4.Text = "Criar Partidas";
            // 
            // EscolherTorneio
            // 
            EscolherTorneio.AutoSize = true;
            EscolherTorneio.Font = new Font("Segoe UI", 13F);
            EscolherTorneio.Location = new Point(38, 107);
            EscolherTorneio.Name = "EscolherTorneio";
            EscolherTorneio.Size = new Size(140, 25);
            EscolherTorneio.TabIndex = 14;
            EscolherTorneio.Text = "Escolher Torneio";
            // 
            // comboBoxTorneios
            // 
            comboBoxTorneios.FormattingEnabled = true;
            comboBoxTorneios.Location = new Point(38, 145);
            comboBoxTorneios.Name = "comboBoxTorneios";
            comboBoxTorneios.Size = new Size(200, 23);
            comboBoxTorneios.TabIndex = 15;
            comboBoxTorneios.SelectedIndexChanged += comboBoxTorneios_SelectedIndexChanged;
            // 
            // labelEscolherJogadores
            // 
            labelEscolherJogadores.AutoSize = true;
            labelEscolherJogadores.Font = new Font("Segoe UI", 13F);
            labelEscolherJogadores.Location = new Point(38, 182);
            labelEscolherJogadores.Name = "labelEscolherJogadores";
            labelEscolherJogadores.Size = new Size(190, 25);
            labelEscolherJogadores.TabIndex = 16;
            labelEscolherJogadores.Text = "Escolher Jogadores (X)";
            // 
            // buttonSimular
            // 
            buttonSimular.Location = new Point(38, 399);
            buttonSimular.Name = "buttonSimular";
            buttonSimular.Size = new Size(200, 50);
            buttonSimular.TabIndex = 18;
            buttonSimular.Text = "Criar Partidas";
            buttonSimular.UseVisualStyleBackColor = true;
            buttonSimular.Click += buttonSimular_Click;
            // 
            // listBoxJogadores
            // 
            listBoxJogadores.ItemHeight = 15;
            listBoxJogadores.Location = new Point(38, 227);
            listBoxJogadores.Name = "listBoxJogadores";
            listBoxJogadores.SelectionMode = SelectionMode.MultiExtended;
            listBoxJogadores.Size = new Size(200, 139);
            listBoxJogadores.TabIndex = 19;
            listBoxJogadores.SelectedIndexChanged += listBoxJogadores_SelectedIndexChanged;
            // 
            // CriarPartidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 556);
            Controls.Add(listBoxJogadores);
            Controls.Add(buttonSimular);
            Controls.Add(labelEscolherJogadores);
            Controls.Add(comboBoxTorneios);
            Controls.Add(EscolherTorneio);
            Controls.Add(label4);
            Name = "CriarPartidas";
            Text = "SimularTorneio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label EscolherTorneio;
        private ComboBox comboBoxTorneios;
        private Label labelEscolherJogadores;
        private Button buttonSimular;
        private ListBox listBoxJogadores;
    }
}