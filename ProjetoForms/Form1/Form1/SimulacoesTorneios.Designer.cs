namespace Form1
{
    partial class SimulacoesTorneios
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
            dataGridViewBatalhas = new DataGridView();
            label3 = new Label();
            dataGridViewRondasResultados = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJogadoresParticiparam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBatalhas).BeginInit();
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
            label4.Size = new Size(308, 37);
            label4.TabIndex = 14;
            label4.Text = "Resultados Simulações";
            // 
            // comboBoxTorneios
            // 
            comboBoxTorneios.FormattingEnabled = true;
            comboBoxTorneios.Location = new Point(48, 136);
            comboBoxTorneios.Name = "comboBoxTorneios";
            comboBoxTorneios.Size = new Size(200, 23);
            comboBoxTorneios.TabIndex = 17;
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
            dataGridViewJogadoresParticiparam.Size = new Size(283, 150);
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
            label2.Location = new Point(380, 189);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 20;
            label2.Text = "Batalhas";
            // 
            // dataGridViewBatalhas
            // 
            dataGridViewBatalhas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBatalhas.Location = new Point(380, 232);
            dataGridViewBatalhas.Name = "dataGridViewBatalhas";
            dataGridViewBatalhas.Size = new Size(497, 150);
            dataGridViewBatalhas.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(48, 406);
            label3.Name = "label3";
            label3.Size = new Size(176, 25);
            label3.TabIndex = 22;
            label3.Text = "Rondas e Resultados";
            // 
            // dataGridViewRondasResultados
            // 
            dataGridViewRondasResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRondasResultados.Location = new Point(48, 445);
            dataGridViewRondasResultados.Name = "dataGridViewRondasResultados";
            dataGridViewRondasResultados.Size = new Size(829, 150);
            dataGridViewRondasResultados.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(380, 107);
            label5.Name = "label5";
            label5.Size = new Size(241, 37);
            label5.TabIndex = 24;
            label5.Text = "Vencedor: Borges";
            // 
            // SimulacoesTorneios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 634);
            Controls.Add(label5);
            Controls.Add(dataGridViewRondasResultados);
            Controls.Add(label3);
            Controls.Add(dataGridViewBatalhas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewJogadoresParticiparam);
            Controls.Add(comboBoxTorneios);
            Controls.Add(EscolherTorneio);
            Controls.Add(label4);
            Name = "SimulacoesTorneios";
            Text = "SimulacoesTorneios";
            ((System.ComponentModel.ISupportInitialize)dataGridViewJogadoresParticiparam).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBatalhas).EndInit();
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
        private DataGridView dataGridViewBatalhas;
        private Label label3;
        private DataGridView dataGridViewRondasResultados;
        private Label label5;
    }
}