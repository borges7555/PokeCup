namespace Form1
{
    partial class Torneios
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
            button5 = new Button();
            label4 = new Label();
            buttonSimularTorneio = new Button();
            listViewTorneios = new ListView();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Location = new Point(600, 32);
            button5.Name = "button5";
            button5.Size = new Size(157, 35);
            button5.TabIndex = 17;
            button5.Text = "Criar Torneio";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(35, 25);
            label4.Name = "label4";
            label4.Size = new Size(127, 37);
            label4.TabIndex = 12;
            label4.Text = "Torneios";
            // 
            // buttonSimularTorneio
            // 
            buttonSimularTorneio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSimularTorneio.Location = new Point(774, 32);
            buttonSimularTorneio.Name = "buttonSimularTorneio";
            buttonSimularTorneio.Size = new Size(157, 35);
            buttonSimularTorneio.TabIndex = 19;
            buttonSimularTorneio.Text = "Criar Partidas";
            buttonSimularTorneio.UseVisualStyleBackColor = true;
            buttonSimularTorneio.Click += buttonSimularTorneio_Click;
            // 
            // listViewTorneios
            // 
            listViewTorneios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listViewTorneios.Location = new Point(35, 127);
            listViewTorneios.Name = "listViewTorneios";
            listViewTorneios.Size = new Size(896, 316);
            listViewTorneios.TabIndex = 33;
            listViewTorneios.UseCompatibleStateImageBehavior = false;
            listViewTorneios.View = View.Details;
            listViewTorneios.SelectedIndexChanged += listViewTorneios_SelectedIndexChanged;
            // 
            // Torneios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(955, 621);
            ControlBox = false;
            Controls.Add(listViewTorneios);
            Controls.Add(buttonSimularTorneio);
            Controls.Add(button5);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Torneios";
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Label label4;
        private Button buttonSimularTorneio;
        private ListView listViewTorneios;
    }
}