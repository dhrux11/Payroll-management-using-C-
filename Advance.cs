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
    public partial class Advance : Form
    {
        public Advance()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Advance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet11.MainDB' table. You can move, or remove it, as needed.
            this.mainDBTableAdapter.Fill(this.database1DataSet11.MainDB);
            // TODO: This line of code loads data into the 'database1DataSet3.MainDB' table. You can move, or remove it, as needed.
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            SqlCommand cmd;
            string date = null;
            date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            
            connetionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            cnn = new SqlConnection(connetionString);
            cmd = new SqlCommand("update MainDB SET  AdvanceDate= '" + date + "', AdvanceAmt = '" + textBox3.Text + "' where Id = '" + textBox1.Text + "'", cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Row inserted !! ");
            cnn.Close();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            string query = "select Id,FirstName,LastName,BasicSalary,AdvanceDate,AdvanceAmt from MainDb";
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
            
            textBox5.Text = "";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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
                textBox2.Text = reader["BasicSalary"].ToString();
                textBox5.Text = reader["FirstName"].ToString();

            }
            else
            {
                MessageBox.Show("Incorrect ID");
            }
        }

        
    }
}
