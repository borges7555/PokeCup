namespace Form1
{
    partial class Partidas
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
            dataGridViewPartidas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartidas).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(50, 55);
            label4.Name = "label4";
            label4.Size = new Size(150, 46);
            label4.TabIndex = 6;
            label4.Text = "Partidas";
            // 
            // dataGridViewPartidas
            // 
            dataGridViewPartidas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartidas.Location = new Point(50, 144);
            dataGridViewPartidas.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPartidas.Name = "dataGridViewPartidas";
            dataGridViewPartidas.RowHeadersWidth = 51;
            dataGridViewPartidas.RowTemplate.Height = 24;
            dataGridViewPartidas.Size = new Size(797, 295);
            dataGridViewPartidas.TabIndex = 21;
            dataGridViewPartidas.CellContentClick += dataGridViewPartidas_CellContentClick;
            // 
            // Partidas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            ControlBox = false;
            Controls.Add(dataGridViewPartidas);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Partidas";
            Text = "Partidas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView dataGridViewPartidas;
    }
}