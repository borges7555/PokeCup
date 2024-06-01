namespace Form1
{
    partial class AddRondaPopUp
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
            buttonSimular = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(36, 39);
            label4.Name = "label4";
            label4.Size = new Size(216, 37);
            label4.TabIndex = 16;
            label4.Text = "Simular Rondas";
            // 
            // comboBoxTorneios
            // 
            comboBoxTorneios.FormattingEnabled = true;
            comboBoxTorneios.Location = new Point(36, 141);
            comboBoxTorneios.Name = "comboBoxTorneios";
            comboBoxTorneios.Size = new Size(200, 23);
            comboBoxTorneios.TabIndex = 18;
            comboBoxTorneios.SelectedIndexChanged += comboBoxTorneios_SelectedIndexChanged;
            // 
            // EscolherTorneio
            // 
            EscolherTorneio.AutoSize = true;
            EscolherTorneio.Font = new Font("Segoe UI", 13F);
            EscolherTorneio.Location = new Point(36, 103);
            EscolherTorneio.Name = "EscolherTorneio";
            EscolherTorneio.Size = new Size(140, 25);
            EscolherTorneio.TabIndex = 17;
            EscolherTorneio.Text = "Escolher Torneio";
            // 
            // buttonSimular
            // 
            buttonSimular.Location = new Point(36, 211);
            buttonSimular.Name = "buttonSimular";
            buttonSimular.Size = new Size(200, 50);
            buttonSimular.TabIndex = 19;
            buttonSimular.Text = "Simular";
            buttonSimular.UseVisualStyleBackColor = true;
            buttonSimular.Click += buttonSimular_Click;
            // 
            // AddRondaPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 323);
            Controls.Add(buttonSimular);
            Controls.Add(comboBoxTorneios);
            Controls.Add(EscolherTorneio);
            Controls.Add(label4);
            Name = "AddRondaPopUp";
            Text = "AddRondaPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private ComboBox comboBoxTorneios;
        private Label EscolherTorneio;
        private Button buttonSimular;
    }
}