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
            // dataGridViewJogadoresParticiparam
            // 
            dataGridViewJogadoresParticiparam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJogadoresParticiparam.Location = new Point(48, 232);
            dataGridViewJogadoresParticiparam.Name = "dataGridViewJogadoresParticiparam";
            dataGridViewJogadoresParticiparam.Size = new Size(283, 165);
            dataGridViewJogadoresParticiparam.TabIndex = 18;
            dataGridViewJogadoresParticiparam.CellContentClick += dataGridViewJogadoresParticiparam_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(48, 189);
            label1.Name = "label1";
            label1.Size = new Size(233, 25);
            label1.TabIndex = 19;
            label1.Text = "Jogadores que participaram";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(48, 416);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 20;
            label2.Text = "Escolher Batalha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(48, 584);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 22;
            label3.Text = "Resultados";
            // 
            // dataGridViewRondasResultados
            // 
            dataGridViewRondasResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRondasResultados.Location = new Point(48, 626);
            dataGridViewRondasResultados.Name = "dataGridViewRondasResultados";
            dataGridViewRondasResultados.Size = new Size(497, 150);
            dataGridViewRondasResultados.TabIndex = 23;
            dataGridViewRondasResultados.CellContentClick += dataGridViewRondasResultados_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(397, 98);
            label5.Name = "label5";
            label5.Size = new Size(218, 37);
            label5.TabIndex = 24;
            label5.Text = "Vencedor: ______";
            label5.Click += label5_Click;
            // 
            // comboBoxEscolherRondas
            // 
            comboBoxEscolherRondas.FormattingEnabled = true;
            comboBoxEscolherRondas.Location = new Point(48, 540);
            comboBoxEscolherRondas.Name = "comboBoxEscolherRondas";
            comboBoxEscolherRondas.Size = new Size(829, 23);
            comboBoxEscolherRondas.TabIndex = 26;
            comboBoxEscolherRondas.SelectedIndexChanged += comboBoxEscolherRondas_SelectedIndexChanged;
            // 
            // labelEscolherRondas
            // 
            labelEscolherRondas.AutoSize = true;
            labelEscolherRondas.Font = new Font("Segoe UI", 13F);
            labelEscolherRondas.Location = new Point(48, 502);
            labelEscolherRondas.Name = "labelEscolherRondas";
            labelEscolherRondas.Size = new Size(133, 25);
            labelEscolherRondas.TabIndex = 25;
            labelEscolherRondas.Text = "Escolher Ronda";
            // 
            // comboBoxEscolherBatalha
            // 
            comboBoxEscolherBatalha.FormattingEnabled = true;
            comboBoxEscolherBatalha.Location = new Point(48, 455);
            comboBoxEscolherBatalha.Name = "comboBoxEscolherBatalha";
            comboBoxEscolherBatalha.Size = new Size(829, 23);
            comboBoxEscolherBatalha.TabIndex = 27;
            comboBoxEscolherBatalha.SelectedIndexChanged += comboBoxEscolherBatalha_SelectedIndexChanged;
            // 
            // ResultadosTorneios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 788);
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