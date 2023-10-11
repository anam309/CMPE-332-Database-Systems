using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment2
{
    public partial class Form2 : Form
    {
        public static string username = "";
        public static string password = "";


        public Form2()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = usernameTextbox.Text;
            password = passwordTextbox.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.");
            }
            else

            {
                var datasource = @"DESKTOP-5UN9QJT\SQLEXPRESS";
                var database = "Northwind";
                var thisUsername = username;
                var thisPassword = password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
                SqlConnection conn = new SqlConnection(connString);

                try
                {
                    conn.Open();
                    //MessageBox.Show("Connection Successful"); 
                    Form1 frm1 = new Form1();
                    frm1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
