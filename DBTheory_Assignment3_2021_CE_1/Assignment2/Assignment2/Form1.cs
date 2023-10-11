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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form1_Load() called..."); textBoxDisplay.Text = "Startup..."; try
            {

                var datasource = @"DESKTOP-5UN9QJT\SQLEXPRESS";
                var database = "Northwind";
                var thisUsername = Form2.username;
                var thisPassword = Form2.password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
                SqlConnection conn = new SqlConnection(connString); conn.Open();
                textBoxDisplay.Text = "Connection Successful on Startup"; conn.Close();
            }

            catch (Exception ex)
            {
                textBoxDisplay.Text = "Error, " + ex;
            }
        }



        private void buttonCountRecords_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-5UN9QJT\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();
            textBoxDisplay.Text = "Counting Records...";
            command.Connection = connection;
            command.CommandText = "select count(*) from Customers";
            int count = (int)command.ExecuteScalar();
            textBoxDisplay.Text = "Number of records: " + count;
            connection.Close();

        }

        private void buttonUpdateDb_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-5UN9QJT\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();
            textBoxDisplay.Text = "Inserting Record...";
            command.Connection = connection;
            command.CommandText = "insert into Customers (CustomerID, CompanyName) values('" +
            textBoxId.Text + "','" + textBoxCompany.Text + "')";
            command.ExecuteNonQuery();
            textBoxDisplay.Text = "Record Inserted...";
            connection.Close();
        }

        private void buttonViewDb_Click(object sender, EventArgs e)
        {
            string currentTable = ""; 
            if (customersRadioButton.Checked)
            {
                currentTable = "Customers";
            }
            else if (employeesRadioButton.Checked)
            {
                currentTable = "Employees";
            }
            else if (ordersRadioButton.Checked)
            {
                currentTable = "Orders";
            }

            dataGridView1.DataSource = null;
            try
            {
                SqlCommand command = new SqlCommand();
                //SqlConnection connection = new SqlConnection(@"DataSource = (local)\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True");
                var datasource = @"DESKTOP-5UN9QJT\SQLEXPRESS";                 
                var database = "Northwind";                 
                var thisUsername = Form2.username;                
                var thisPassword = Form2.password; 
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;
                SqlConnection conn = new SqlConnection(connString); conn.Open();
                textBoxDisplay.Text = "Retrieving Records..."; command.Connection = conn;
                command.CommandText = "select * from " + currentTable;
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable(); da.Fill(dt);

                dataGridView1.DataSource = dt;
                textBoxDisplay.Text = "Retrieval Successful!"; conn.Close();
            }
            catch (Exception ex)
            {
                textBoxDisplay.Text = "Error, " + ex;
            }


        }
    }
}
