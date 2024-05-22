namespace Form1
{
    partial class AddJogadorForm
    {
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtWL;
        private System.Windows.Forms.Button btnOk;

        private void InitializeComponent()
        {
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtWL = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(12, 12);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(100, 20);
            this.txtNickname.TabIndex = 0;

            // 
            // txtWL
            // 
            this.txtWL.Location = new System.Drawing.Point(12, 38);
            this.txtWL.Name = "txtWL";
            this.txtWL.Size = new System.Drawing.Size(100, 20);
            this.txtWL.TabIndex = 1;

            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 64);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);

            // 
            // AddJogadorForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtWL);
            this.Controls.Add(this.txtNickname);
            this.Name = "AddJogadorForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
