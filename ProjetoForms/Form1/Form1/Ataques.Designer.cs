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
            listViewAtaques = new ListView();
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
            label4.Size = new Size(121, 37);
            label4.TabIndex = 8;
            label4.Text = "Ataques";
            // 
            // listViewAtaques
            // 
            listViewAtaques.Location = new Point(31, 90);
            listViewAtaques.Name = "listViewAtaques";
            listViewAtaques.Size = new Size(875, 347);
            listViewAtaques.TabIndex = 35;
            listViewAtaques.UseCompatibleStateImageBehavior = false;
            listViewAtaques.View = View.Details;
            listViewAtaques.SelectedIndexChanged += listViewAtaques_SelectedIndexChanged;
            // 
            // Ataques
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 489);
            ControlBox = false;
            Controls.Add(listViewAtaques);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ataques";
            Text = "Ataques";
            Load += Ataques_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private ListView listViewAtaques;
    }
}