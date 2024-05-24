namespace Form1
{
    partial class AddPokemonEscolhidoPopUp
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
            comboBoxPokemon = new ComboBox();
            comboBoxAtaque1 = new ComboBox();
            comboBoxAtaque2 = new ComboBox();
            comboBoxAtaque3 = new ComboBox();
            comboBoxAtaque4 = new ComboBox();
            comboBoxItem = new ComboBox();
            buttonConfirm = new Button();
            labelPokemon = new Label();
            labelAtaque1 = new Label();
            labelAtaque2 = new Label();
            labelAtaque3 = new Label();
            labelAtaque4 = new Label();
            labelItem = new Label();
            SuspendLayout();
            // 
            // comboBoxPokemon
            // 
            comboBoxPokemon.FormattingEnabled = true;
            comboBoxPokemon.Location = new Point(152, 35);
            comboBoxPokemon.Margin = new Padding(4, 3, 4, 3);
            comboBoxPokemon.Name = "comboBoxPokemon";
            comboBoxPokemon.Size = new Size(233, 23);
            comboBoxPokemon.TabIndex = 0;
            comboBoxPokemon.SelectedIndexChanged += comboBoxPokemon_SelectedIndexChanged;
            // 
            // comboBoxAtaque1
            // 
            comboBoxAtaque1.FormattingEnabled = true;
            comboBoxAtaque1.Location = new Point(152, 81);
            comboBoxAtaque1.Margin = new Padding(4, 3, 4, 3);
            comboBoxAtaque1.Name = "comboBoxAtaque1";
            comboBoxAtaque1.Size = new Size(233, 23);
            comboBoxAtaque1.TabIndex = 1;
            // 
            // comboBoxAtaque2
            // 
            comboBoxAtaque2.FormattingEnabled = true;
            comboBoxAtaque2.Location = new Point(152, 127);
            comboBoxAtaque2.Margin = new Padding(4, 3, 4, 3);
            comboBoxAtaque2.Name = "comboBoxAtaque2";
            comboBoxAtaque2.Size = new Size(233, 23);
            comboBoxAtaque2.TabIndex = 2;
            // 
            // comboBoxAtaque3
            // 
            comboBoxAtaque3.FormattingEnabled = true;
            comboBoxAtaque3.Location = new Point(152, 173);
            comboBoxAtaque3.Margin = new Padding(4, 3, 4, 3);
            comboBoxAtaque3.Name = "comboBoxAtaque3";
            comboBoxAtaque3.Size = new Size(233, 23);
            comboBoxAtaque3.TabIndex = 3;
            // 
            // comboBoxAtaque4
            // 
            comboBoxAtaque4.FormattingEnabled = true;
            comboBoxAtaque4.Location = new Point(152, 219);
            comboBoxAtaque4.Margin = new Padding(4, 3, 4, 3);
            comboBoxAtaque4.Name = "comboBoxAtaque4";
            comboBoxAtaque4.Size = new Size(233, 23);
            comboBoxAtaque4.TabIndex = 4;
            // 
            // comboBoxItem
            // 
            comboBoxItem.FormattingEnabled = true;
            comboBoxItem.Location = new Point(152, 265);
            comboBoxItem.Margin = new Padding(4, 3, 4, 3);
            comboBoxItem.Name = "comboBoxItem";
            comboBoxItem.Size = new Size(233, 23);
            comboBoxItem.TabIndex = 5;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(152, 312);
            buttonConfirm.Margin = new Padding(4, 3, 4, 3);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(233, 27);
            buttonConfirm.TabIndex = 6;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // labelPokemon
            // 
            labelPokemon.AutoSize = true;
            labelPokemon.Location = new Point(35, 38);
            labelPokemon.Margin = new Padding(4, 0, 4, 0);
            labelPokemon.Name = "labelPokemon";
            labelPokemon.Size = new Size(58, 15);
            labelPokemon.TabIndex = 7;
            labelPokemon.Text = "Pokémon";
            // 
            // labelAtaque1
            // 
            labelAtaque1.AutoSize = true;
            labelAtaque1.Location = new Point(35, 84);
            labelAtaque1.Margin = new Padding(4, 0, 4, 0);
            labelAtaque1.Name = "labelAtaque1";
            labelAtaque1.Size = new Size(54, 15);
            labelAtaque1.TabIndex = 8;
            labelAtaque1.Text = "Ataque 1";
            // 
            // labelAtaque2
            // 
            labelAtaque2.AutoSize = true;
            labelAtaque2.Location = new Point(35, 130);
            labelAtaque2.Margin = new Padding(4, 0, 4, 0);
            labelAtaque2.Name = "labelAtaque2";
            labelAtaque2.Size = new Size(54, 15);
            labelAtaque2.TabIndex = 9;
            labelAtaque2.Text = "Ataque 2";
            // 
            // labelAtaque3
            // 
            labelAtaque3.AutoSize = true;
            labelAtaque3.Location = new Point(35, 177);
            labelAtaque3.Margin = new Padding(4, 0, 4, 0);
            labelAtaque3.Name = "labelAtaque3";
            labelAtaque3.Size = new Size(54, 15);
            labelAtaque3.TabIndex = 10;
            labelAtaque3.Text = "Ataque 3";
            // 
            // labelAtaque4
            // 
            labelAtaque4.AutoSize = true;
            labelAtaque4.Location = new Point(35, 223);
            labelAtaque4.Margin = new Padding(4, 0, 4, 0);
            labelAtaque4.Name = "labelAtaque4";
            labelAtaque4.Size = new Size(54, 15);
            labelAtaque4.TabIndex = 11;
            labelAtaque4.Text = "Ataque 4";
            // 
            // labelItem
            // 
            labelItem.AutoSize = true;
            labelItem.Location = new Point(35, 269);
            labelItem.Margin = new Padding(4, 0, 4, 0);
            labelItem.Name = "labelItem";
            labelItem.Size = new Size(31, 15);
            labelItem.TabIndex = 12;
            labelItem.Text = "Item";
            // 
            // PokemonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 359);
            Controls.Add(labelItem);
            Controls.Add(labelAtaque4);
            Controls.Add(labelAtaque3);
            Controls.Add(labelAtaque2);
            Controls.Add(labelAtaque1);
            Controls.Add(labelPokemon);
            Controls.Add(buttonConfirm);
            Controls.Add(comboBoxItem);
            Controls.Add(comboBoxAtaque4);
            Controls.Add(comboBoxAtaque3);
            Controls.Add(comboBoxAtaque2);
            Controls.Add(comboBoxAtaque1);
            Controls.Add(comboBoxPokemon);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PokemonForm";
            Text = "Selecione o Pokémon";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
