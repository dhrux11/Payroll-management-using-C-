using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace mainpage
{
    public partial class Allowance : Form
    {
        public Allowance()
        {
            InitializeComponent();
        }
       
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Allowance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet13.MainDB' table. You can move, or remove it, as needed.
            this.mainDBTableAdapter2.Fill(this.database1DataSet13.MainDB);
            // TODO: This line of code loads data into the 'database1DataSet5.MainDB' table. You can move, or remove it, as needed.
            this.mainDBTableAdapter1.Fill(this.database1DataSet5.MainDB);
            
          
           
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
            cmd = new SqlCommand("update MainDB SET AllowanceDeptType ='" + comboBox1.Text + "', AllowanceDeptAmt= '" + textBox1.Text + "', AllowanceDeptDate = '" + date + "' where Department= '" + comboBox3.Text + "'", cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row inserted !! ");
            cnn.Close();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            string query = "select Department,AllowanceDeptAmt,AllowanceDeptDate,AllowanceDeptType from MainDb";
            cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            clean();
        }

        private void allowancedeptBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            SqlCommand cmd = new SqlCommand();
            connetionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            cnn = new SqlConnection(connetionString);
            string date = null;
            date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            
            cnn.Open(); cmd = new SqlCommand("update MainDB SET AllowanceIndivType ='" + comboBox2.Text + "', AllowanceIndivAmt= '" + textBox6.Text + "', AllowanceIndivDate = '" + date + "' where Id= '" + textBox3.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Row inserted !! ");
            cnn.Close();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            string query = "select Id,FirstName,AllowanceIndivAmt,AllowanceIndivDate,AllowanceIndivType from MainDb";
            cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
            clean();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clean()
        {
           
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
           
           
        }
        private void button5_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string sqlQRY = null;
            string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection myDbconnection = new SqlConnection(connectionString);
            myDbconnection.Open();
            sqlQRY = "Select * from MainDB where Id='" + textBox3.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlQRY, myDbconnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                textBox4.Text = reader["Firstname"].ToString();
               
            }
            else
            {
                MessageBox.Show("Incorrect ID");
            }
        }

        private void textBox4_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
   
}

