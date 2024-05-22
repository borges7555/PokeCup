using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class AddJogadorForm : Form
    {
        public string Nickname { get; private set; }
        public float WL { get; private set; }

        public AddJogadorForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Nickname = txtNickname.Text;
            WL = float.Parse(txtWL.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }

}
