using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Form1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TestDBConnection(string dbServer, string dbName, string userName, string userPass)
        {
            SqlConnection CN = new SqlConnection("Data Source = " + dbServer + ";" +
                                                  "Initial Catalog = " + dbName + "; uid = " + userName + ";" + "password = " + userPass);

            try
            {
                CN.Open();
                if (CN.State == ConnectionState.Open)
                {
                    MessageBox.Show("Successful connection to database " + CN.Database + " on the " +
                                    CN.DataSource + " server", "Connection Test", MessageBoxButtons.OK);

                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide(); // Ou this.Close(); se quiser fechar o Form5
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open connection to database due to the error \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }

            if (CN.State == ConnectionState.Open)
                CN.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string dbServer = textBox1.Text;
            string dbName = textBox4.Text;
            string userName = textBox3.Text;
            string userPass = textBox2.Text;

            TestDBConnection(dbServer, dbName, userName, userPass);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
