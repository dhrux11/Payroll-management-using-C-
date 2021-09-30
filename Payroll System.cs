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
    public partial class Payroll_System : Form
    {
       
         
        
        public Payroll_System()
        {
           
            InitializeComponent();
        }
     
      
        
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Payroll_System_Load(object sender, EventArgs e)
        {

            panel1.Hide();
            panel2.Hide();

        }

      
        private void button41_Click(object sender, EventArgs e)
        { 
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string connetionString = null;
        SqlConnection cnn;
        connetionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            cnn = new SqlConnection(connetionString);
            SqlDataAdapter da;
            DataSet ds;
             da = new SqlDataAdapter("select * from emplogin where id='"+textBox1.Text+"'",cnn);
            ds= new DataSet();
            da.Fill(ds, "emplogin");
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.Hide();

                payslip frm = new payslip();
                frm.Show();

            }
            else
            {
                MessageBox.Show("login unsuccessfull");
            }

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


            panel1.Show();
            panel2.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Show();
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\harsh\Documents\Visual Studio 2010\Projects\BCA PROJECT\mainpage\mainpage\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            cnn = new SqlConnection(connetionString);
            SqlDataAdapter da;
            DataSet ds;
            da = new SqlDataAdapter("select * from payrolladmin where id='" + textBox4.Text + "'", cnn);
            ds = new DataSet();
            da.Fill(ds, "payrolladmin");
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.Hide();

                Form1 frm = new Form1();
                frm.Show();

            }
            else
            {
                MessageBox.Show("login unsuccessfull");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
