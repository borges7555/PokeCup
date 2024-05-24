namespace Form1
{
    partial class AddTorneioPopUp
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
            NomeTorneio = new Label();
            textBoxNomeTorneio = new TextBox();
            labelTier = new Label();
            labelData = new Label();
            labelLocalizacao = new Label();
            labelNMaxJogadores = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            texBoxLocalizacao = new TextBox();
            textBoxNMaxJogadores = new TextBox();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // NomeTorneio
            // 
            NomeTorneio.AutoSize = true;
            NomeTorneio.Location = new Point(32, 37);
            NomeTorneio.Name = "NomeTorneio";
            NomeTorneio.Size = new Size(40, 15);
            NomeTorneio.TabIndex = 0;
            NomeTorneio.Text = "Nome";
            NomeTorneio.Click += NomeTorneio_Click;
            // 
            // textBoxNomeTorneio
            // 
            textBoxNomeTorneio.Location = new Point(32, 55);
            textBoxNomeTorneio.Name = "textBoxNomeTorneio";
            textBoxNomeTorneio.Size = new Size(200, 23);
            textBoxNomeTorneio.TabIndex = 1;
            textBoxNomeTorneio.TextChanged += textBoxNomeTorneio_TextChanged;
            // 
            // labelTier
            // 
            labelTier.AutoSize = true;
            labelTier.Location = new Point(32, 96);
            labelTier.Name = "labelTier";
            labelTier.Size = new Size(26, 15);
            labelTier.TabIndex = 2;
            labelTier.Text = "Tier";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(32, 160);
            labelData.Name = "labelData";
            labelData.Size = new Size(31, 15);
            labelData.TabIndex = 3;
            labelData.Text = "Data";
            // 
            // labelLocalizacao
            // 
            labelLocalizacao.AutoSize = true;
            labelLocalizacao.Location = new Point(32, 223);
            labelLocalizacao.Name = "labelLocalizacao";
            labelLocalizacao.Size = new Size(68, 15);
            labelLocalizacao.TabIndex = 4;
            labelLocalizacao.Text = "Localizacao";
            // 
            // labelNMaxJogadores
            // 
            labelNMaxJogadores.AutoSize = true;
            labelNMaxJogadores.Location = new Point(32, 280);
            labelNMaxJogadores.Name = "labelNMaxJogadores";
            labelNMaxJogadores.Size = new Size(92, 15);
            labelNMaxJogadores.TabIndex = 5;
            labelNMaxJogadores.Text = "NMaxJogadores";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(32, 183);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // texBoxLocalizacao
            // 
            texBoxLocalizacao.Location = new Point(32, 245);
            texBoxLocalizacao.Name = "texBoxLocalizacao";
            texBoxLocalizacao.Size = new Size(200, 23);
            texBoxLocalizacao.TabIndex = 8;
            // 
            // textBoxNMaxJogadores
            // 
            textBoxNMaxJogadores.Location = new Point(32, 300);
            textBoxNMaxJogadores.Name = "textBoxNMaxJogadores";
            textBoxNMaxJogadores.Size = new Size(200, 23);
            textBoxNMaxJogadores.TabIndex = 9;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(32, 354);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(200, 23);
            buttonOK.TabIndex = 10;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 444);
            Controls.Add(buttonOK);
            Controls.Add(textBoxNMaxJogadores);
            Controls.Add(texBoxLocalizacao);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(labelNMaxJogadores);
            Controls.Add(labelLocalizacao);
            Controls.Add(labelData);
            Controls.Add(labelTier);
            Controls.Add(textBoxNomeTorneio);
            Controls.Add(NomeTorneio);
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeTorneio;
        private TextBox textBoxNomeTorneio;
        private Label labelTier;
        private Label labelData;
        private Label labelLocalizacao;
        private Label labelNMaxJogadores;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox texBoxLocalizacao;
        private TextBox textBoxNMaxJogadores;
        private Button buttonOK;
    }
}