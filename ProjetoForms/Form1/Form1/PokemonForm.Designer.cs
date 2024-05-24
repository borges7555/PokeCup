namespace Form1
{
    partial class PokemonForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxPokemon;
        private System.Windows.Forms.ComboBox comboBoxAtaque1;
        private System.Windows.Forms.ComboBox comboBoxAtaque2;
        private System.Windows.Forms.ComboBox comboBoxAtaque3;
        private System.Windows.Forms.ComboBox comboBoxAtaque4;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelPokemon;
        private System.Windows.Forms.Label labelAtaque1;
        private System.Windows.Forms.Label labelAtaque2;
        private System.Windows.Forms.Label labelAtaque3;
        private System.Windows.Forms.Label labelAtaque4;
        private System.Windows.Forms.Label labelItem;

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
            this.comboBoxPokemon = new System.Windows.Forms.ComboBox();
            this.comboBoxAtaque1 = new System.Windows.Forms.ComboBox();
            this.comboBoxAtaque2 = new System.Windows.Forms.ComboBox();
            this.comboBoxAtaque3 = new System.Windows.Forms.ComboBox();
            this.comboBoxAtaque4 = new System.Windows.Forms.ComboBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelPokemon = new System.Windows.Forms.Label();
            this.labelAtaque1 = new System.Windows.Forms.Label();
            this.labelAtaque2 = new System.Windows.Forms.Label();
            this.labelAtaque3 = new System.Windows.Forms.Label();
            this.labelAtaque4 = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPokemon
            // 
            this.comboBoxPokemon.FormattingEnabled = true;
            this.comboBoxPokemon.Location = new System.Drawing.Point(130, 30);
            this.comboBoxPokemon.Name = "comboBoxPokemon";
            this.comboBoxPokemon.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPokemon.TabIndex = 0;
            // 
            // comboBoxAtaque1
            // 
            this.comboBoxAtaque1.FormattingEnabled = true;
            this.comboBoxAtaque1.Location = new System.Drawing.Point(130, 70);
            this.comboBoxAtaque1.Name = "comboBoxAtaque1";
            this.comboBoxAtaque1.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAtaque1.TabIndex = 1;
            // 
            // comboBoxAtaque2
            // 
            this.comboBoxAtaque2.FormattingEnabled = true;
            this.comboBoxAtaque2.Location = new System.Drawing.Point(130, 110);
            this.comboBoxAtaque2.Name = "comboBoxAtaque2";
            this.comboBoxAtaque2.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAtaque2.TabIndex = 2;
            // 
            // comboBoxAtaque3
            // 
            this.comboBoxAtaque3.FormattingEnabled = true;
            this.comboBoxAtaque3.Location = new System.Drawing.Point(130, 150);
            this.comboBoxAtaque3.Name = "comboBoxAtaque3";
            this.comboBoxAtaque3.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAtaque3.TabIndex = 3;
            // 
            // comboBoxAtaque4
            // 
            this.comboBoxAtaque4.FormattingEnabled = true;
            this.comboBoxAtaque4.Location = new System.Drawing.Point(130, 190);
            this.comboBoxAtaque4.Name = "comboBoxAtaque4";
            this.comboBoxAtaque4.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAtaque4.TabIndex = 4;
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(130, 230);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(200, 21);
            this.comboBoxItem.TabIndex = 5;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(130, 270);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(200, 23);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelPokemon
            // 
            this.labelPokemon.AutoSize = true;
            this.labelPokemon.Location = new System.Drawing.Point(30, 33);
            this.labelPokemon.Name = "labelPokemon";
            this.labelPokemon.Size = new System.Drawing.Size(52, 13);
            this.labelPokemon.TabIndex = 7;
            this.labelPokemon.Text = "Pokémon";
            // 
            // labelAtaque1
            // 
            this.labelAtaque1.AutoSize = true;
            this.labelAtaque1.Location = new System.Drawing.Point(30, 73);
            this.labelAtaque1.Name = "labelAtaque1";
            this.labelAtaque1.Size = new System.Drawing.Size(49, 13);
            this.labelAtaque1.TabIndex = 8;
            this.labelAtaque1.Text = "Ataque 1";
            // 
            // labelAtaque2
            // 
            this.labelAtaque2.AutoSize = true;
            this.labelAtaque2.Location = new System.Drawing.Point(30, 113);
            this.labelAtaque2.Name = "labelAtaque2";
            this.labelAtaque2.Size = new System.Drawing.Size(49, 13);
            this.labelAtaque2.TabIndex = 9;
            this.labelAtaque2.Text = "Ataque 2";
            // 
            // labelAtaque3
            // 
            this.labelAtaque3.AutoSize = true;
            this.labelAtaque3.Location = new System.Drawing.Point(30, 153);
            this.labelAtaque3.Name = "labelAtaque3";
            this.labelAtaque3.Size = new System.Drawing.Size(49, 13);
            this.labelAtaque3.TabIndex = 10;
            this.labelAtaque3.Text = "Ataque 3";
            // 
            // labelAtaque4
            // 
            this.labelAtaque4.AutoSize = true;
            this.labelAtaque4.Location = new System.Drawing.Point(30, 193);
            this.labelAtaque4.Name = "labelAtaque4";
            this.labelAtaque4.Size = new System.Drawing.Size(49, 13);
            this.labelAtaque4.TabIndex = 11;
            this.labelAtaque4.Text = "Ataque 4";
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(30, 233);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(27, 13);
            this.labelItem.TabIndex = 12;
            this.labelItem.Text = "Item";
            // 
            // PokemonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelAtaque4);
            this.Controls.Add(this.labelAtaque3);
            this.Controls.Add(this.labelAtaque2);
            this.Controls.Add(this.labelAtaque1);
            this.Controls.Add(this.labelPokemon);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.comboBoxAtaque4);
            this.Controls.Add(this.comboBoxAtaque3);
            this.Controls.Add(this.comboBoxAtaque2);
            this.Controls.Add(this.comboBoxAtaque1);
            this.Controls.Add(this.comboBoxPokemon);
            this.Name = "PokemonForm";
            this.Text = "Selecione o Pokémon";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
