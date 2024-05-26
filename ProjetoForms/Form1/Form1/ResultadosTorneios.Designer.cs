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
            dataGridViewJogadoresParticiparam = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridViewRondasResultados = new DataGridView();
            label5 = new Label();
            comboBoxEscolherRondas = new ComboBox();
            labelEscolherRondas = new Label();
            comboBoxEscolherBatalha = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJogadoresParticiparam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRondasResultados).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(55, 44);
            label4.Name = "label4";
            label4.Size = new Size(339, 46);
            label4.TabIndex = 14;
            label4.Text = "Resultados Torneios";
            // 
            // comboBoxTorneios
            // 
            comboBoxTorneios.FormattingEnabled = true;
            comboBoxTorneios.Location = new Point(55, 181);
            comboBoxTorneios.Margin = new Padding(3, 4, 3, 4);
            comboBoxTorneios.Name = "comboBoxTorneios";
            comboBoxTorneios.Size = new Size(228, 28);
            comboBoxTorneios.TabIndex = 17;
            comboBoxTorneios.SelectedIndexChanged += comboBoxTorneios_SelectedIndexChanged;
            // 
            // EscolherTorneio
            // 
            EscolherTorneio.AutoSize = true;
            EscolherTorneio.Font = new Font("Segoe UI", 13F);
            EscolherTorneio.Location = new Point(55, 131);
            EscolherTorneio.Name = "EscolherTorneio";
            EscolherTorneio.Size = new Size(172, 30);
            EscolherTorneio.TabIndex = 16;
            EscolherTorneio.Text = "Escolher Torneio";
            // 
            // dataGridViewJogadoresParticiparam
            // 
            dataGridViewJogadoresParticiparam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJogadoresParticiparam.Location = new Point(55, 309);
            dataGridViewJogadoresParticiparam.Margin = new Padding(3, 4, 3, 4);
            dataGridViewJogadoresParticiparam.Name = "dataGridViewJogadoresParticiparam";
            dataGridViewJogadoresParticiparam.RowHeadersWidth = 51;
            dataGridViewJogadoresParticiparam.Size = new Size(947, 220);
            dataGridViewJogadoresParticiparam.TabIndex = 18;
            dataGridViewJogadoresParticiparam.CellContentClick += dataGridViewJogadoresParticiparam_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(55, 252);
            label1.Name = "label1";
            label1.Size = new Size(283, 30);
            label1.TabIndex = 19;
            label1.Text = "Jogadores que participaram";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(55, 555);
            label2.Name = "label2";
            label2.Size = new Size(165, 30);
            label2.TabIndex = 20;
            label2.Text = "Escolher Partida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(55, 779);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 22;
            label3.Text = "Resultados";
            // 
            // dataGridViewRondasResultados
            // 
            dataGridViewRondasResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRondasResultados.Location = new Point(55, 835);
            dataGridViewRondasResultados.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRondasResultados.Name = "dataGridViewRondasResultados";
            dataGridViewRondasResultados.RowHeadersWidth = 51;
            dataGridViewRondasResultados.Size = new Size(947, 200);
            dataGridViewRondasResultados.TabIndex = 23;
            dataGridViewRondasResultados.CellContentClick += dataGridViewRondasResultados_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(454, 131);
            label5.Name = "label5";
            label5.Size = new Size(273, 46);
            label5.TabIndex = 24;
            label5.Text = "Vencedor: ______";
            label5.Click += label5_Click;
            // 
            // comboBoxEscolherRondas
            // 
            comboBoxEscolherRondas.FormattingEnabled = true;
            comboBoxEscolherRondas.Location = new Point(55, 720);
            comboBoxEscolherRondas.Margin = new Padding(3, 4, 3, 4);
            comboBoxEscolherRondas.Name = "comboBoxEscolherRondas";
            comboBoxEscolherRondas.Size = new Size(947, 28);
            comboBoxEscolherRondas.TabIndex = 26;
            comboBoxEscolherRondas.SelectedIndexChanged += comboBoxEscolherRondas_SelectedIndexChanged;
            // 
            // labelEscolherRondas
            // 
            labelEscolherRondas.AutoSize = true;
            labelEscolherRondas.Font = new Font("Segoe UI", 13F);
            labelEscolherRondas.Location = new Point(55, 669);
            labelEscolherRondas.Name = "labelEscolherRondas";
            labelEscolherRondas.Size = new Size(160, 30);
            labelEscolherRondas.TabIndex = 25;
            labelEscolherRondas.Text = "Escolher Ronda";
            // 
            // comboBoxEscolherBatalha
            // 
            comboBoxEscolherBatalha.FormattingEnabled = true;
            comboBoxEscolherBatalha.Location = new Point(55, 607);
            comboBoxEscolherBatalha.Margin = new Padding(3, 4, 3, 4);
            comboBoxEscolherBatalha.Name = "comboBoxEscolherBatalha";
            comboBoxEscolherBatalha.Size = new Size(947, 28);
            comboBoxEscolherBatalha.TabIndex = 27;
            comboBoxEscolherBatalha.SelectedIndexChanged += comboBoxEscolherBatalha_SelectedIndexChanged;
            // 
            // ResultadosTorneios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 1051);
            ControlBox = false;
            Controls.Add(comboBoxEscolherBatalha);
            Controls.Add(comboBoxEscolherRondas);
            Controls.Add(labelEscolherRondas);
            Controls.Add(label5);
            Controls.Add(dataGridViewRondasResultados);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewJogadoresParticiparam);
            Controls.Add(comboBoxTorneios);
            Controls.Add(EscolherTorneio);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ResultadosTorneios";
            Text = "SimulacoesTorneios";
            ((System.ComponentModel.ISupportInitialize)dataGridViewJogadoresParticiparam).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRondasResultados).EndInit();
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
        private Label label3;
        private DataGridView dataGridViewRondasResultados;
        private Label label5;
        private ComboBox comboBoxEscolherRondas;
        private Label labelEscolherRondas;
        private ComboBox comboBoxEscolherBatalha;
    }
}