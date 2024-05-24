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
    public partial class AddPokemonForm : Form
    {
        public AddPokemonForm()
        {
            InitializeComponent();
        }

        public string PokemonName => textBoxName.Text;
        public string PokemonType => textBoxType.Text;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
