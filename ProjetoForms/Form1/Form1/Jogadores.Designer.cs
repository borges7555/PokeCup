namespace Form1
{
    partial class Jogadores
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(46, 32);
            label4.Name = "label4";
            label4.Size = new Size(150, 37);
            label4.TabIndex = 4;
            label4.Text = "Jogadores";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(496, 38);
            button1.Name = "button1";
            button1.Size = new Size(157, 35);
            button1.TabIndex = 5;
            button1.Text = "Adicionar Jogador";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(607, 218);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Jogadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Jogadores";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button1;
        private DataGridView dataGridView1;
    }
}