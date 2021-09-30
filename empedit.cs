using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mainpage
{
    public partial class empedit : Form
    {
        public empedit()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
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
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";

            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
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
            string marit;
            if (checkBox3.Checked == true)
            {
                marit = "male";
                cmd.Parameters.AddWithValue("@gender", marit);
            }
            else
            {
                marit = "female";
                cmd.Parameters.AddWithValue("@gender", marit);
            }
            string mari;
            if (checkBox1.Checked == true)
            {

                mari = "married";
                cmd.Parameters.AddWithValue("@martial", mari);
            }
            else
            {
                mari = "nonmarried";
                cmd.Parameters.AddWithValue("@martial", mari);
            }
             cmd = new SqlCommand("update MainDB SET FirstName ='" + textBox10.Text + "', LastName= '" + textBox11.Text + "', Address= '" + textBox12.Text + "', ContactAddress= '" + textBox13.Text + "', Telephone= '" + textBox14.Text + "', Gender= '" + marit+ "', DOB= '" + date+ "', Martial= '" + mari+ "',Religion= '" + textBox18.Text + "',Aadhar= '" + textBox16.Text + "', DoJoin= '" + textBox20.Text+ "', Days= '" + textBox23.Text + "', DateOfConformation= '" + textBox19.Text + "', Designation= '" + textBox21.Text + "', District= '" + textBox15.Text + "',Department= '" + textBox22.Text+ "', FatherName= '" + textBox24.Text+ "',MotherName= '" + textBox25.Text+ "',SpouseName= '" + textBox26.Text+ "',Child= '" + textBox27.Text+ "',HSC= '" + textBox2.Text+ "',Degree= '" + textBox3.Text+ "', OtherSkills= '" + textBox4.Text+ "',ProfessionalQualification= '" + textBox5.Text+ "',BasicSalary= '" + textBox6.Text+ "',BankCode= '" + textBox7.Text+ "', AccountNo= '" + textBox8.Text+ "' where Id= '" + textBox1.Text + "'",cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Row Updated Successfully!! ");
            cnn.Close();
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
                textBox10.Text = reader["Firstname"].ToString();
                textBox11.Text = reader["LastName"].ToString();
                textBox12.Text = reader["Address"].ToString();
                textBox13.Text = reader["ContactAddress"].ToString();
                textBox14.Text = reader["Telephone"].ToString();
                textBox22.Text = reader["Department"].ToString();
                textBox21.Text = reader["Designation"].ToString();
                textBox8.Text = reader["AccountNo"].ToString();
                textBox16.Text = reader["Aadhar"].ToString();
                textBox6.Text = reader["BasicSalary"].ToString();
                textBox18.Text = reader["Religion"].ToString();
                textBox15.Text = reader["District"].ToString();
                textBox20.Text = reader["DoJoin"].ToString();
                textBox23.Text = reader["Days"].ToString();
                textBox19.Text = reader["DateOfConformation"].ToString();
                textBox26.Text = reader["SpouseName"].ToString();
                textBox27.Text = reader["Child"].ToString();
                textBox2.Text = reader["Hsc"].ToString();
                textBox3.Text = reader["Degree"].ToString();
                textBox4.Text = reader["OtherSkills"].ToString();
                textBox5.Text = reader["ProfessionalQualification"].ToString();
                textBox7.Text = reader["Bankcode"].ToString();
                textBox24.Text = reader["FatherName"].ToString();
                textBox25.Text = reader["MotherName"].ToString();



                myDbconnection.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Id");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlQRY = null;
            string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection myDbconnection = new SqlConnection(connectionString);
            myDbconnection.Open();
            sqlQRY = "delete from MainDB where Id='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlQRY, myDbconnection);
            SqlDataReader reader = cmd.ExecuteReader();
            MessageBox.Show("Deleted Successfully!!");
            myDbconnection.Close();
            clean();
        }
        }
    }

