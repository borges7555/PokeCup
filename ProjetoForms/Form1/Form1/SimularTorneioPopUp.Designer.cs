namespace Form1
{
    partial class SimularTorneioPopUp
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
            label1 = new Label();
            comboBoxJogadores = new ComboBox();
            buttonSimular = new Button();
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
            label4.Size = new Size(220, 37);
            label4.TabIndex = 13;
            label4.Text = "Simular Torneio";
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(38, 182);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 16;
            label1.Text = "Escolher Jogadores (X)";
            // 
            // comboBoxJogadores
            // 
            comboBoxJogadores.FormattingEnabled = true;
            comboBoxJogadores.Location = new Point(38, 224);
            comboBoxJogadores.Name = "comboBoxJogadores";
            comboBoxJogadores.Size = new Size(200, 23);
            comboBoxJogadores.TabIndex = 17;
            // 
            // buttonSimular
            // 
            buttonSimular.Location = new Point(38, 291);
            buttonSimular.Name = "buttonSimular";
            buttonSimular.Size = new Size(200, 50);
            buttonSimular.TabIndex = 18;
            buttonSimular.Text = "Simular";
            buttonSimular.UseVisualStyleBackColor = true;
            buttonSimular.Click += buttonSimular_Click;
            // 
            // SimularTorneioPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 450);
            Controls.Add(buttonSimular);
            Controls.Add(comboBoxJogadores);
            Controls.Add(label1);
            Controls.Add(comboBoxTorneios);
            Controls.Add(EscolherTorneio);
            Controls.Add(label4);
            Name = "SimularTorneioPopUp";
            Text = "SimularTorneio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label EscolherTorneio;
        private ComboBox comboBoxTorneios;
        private Label label1;
        private ComboBox comboBoxJogadores;
        private Button buttonSimular;
    }
}