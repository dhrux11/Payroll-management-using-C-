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
    public partial class Salary_Transaction : Form
    {
        public Salary_Transaction()
        {
            InitializeComponent();
        }
int pt;
int sundaypay = 600;
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void clean()
        {
          
            textBox10.Text = "00";
            textBox11.Text = "00";
            textBox12.Text = "00";
            textBox13.Text = "00";
            textBox14.Text = "00";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "00";
            textBox7.Text = "00";
            textBox8.Text = "00";
            textBox9.Text = "00";
            textBox20.Text = "00";
            textBox21.Text = "00";
            textBox22.Text = "00";
            textBox23.Text = "00";
            textBox24.Text = "00";
            textBox25.Text = "00";
            textBox26.Text = "00";
            textBox19.Text = "00";
            textBox16.Text = "00";
            textBox15.Text = "00";
            textBox11.Text = "00";
            textBox10.Text = "00";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            SqlDataAdapter da;
            DataSet ds;
            SqlCommand cmd = new SqlCommand();
            connetionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            string date = null;
            date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string date1 = null;
            date1 = dateTimePicker2.Value.ToString("MM/dd/yyyy"); cmd = new SqlCommand("update MainDB SET DateTo ='" + date + "', DateFrom= '" + date1 + "', NoWorking= '" + textBox8.Text + "', ProffessionalTax= '" + textBox1.Text + "', NoPayDays= '" + textBox10.Text + "',BonusAmt= '" + textBox7.Text + "', NoSunday= '" + textBox12.Text + "', Bonus= '" + comboBox1.Text + "', EPFContributions= '" + textBox24.Text + "', GrossSalary= '" + textBox25.Text + "', NetSalary= '" + textBox26.Text + "' where Id= '" + textBox3.Text + "'", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Row inserted !! ");
            cnn.Close();
           
            clean();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         private void textBox13_Leave(object sender, EventArgs e)
        {
            
            int sndayot;
            sndayot = int.Parse(textBox13.Text);
          
            if (sndayot <= 1)
            {

                textBox15.Text = sundaypay.ToString();
            }
            else if (sndayot <= 2)
            {
                sundaypay = sundaypay * 2;
                textBox15.Text = sundaypay.ToString();


            }
            else if (sndayot <= 3)
            {
                sundaypay = sundaypay * 3;
                textBox15.Text = sundaypay.ToString();

            }
            else
            {
                sundaypay = sundaypay * 4;
                textBox15.Text = sundaypay.ToString(); ;

            }}
         long dedadd;
         long add;
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
                textBox16.Text=reader["AllowanceDeptAmt"].ToString();
                textBox19.Text = reader["AdvanceAmt"].ToString();
                textBox4.Text = reader["Firstname"].ToString();
                textBox8.Text = reader["NoWorking"].ToString();
                textBox22.Text = reader["Casual"].ToString();
                textBox20.Text = reader["InterestAmt"].ToString();
                textBox5.Text = reader["Department"].ToString();
                textBox9.Text = reader["BasicSalary"].ToString();
                textBox11.Text = reader["OverTime"].ToString();
                textBox19.Text = reader["AdvanceAmt"].ToString();
                string allowind = reader["AllowanceIndivAmt"].ToString();
                string alldiv = reader["AllowanceDeptAmt"].ToString();
                long allin = Int64.Parse(allowind);
                long alld = Int64.Parse(alldiv);
                 add = alld + allin;
               textBox16.Text = add.ToString();
                string deductionwind = reader["DeductionIndivAmt"].ToString();
                string deddiv = reader["DeductionDeptAmt"].ToString();
                long dedin = Int64.Parse(deductionwind);
                long dedd = Int64.Parse(deddiv);
                dedadd = dedin + dedd;
              textBox23.Text = dedadd.ToString();
              string basics = reader["BasicSalary"].ToString();
              long basicsal = Int64.Parse(basics);
              if (basicsal >= 10000)
              {
                  pt = 175;
                  textBox1.Text = pt.ToString();
                  textBox6.Text = pt.ToString();

              }
              else if (basicsal < 10000)
              {
                  pt = 200;
                  textBox1.Text = pt.ToString();
                  textBox6.Text = pt.ToString();
              }
              else
              {
                  pt = 00;
                  textBox1.Text = pt.ToString();
                  textBox6.Text = pt.ToString();
              }
           
            
            }
            else
            {
                MessageBox.Show("Error");
            }

            
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {  string sqlQRY = null;
            string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection myDbconnection = new SqlConnection(connectionString);
            myDbconnection.Open();
            sqlQRY = "Select * from MainDB where Id='" + textBox3.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlQRY, myDbconnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                string basics = reader["BasicSalary"].ToString();
                long basicsal = Int64.Parse(basics);
                long nopaydays;


                string othr = reader["OverTime"].ToString();
               
                long othrs = Int64.Parse(othr);
                long otpaym = basicsal * 2 / 100;
                if (othrs <= 1)
                {
                    textBox14.Text = otpaym.ToString();
                }
                else if (othrs <= 2)
                {
                    otpaym = otpaym * 2;
                    textBox14.Text = otpaym.ToString();
                }
                else if (othrs <= 3)
                {
                    otpaym = otpaym * 3;
                    textBox14.Text = otpaym.ToString();
                }
                else
                {
                    otpaym = otpaym * 4;
                    textBox14.Text = otpaym.ToString();
                }
               string attend= reader["Casual"].ToString();
                
                long attendence = Int64.Parse(attend);
                nopaydays = 30 - attendence;

                textBox10.Text = nopaydays.ToString();
                textBox8.Text = nopaydays.ToString();

                long bonusamt = Int64.Parse(textBox7.Text);

               string absnt= reader["Casual"].ToString();
                
                long absntdays = Int64.Parse(absnt);

                long absentamt = absntdays * basicsal * 1 / 100;
                textBox22.Text = absentamt.ToString();
               string intamt= reader["InterestAmt"].ToString();
          double intrest = double.Parse(intamt);

                
               
                double grosssal = add + basicsal + bonusamt + otpaym + sundaypay;
                textBox25.Text = grosssal.ToString();
                string adv = reader["AdvanceAmt"].ToString();
                long advance = Int64.Parse(adv);
                double netsal;
                long epfcontri = basicsal * 5 / 100;
                textBox24.Text = epfcontri.ToString();
                netsal = grosssal - epfcontri - absentamt - intrest - pt - advance - dedadd;
                textBox26.Text = netsal.ToString();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clean();
        }

       
           
        }

       
    }

