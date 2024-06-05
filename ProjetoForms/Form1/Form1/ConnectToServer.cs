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
    public partial class ConnectToServer : Form
    {
        public ConnectToServer()
        {
            InitializeComponent();

            textBox1.Text = "mednat.ieeta.pt\\SQLSERVER,8101";
            textBox4.Text = "p9g5";
            textBox3.Text = "p9g5";
            textBox2.Text = "b62F@yZ$u@M%DB";
        }

        public static class ConnectionStringProvider
        {
            public static string ConnectionString { get; set; } = "Server=mednat.ieeta.pt\\SQLSERVER,8101;Database=p9g5;User Id=p9g5;Password=b62F@yZ$u@M%DB;";
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // User
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

            // Atualizar a string de conexão global
            ConnectionStringProvider.ConnectionString = $"Server={dbServer};Database={dbName};User Id={userName};Password={userPass};";
        }

        // Server
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // User
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // Password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // DB name
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
