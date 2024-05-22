namespace Form1
{
    partial class Pokemons
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(639, 218);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(28, 24);
            label4.Name = "label4";
            label4.Size = new Size(150, 37);
            label4.TabIndex = 4;
            label4.Text = "Pokemons";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(510, 29);
            button1.Name = "button1";
            button1.Size = new Size(157, 35);
            button1.TabIndex = 6;
            button1.Text = "Adicionar Pokemons";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Pokemons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 333);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Name = "Pokemons";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label4;
        private Button button1;
    }
}
