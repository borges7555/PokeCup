namespace Form1
{
    partial class ResultadosTorneios
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
            comboBoxTorneios = new ComboBox();
            EscolherTorneio = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            labelEscolherRondas = new Label();
            comboBoxEscolherBatalha = new ComboBox();
            listBoxRondas = new ListBox();
            listBoxJogadores = new ListBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(48, 33);
            label4.Name = "label4";
            label4.Size = new Size(274, 37);
            label4.TabIndex = 14;
            label4.Text = "Resultados Torneios";
            // 
            // comboBoxTorneios
            // 
            comboBoxTorneios.FormattingEnabled = true;
            comboBoxTorneios.Location = new Point(48, 136);
            comboBoxTorneios.Name = "comboBoxTorneios";
            comboBoxTorneios.Size = new Size(200, 23);
            comboBoxTorneios.TabIndex = 17;
            comboBoxTorneios.SelectedIndexChanged += comboBoxTorneios_SelectedIndexChanged;
            // 
            // EscolherTorneio
            // 
            EscolherTorneio.AutoSize = true;
            EscolherTorneio.Font = new Font("Segoe UI", 13F);
            EscolherTorneio.Location = new Point(48, 98);
            EscolherTorneio.Name = "EscolherTorneio";
            EscolherTorneio.Size = new Size(140, 25);
            EscolherTorneio.TabIndex = 16;
            EscolherTorneio.Text = "Escolher Torneio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(48, 189);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 19;
            label1.Text = "Participantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(308, 189);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 20;
            label2.Text = "Escolher Partida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(308, 122);
            label5.Name = "label5";
            label5.Size = new Size(218, 37);
            label5.TabIndex = 24;
            label5.Text = "Vencedor: ______";
            label5.Click += label5_Click;
            // 
            // labelEscolherRondas
            // 
            labelEscolherRondas.AutoSize = true;
            labelEscolherRondas.Font = new Font("Segoe UI", 13F);
            labelEscolherRondas.Location = new Point(312, 278);
            labelEscolherRondas.Name = "labelEscolherRondas";
            labelEscolherRondas.Size = new Size(133, 25);
            labelEscolherRondas.TabIndex = 25;
            labelEscolherRondas.Text = "Escolher Ronda";
            // 
            // comboBoxEscolherBatalha
            // 
            comboBoxEscolherBatalha.FormattingEnabled = true;
            comboBoxEscolherBatalha.Location = new Point(308, 228);
            comboBoxEscolherBatalha.Name = "comboBoxEscolherBatalha";
            comboBoxEscolherBatalha.Size = new Size(634, 23);
            comboBoxEscolherBatalha.TabIndex = 27;
            comboBoxEscolherBatalha.SelectedIndexChanged += comboBoxEscolherBatalha_SelectedIndexChanged;
            // 
            // listBoxRondas
            // 
            listBoxRondas.ItemHeight = 15;
            listBoxRondas.Location = new Point(308, 317);
            listBoxRondas.Name = "listBoxRondas";
            listBoxRondas.SelectionMode = SelectionMode.MultiExtended;
            listBoxRondas.Size = new Size(634, 124);
            listBoxRondas.TabIndex = 28;
            listBoxRondas.SelectedIndexChanged += listBoxRondas_SelectedIndexChanged;
            // 
            // listBoxJogadores
            // 
            listBoxJogadores.ItemHeight = 15;
            listBoxJogadores.Location = new Point(48, 232);
            listBoxJogadores.Name = "listBoxJogadores";
            listBoxJogadores.SelectionMode = SelectionMode.MultiExtended;
            listBoxJogadores.Size = new Size(200, 139);
            listBoxJogadores.TabIndex = 29;
            listBoxJogadores.SelectedIndexChanged += listBoxJogadores_SelectedIndexChanged;
            // 
            // ResultadosTorneios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 668);
            ControlBox = false;
            Controls.Add(listBoxJogadores);
            Controls.Add(listBoxRondas);
            Controls.Add(comboBoxEscolherBatalha);
            Controls.Add(labelEscolherRondas);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxTorneios);
            Controls.Add(EscolherTorneio);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultadosTorneios";
            Text = "SimulacoesTorneios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ComboBox comboBoxTorneios;
        private Label EscolherTorneio;
        private DataGridView dataGridViewJogadoresParticiparam;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label labelEscolherRondas;
        private ComboBox comboBoxEscolherBatalha;
        private ListBox listBoxRondas;
        private ListBox listBoxJogadores;
    }
}