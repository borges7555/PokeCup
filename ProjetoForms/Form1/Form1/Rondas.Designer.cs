namespace Form1
{
    partial class Rondas
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
            buttonSimularRondas = new Button();
            listViewRondas = new ListView();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(49, 37);
            label4.Name = "label4";
            label4.Size = new Size(111, 37);
            label4.TabIndex = 7;
            label4.Text = "Rondas";
            // 
            // buttonSimularRondas
            // 
            buttonSimularRondas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSimularRondas.Location = new Point(589, 37);
            buttonSimularRondas.Name = "buttonSimularRondas";
            buttonSimularRondas.Size = new Size(157, 35);
            buttonSimularRondas.TabIndex = 23;
            buttonSimularRondas.Text = "Simular Rondas";
            buttonSimularRondas.UseVisualStyleBackColor = true;
            buttonSimularRondas.Click += buttonCriarRonda_Click;
            // 
            // listViewRondas
            // 
            listViewRondas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewRondas.Location = new Point(49, 109);
            listViewRondas.Name = "listViewRondas";
            listViewRondas.Size = new Size(697, 278);
            listViewRondas.TabIndex = 36;
            listViewRondas.UseCompatibleStateImageBehavior = false;
            listViewRondas.View = View.Details;
            listViewRondas.SelectedIndexChanged += listViewRondas_SelectedIndexChanged;
            // 
            // Rondas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(listViewRondas);
            Controls.Add(buttonSimularRondas);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rondas";
            Text = "Rondas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button buttonSimularRondas;
        private ListView listViewRondas;
    }
}