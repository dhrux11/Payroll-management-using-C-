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
    public partial class OverTime : Form
    {
        public OverTime()
        {
            InitializeComponent();
        }

        private void OverTime_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet12.MainDB' table. You can move, or remove it, as needed.
            this.mainDBTableAdapter.Fill(this.database1DataSet12.MainDB);
            // TODO: This line of code loads data into the 'database1DataSet10.MainDB' table. You can move, or remove it, as needed.
       
            // TODO: This line of code loads data into the 'database1DataSet9.overtime' table. You can move, or remove it, as needed.
            

        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            SqlDataAdapter da;
            DataSet ds;
            SqlCommand cmd = new SqlCommand();
            connetionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            cnn = new SqlConnection(connetionString);
            string date = null;
            date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            cnn.Open(); cmd = new SqlCommand("update MainDB SET OverTimeDate ='" +date + "', WorkingDays= '" + comboBox1.Text + "', LoginTime= '" +textBox6 + "', LogoutTime= '" +textBox7+ "', TotalHrs= '" + textBox6.Text +"', OverTime= '" + textBox7.Text + "' where Id= '" + textBox3.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Row inserted !! ");
            cnn.Close();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            string query = "select Id,FirstName,LoginTime,LogoutTime,OverTime,OverTimeDate from MainDb";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            clean();
        }

        public void clean()
        {
            textBox2.Text = "";

            textBox3.Text = "";
            textBox4.Text = "";
       
            textBox6.Text = "";
            textBox7.Text = "";
         ;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
                textBox2.Text = reader["Firstname"].ToString();
                textBox4.Text = reader["Department"].ToString();

            }
            else
            {
                MessageBox.Show("Incorrect ID");
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
           
       

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startTime = Convert.ToDateTime(dateTimePicker3.Value);
            DateTime endTime = Convert.ToDateTime(dateTimePicker2.Value);

            TimeSpan span = endTime.Subtract(startTime).Duration();

            int hoursDifference = span.Hours;
            textBox6.Text = hoursDifference.ToString();
            if (hoursDifference > 8)
            {
                int ot = hoursDifference-8;
                textBox7.Text = ot.ToString();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
