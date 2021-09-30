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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void Loan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet9.MainDB' table. You can move, or remove it, as needed.
           dt = new DataTable();
           DataColumn dc1 = new DataColumn("Amount");
            DataColumn dc2 = new DataColumn("Date");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            DataRow dr1 = dt.NewRow();
            dataGridView1.DataSource = dt;
         

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string connetionString = null;
            SqlConnection cnn;
            SqlCommand cmd = new SqlCommand();
            connetionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            cnn = new SqlConnection(connetionString);
            string date = null;
            date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string effect = null;
            effect = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            cnn.Open(); cmd = new SqlCommand("update MainDB SET LoanDescription ='" + comboBox1.Text + "', LoanAmt= '" + textBox8.Text + "', TotalAmt= '" + textBox11.Text + "', Install= '" + textBox12.Text + "', InterestRate= '" + textBox9.Text + "', InterestAmt= '" + textBox10.Text + "', IssueDate= '" + date + "', EffectFrom= '" + effect + "', RefNo= '" + textBox3.Text + "', Balance= '" + textBox13.Text + "' where Id= '" + textBox1.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Row inserted !! ");
            cnn.Close();
        
            clean();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void clean() 
        {
            textBox2.Text = "";
            textBox1.Text = "";
            textBox10.Text = ""; 
            textBox11.Text = "";
           textBox12.Text = "";
           textBox13.Text = "";
           textBox14.Text = ""; 
            textBox3.Text = "";
            textBox6.Text = "";
         comboBox1.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clean();
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
                textBox14.Text = reader["Department"].ToString();

            }
            else
            {
                MessageBox.Show("Incorrect ID");
            }
              
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
         
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            string same = textBox11.Text;
            textBox13.Text = same.ToString();
            textBox8.Text = same.ToString();
            textBox6.Text = same.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {   
           double presentValue; 
          double financingPeriod; 
            double interestRatePerYear;
          double a, b;
            double x;
          double monthlyPayment;
            interestRatePerYear = Int32.Parse(textBox9.Text);
            presentValue = Int32.Parse(textBox11.Text);
            financingPeriod = Int32.Parse(textBox12.Text);
            if (interestRatePerYear == 0)
            {
                monthlyPayment = presentValue / financingPeriod;
                textBox10.Text = monthlyPayment.ToString();
            }
            else
            {
                a = (1 + interestRatePerYear / 1200);
                b = financingPeriod;
                x = Math.Pow(a, b);
                x = 1 / x;
                x = 1 - x;
                
                monthlyPayment = (presentValue) * (interestRatePerYear / 1200) / x;
               
                textBox10.Text = monthlyPayment.ToString();
            }
            int i=1;
            var dateAndTime = DateTime.Now;
            int year = dateAndTime.Year;
            int month = dateAndTime.Month;
            int day = dateAndTime.Day;

          
             
            while (i <= financingPeriod)
            {
                DataRow dr1 = dt.NewRow();

                dr1[0] = Convert.ToString(monthlyPayment);

                if (day == 13)
                {
                    
                    dr1[1] = Convert.ToString(string.Format("{0}/{1}/{2}", month, day=1, year));
                }
                else if (day == 14)
                    {

                        dr1[1] = Convert.ToString(string.Format("{0}/{1}/{2}", month, day=2 , year));
                    }
                else if (day == 15)
                    {

                        dr1[1] = Convert.ToString(string.Format("{0}/{1}/{2}", month, day=3, year));

                    }
                else  if (day == 16)
                    {

                        dr1[1] = Convert.ToString(string.Format("{0}/{1}/{2}", month, day =4, year));

                    }
                else  if (day == 17)
                    {

                        dr1[1] = Convert.ToString(string.Format("{0}/{1}/{2}", month, day =5, year));

                    }
                
                else
                {
                   dr1[1] = Convert.ToString( string.Format("{0}/{1}/{2}", month, day, year));
                    
                }day++;
                dt.Rows.Add(dr1);
             
                dataGridView1.DataSource = dt;
                i++;
               
            }
        }
    

       
    }
}