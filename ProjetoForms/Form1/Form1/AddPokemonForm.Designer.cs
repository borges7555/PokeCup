namespace Form1
{
    // AddPokemonForm.Designer.cs
    partial class AddPokemonForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Button buttonSave;

        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxType = new TextBox();
            buttonSave = new Button();
            labelPokemon = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(14, 56);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(303, 23);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(14, 124);
            textBoxType.Margin = new Padding(4, 3, 4, 3);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(303, 23);
            textBoxType.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(13, 478);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(303, 27);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelPokemon
            // 
            labelPokemon.AutoSize = true;
            labelPokemon.Location = new Point(14, 26);
            labelPokemon.Margin = new Padding(4, 0, 4, 0);
            labelPokemon.Name = "labelPokemon";
            labelPokemon.Size = new Size(18, 15);
            labelPokemon.TabIndex = 9;
            labelPokemon.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 96);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 166);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 11;
            label2.Text = "Caminho Imagem";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 198);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 273);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 23);
            textBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 241);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 13;
            label3.Text = "Tipo 1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 349);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(303, 23);
            textBox3.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 317);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 15;
            label4.Text = "Tipo 2";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 428);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(303, 23);
            textBox4.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 396);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 17;
            label5.Text = "Tier";
            // 
            // AddPokemonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 545);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelPokemon);
            Controls.Add(buttonSave);
            Controls.Add(textBoxType);
            Controls.Add(textBoxName);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddPokemonForm";
            Text = "Add Pokémon";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelPokemon;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
    }

}