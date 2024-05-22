namespace Form1
{
    // AddPokemonForm.Designer.cs
    partial class AddPokemonForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
        private System.Windows.Forms.Button buttonSave;

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            this.SuspendLayout();

            // textBoxName
            this.textBoxName.Location = new System.Drawing.Point(12, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(260, 20);
            this.textBoxName.TabIndex = 0;

            // textBoxType
            this.textBoxType.Location = new System.Drawing.Point(12, 38);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(260, 20);
            this.textBoxType.TabIndex = 1;

            // numericUpDownLevel
            this.numericUpDownLevel.Location = new System.Drawing.Point(12, 64);
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Size = new System.Drawing.Size(260, 20);
            this.numericUpDownLevel.TabIndex = 2;

            // buttonSave
            this.buttonSave.Location = new System.Drawing.Point(12, 90);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(260, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // AddPokemonForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownLevel);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxName);
            this.Name = "AddPokemonForm";
            this.Text = "Add Pokémon";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}