namespace Form1
{
    partial class AddJogadorPopUp
    {
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtWL;
        private System.Windows.Forms.Button btnOk;

        private void InitializeComponent()
        {
            txtNickname = new TextBox();
            txtWL = new TextBox();
            btnOk = new Button();
            labelPokemon = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNickname
            // 
            txtNickname.Location = new Point(12, 57);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(100, 23);
            txtNickname.TabIndex = 0;
            // 
            // txtWL
            // 
            txtWL.Location = new Point(12, 123);
            txtWL.Name = "txtWL";
            txtWL.Size = new Size(100, 23);
            txtWL.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(12, 202);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // labelPokemon
            // 
            labelPokemon.AutoSize = true;
            labelPokemon.Location = new Point(12, 28);
            labelPokemon.Margin = new Padding(4, 0, 4, 0);
            labelPokemon.Name = "labelPokemon";
            labelPokemon.Size = new Size(61, 15);
            labelPokemon.TabIndex = 8;
            labelPokemon.Text = "Nickname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 9;
            label1.Text = "W_L";
            // 
            // AddJogadorForm
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(label1);
            Controls.Add(labelPokemon);
            Controls.Add(btnOk);
            Controls.Add(txtWL);
            Controls.Add(txtNickname);
            Name = "AddJogadorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelPokemon;
        private Label label1;
    }
}
