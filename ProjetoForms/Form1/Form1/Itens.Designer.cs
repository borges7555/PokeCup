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
            listViewItens = new ListView();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(31, 30);
            label4.Name = "label4";
            label4.Size = new Size(80, 37);
            label4.TabIndex = 6;
            label4.Text = "Itens";
            // 
            // listViewItens
            // 
            listViewItens.Location = new Point(31, 82);
            listViewItens.Name = "listViewItens";
            listViewItens.Size = new Size(905, 395);
            listViewItens.TabIndex = 34;
            listViewItens.UseCompatibleStateImageBehavior = false;
            listViewItens.View = View.Details;
            listViewItens.SelectedIndexChanged += listViewItens_SelectedIndexChanged;
            // 
            // Itens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 523);
            ControlBox = false;
            Controls.Add(listViewItens);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Itens";
            Text = "Itens";
            Load += Itens_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ListView listViewItens;
    }
}