using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace mainpage
{
    public partial class Cancel_salary_transaction : Form
    {
        public Cancel_salary_transaction()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            SqlCommand cmd = new SqlCommand();
            connetionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            string date = null;
            date = dateTimePicker1.Value.ToString("MM/dd/yyyy"); 
            cmd = new SqlCommand("update MainDB SET CancelTransactionDate = '" + date + "' where Id= '" + textBox1.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Row inserted !! ");
            cnn.Close();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            string query = "select ID,FirstName,Department,CancelTransactionDate from MainDb";
            cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            clean();
        }
        public void clean()
        {
            textBox2.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
      
        }
        private void Cancel_salary_transaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet6.MainDB' table. You can move, or remove it, as needed.
            this.mainDBTableAdapter.Fill(this.database1DataSet6.MainDB);

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string sqlQRY = null;
            string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection myDbconnection = new SqlConnection(connectionString);
            myDbconnection.Open();
            sqlQRY = "Select * from MainDB where Id='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlQRY, myDbconnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                textBox2.Text = reader["Firstname"].ToString();
                textBox3.Text = reader["Department"].ToString();

            }
            else
            {
                MessageBox.Show("Incorrect ID");
            }
        }
    }
}
