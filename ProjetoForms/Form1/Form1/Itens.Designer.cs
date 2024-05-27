namespace Form1
{
    partial class Itens
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
            dataGridViewItens = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).BeginInit();
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
            label4.Size = new Size(98, 46);
            label4.TabIndex = 6;
            label4.Text = "Itens";
            // 
            // dataGridViewItens
            // 
            dataGridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItens.Location = new Point(35, 120);
            dataGridViewItens.Margin = new Padding(3, 4, 3, 4);
            dataGridViewItens.Name = "dataGridViewItens";
            dataGridViewItens.RowHeadersWidth = 51;
            dataGridViewItens.RowTemplate.Height = 24;
            dataGridViewItens.Size = new Size(730, 291);
            dataGridViewItens.TabIndex = 5;
            dataGridViewItens.CellContentClick += dataGridViewItens_CellContentClick;
            // 
            // Itens
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(dataGridViewItens);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Itens";
            Text = "Itens";
            Load += Itens_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView dataGridViewItens;
    }
}