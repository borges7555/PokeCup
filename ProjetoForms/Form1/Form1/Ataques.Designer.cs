namespace Form1
{
    partial class Ataques
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
            dataGridViewAtaques = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtaques).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(35, 40);
            label4.Name = "label4";
            label4.Size = new Size(149, 46);
            label4.TabIndex = 8;
            label4.Text = "Ataques";
            // 
            // dataGridViewAtaques
            // 
            dataGridViewAtaques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtaques.Location = new Point(35, 120);
            dataGridViewAtaques.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAtaques.Name = "dataGridViewAtaques";
            dataGridViewAtaques.RowHeadersWidth = 51;
            dataGridViewAtaques.RowTemplate.Height = 24;
            dataGridViewAtaques.Size = new Size(730, 291);
            dataGridViewAtaques.TabIndex = 7;
            dataGridViewAtaques.CellContentClick += dataGridViewAtaques_CellContentClick;
            // 
            // Ataques
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(dataGridViewAtaques);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ataques";
            Text = "Ataques";
            Load += Ataques_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtaques).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView dataGridViewAtaques;
    }
}