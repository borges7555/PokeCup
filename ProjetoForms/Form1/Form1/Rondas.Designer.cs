namespace Form1
{
    partial class Rondas
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
            dataGridViewRondas = new DataGridView();
            buttonSimularRondas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRondas).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(56, 49);
            label4.Name = "label4";
            label4.Size = new Size(137, 46);
            label4.TabIndex = 7;
            label4.Text = "Rondas";
            // 
            // dataGridViewRondas
            // 
            dataGridViewRondas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRondas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRondas.Location = new Point(56, 140);
            dataGridViewRondas.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRondas.Name = "dataGridViewRondas";
            dataGridViewRondas.RowHeadersWidth = 51;
            dataGridViewRondas.RowTemplate.Height = 24;
            dataGridViewRondas.Size = new Size(797, 295);
            dataGridViewRondas.TabIndex = 22;
            dataGridViewRondas.CellContentClick += dataGridViewRondas_CellContentClick;
            // 
            // buttonSimularRondas
            // 
            buttonSimularRondas.Location = new Point(673, 49);
            buttonSimularRondas.Margin = new Padding(3, 4, 3, 4);
            buttonSimularRondas.Name = "buttonSimularRondas";
            buttonSimularRondas.Size = new Size(179, 47);
            buttonSimularRondas.TabIndex = 23;
            buttonSimularRondas.Text = "Simular Rondas";
            buttonSimularRondas.UseVisualStyleBackColor = true;
            buttonSimularRondas.Click += buttonCriarRonda_Click;
            // 
            // Rondas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(buttonSimularRondas);
            Controls.Add(dataGridViewRondas);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Rondas";
            Text = "Rondas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRondas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView dataGridViewRondas;
        private Button buttonSimularRondas;
    }
}