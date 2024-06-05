namespace Form1
{
    partial class ConnectToServer
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(183, 50);
            label4.Name = "label4";
            label4.Size = new Size(301, 46);
            label4.TabIndex = 3;
            label4.Text = "Connect to server";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(204, 308);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(387, 27);
            textBox2.TabIndex = 11;
            textBox2.Text = "b62F@yZ$u@M%DB";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(387, 27);
            textBox1.TabIndex = 10;
            textBox1.Text = "mednat.ieeta.pt\\SQLSERVER,8101";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(295, 408);
            button1.Name = "button1";
            button1.Size = new Size(102, 37);
            button1.TabIndex = 9;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(51, 300);
            label2.Name = "label2";
            label2.Size = new Size(125, 35);
            label2.TabIndex = 8;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(51, 152);
            label1.Name = "label1";
            label1.Size = new Size(89, 35);
            label1.TabIndex = 7;
            label1.Text = "Server:";
            label1.Click += label1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(204, 257);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(387, 27);
            textBox3.TabIndex = 13;
            textBox3.Text = "p9g5";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(51, 249);
            label3.Name = "label3";
            label3.Size = new Size(70, 35);
            label3.TabIndex = 12;
            label3.Text = "User:";
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(204, 207);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(387, 27);
            textBox4.TabIndex = 15;
            textBox4.Text = "p9g5";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(51, 201);
            label5.Name = "label5";
            label5.Size = new Size(121, 35);
            label5.TabIndex = 14;
            label5.Text = "DB name:";
            label5.Click += label5_Click;
            // 
            // ConnectToServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 505);
            ControlBox = false;
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConnectToServer";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox2; // userPass
        private TextBox textBox1; // dbServer
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox3; // userName
        private Label label3;
        private TextBox textBox4;
        private Label label5; // dbName
    }
}