namespace Form1
{
    partial class Torneios
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
            button5 = new Button();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            buttonSimularTorneio = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(346, 32);
            button5.Name = "button5";
            button5.Size = new Size(157, 35);
            button5.TabIndex = 17;
            button5.Text = "Criar Torneio";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(35, 25);
            label4.Name = "label4";
            label4.Size = new Size(127, 37);
            label4.TabIndex = 12;
            label4.Text = "Torneios";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(639, 218);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonSimularTorneio
            // 
            buttonSimularTorneio.Location = new Point(520, 32);
            buttonSimularTorneio.Name = "buttonSimularTorneio";
            buttonSimularTorneio.Size = new Size(157, 35);
            buttonSimularTorneio.TabIndex = 19;
            buttonSimularTorneio.Text = "Simular Torneio";
            buttonSimularTorneio.UseVisualStyleBackColor = true;
            buttonSimularTorneio.Click += buttonSimularTorneio_Click;
            // 
            // Torneios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonSimularTorneio);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(label4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Torneios";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Label label4;
        private DataGridView dataGridView1;
        private Button buttonSimularTorneio;
    }
}