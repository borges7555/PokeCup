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
            button5.Location = new Point(395, 43);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(179, 47);
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
            label4.Location = new Point(40, 33);
            label4.Name = "label4";
            label4.Size = new Size(157, 46);
            label4.TabIndex = 12;
            label4.Text = "Torneios";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 121);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(730, 291);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonSimularTorneio
            // 
            buttonSimularTorneio.Location = new Point(594, 43);
            buttonSimularTorneio.Margin = new Padding(3, 4, 3, 4);
            buttonSimularTorneio.Name = "buttonSimularTorneio";
            buttonSimularTorneio.Size = new Size(179, 47);
            buttonSimularTorneio.TabIndex = 19;
            buttonSimularTorneio.Text = "Criar Partidas";
            buttonSimularTorneio.UseVisualStyleBackColor = true;
            buttonSimularTorneio.Click += buttonSimularTorneio_Click;
            // 
            // Torneios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 451);
            ControlBox = false;
            Controls.Add(buttonSimularTorneio);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
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