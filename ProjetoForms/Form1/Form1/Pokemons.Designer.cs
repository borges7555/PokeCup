namespace Form1
{
    partial class Pokemons
    {
        private System.ComponentModel.IContainer components = null;

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
            label4 = new Label();
            listViewPokemons = new ListView();
            label1 = new Label();
            pictureBoxPokemon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(28, 24);
            label4.Name = "label4";
            label4.Size = new Size(150, 37);
            label4.TabIndex = 4;
            label4.Text = "Pokemons";
            label4.Click += label4_Click;
            // 
            // listViewPokemons
            // 
            listViewPokemons.Location = new Point(28, 90);
            listViewPokemons.Name = "listViewPokemons";
            listViewPokemons.Size = new Size(493, 421);
            listViewPokemons.TabIndex = 32;
            listViewPokemons.UseCompatibleStateImageBehavior = false;
            listViewPokemons.View = View.Details;
            listViewPokemons.SelectedIndexChanged += listViewPokemons_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(562, 62);
            label1.Name = "label1";
            label1.Size = new Size(358, 25);
            label1.TabIndex = 33;
            label1.Text = "Imagem Pokemon (Selecione um Pokemon)";
            // 
            // pictureBoxPokemon
            // 
            pictureBoxPokemon.Location = new Point(562, 90);
            pictureBoxPokemon.Name = "pictureBoxPokemon";
            pictureBoxPokemon.Size = new Size(464, 429);
            pictureBoxPokemon.TabIndex = 34;
            pictureBoxPokemon.TabStop = false;
            pictureBoxPokemon.Click += pictureBoxPokemon_Click;
            // 
            // Pokemons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 600);
            ControlBox = false;
            Controls.Add(pictureBoxPokemon);
            Controls.Add(label1);
            Controls.Add(listViewPokemons);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pokemons";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPokemon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label4;
        private ListView listViewPokemons;
        private Label label1;
        private PictureBox pictureBoxPokemon;
    }
}
