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
    public partial class Form2 : Form
    {  
        public Form2()
        {
            InitializeComponent();
        }
       
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marit;
            string connetionString = null;
            SqlConnection cnn;

            connetionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            cnn = new SqlConnection(connetionString);
            string sql = null;
            sql = "insert into MainDB ([Id], [FirstName],[LastName],[Address],[ContactAddress],[Gender],[Telephone],[DOB],[Martial],[Religion],[District],[Aadhar],[DoJoin],[Days],[DateOfConformation],[Designation],[Department],[FatherName],[MotherName],[SpouseName],[Child],[HSC],[Degree],[OtherSkills],[ProfessionalQualification],[BasicSalary],[BankCode],[AccountNo]) values (@id,@firstname,@lastname,@peremanentadd,@contactadd,@gender,@telephone,@dob,@martial,@religion,@district,@aadhar,@dojoin,@days,@doconf,@designation,@depart,@fathername,@mothername,@spousename,@child,@hsc,@degree,@otherskills,@profqualification,@basicsalary,@bankcode,@accno)";
           
            cnn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@firstname", textBox10.Text);
                cmd.Parameters.AddWithValue("@lastname", textBox11.Text);
                cmd.Parameters.AddWithValue("@peremanentadd", textBox12.Text);
                cmd.Parameters.AddWithValue("@contactadd", textBox13.Text);
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
               
                cmd.Parameters.AddWithValue("@telephone", textBox14.Text);
                string date = null;
                date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                cmd.Parameters.AddWithValue("@dob", date);

                if (checkBox1.Checked == true)
                {
                    
                    marit = "married";
                    cmd.Parameters.AddWithValue("@martial",marit);
                }
                else
                {
                    marit = "nonmarried";
                    cmd.Parameters.AddWithValue("@martial", marit);
                }
                
                cmd.Parameters.AddWithValue("@religion", textBox18.Text);
                cmd.Parameters.AddWithValue("@district", textBox15.Text);
                cmd.Parameters.AddWithValue("@aadhar", textBox16.Text);
                cmd.Parameters.AddWithValue("@dojoin", textBox20.Text);
                cmd.Parameters.AddWithValue("@days", textBox23.Text);
                cmd.Parameters.AddWithValue("@doconf", textBox19.Text);
                cmd.Parameters.AddWithValue("@designation", textBox21.Text);
                cmd.Parameters.AddWithValue("@depart", comboBox1.Text);
                cmd.Parameters.AddWithValue("@fathername", textBox24.Text);
                cmd.Parameters.AddWithValue("@mothername", textBox25.Text);
                cmd.Parameters.AddWithValue("@spousename", textBox26.Text);
                cmd.Parameters.AddWithValue("@child", textBox27.Text);
                cmd.Parameters.AddWithValue("@hsc", textBox2.Text);
                cmd.Parameters.AddWithValue("@degree", textBox3.Text);
                cmd.Parameters.AddWithValue("@otherskills", textBox4.Text);
                cmd.Parameters.AddWithValue("@profqualification", textBox5.Text);
                cmd.Parameters.AddWithValue("@basicsalary", textBox6.Text);
                cmd.Parameters.AddWithValue("@bankcode", textBox7.Text);
                cmd.Parameters.AddWithValue("@accno", textBox8.Text);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row Inserted Successfully!! ");
            }

            cnn.Close();
            clean();
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
            textBox15.Text= "";
            textBox16.Text= "";
            textBox18.Text= "";
            textBox19.Text= "";
            textBox20.Text= "";
            textBox21.Text= "";
        
            textBox23.Text= "";
            textBox24.Text= "";
            textBox25.Text= "";
            textBox26.Text = "";
            textBox27.Text = "";
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clean();   
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
