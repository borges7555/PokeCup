namespace Form1
{
    partial class Equipas
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
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
            label4.Location = new Point(37, 28);
            label4.Name = "label4";
            label4.Size = new Size(173, 37);
            label4.TabIndex = 5;
            label4.Text = "Criar Equipa";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(40, 267);
            button1.Name = "button1";
            button1.Size = new Size(157, 35);
            button1.TabIndex = 7;
            button1.Text = "Selecionar Jogador";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(40, 317);
            button2.Name = "button2";
            button2.Size = new Size(230, 35);
            button2.TabIndex = 8;
            button2.Text = "Selecionar Pokemons Escolhidos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(40, 369);
            button3.Name = "button3";
            button3.Size = new Size(157, 35);
            button3.TabIndex = 9;
            button3.Text = "OK";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(291, 317);
            button4.Name = "button4";
            button4.Size = new Size(189, 35);
            button4.TabIndex = 10;
            button4.Text = "Novo Pokemon Escolhido";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(230, 267);
            button5.Name = "button5";
            button5.Size = new Size(157, 35);
            button5.TabIndex = 11;
            button5.Text = "Selecionar Tier";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(607, 165);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Equipas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 541);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Equipas";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
    }
}