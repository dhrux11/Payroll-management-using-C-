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
using System.Drawing.Printing;


namespace mainpage
{
    public partial class payslip : Form
    {
        public payslip()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PrintScreen();
            printPreviewDialog1.ShowDialog();
        }


        private void payslip_Load(object sender, EventArgs e)
        {

        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Payroll_System n = new Payroll_System();
            n.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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

                string netsal = reader["Netsalary"].ToString();
                long net = Int64.Parse(netsal);
                if (net < 0) { MessageBox.Show("salary is being canceled !!"); }

                label12.Text = reader["Firstname"].ToString();
                label13.Text = reader["Dojoin"].ToString();
                label14.Text = reader["NoWorking"].ToString();
                label15.Text = reader["Casual"].ToString();
                label16.Text = reader["NoSunday"].ToString();
                label17.Text = reader["Department"].ToString();
                label18.Text = reader["Designation"].ToString();
                label19.Text = reader["AccountNo"].ToString();
                label20.Text = reader["Aadhar"].ToString();
                label37.Text = reader["BasicSalary"].ToString();
                label42.Text = reader["BonusAmt"].ToString();
                label43.Text = reader["OverTime"].ToString();
                label52.Text = reader["Proffessionaltax"].ToString();
                label53.Text = reader["EPFContributions"].ToString();
                label32.Text = reader["AdvanceAmt"].ToString();
                label26.Text = reader["GrossSalary"].ToString();
                label28.Text = reader["GrossSalary"].ToString();
                string allowind = reader["AllowanceIndivAmt"].ToString();
                string alldiv = reader["AllowanceDeptAmt"].ToString();
                int allin = Int16.Parse(allowind);
                int alld = Int16.Parse(alldiv);
                int add = alld + allin;
                label38.Text = add.ToString();
                string deductionwind = reader["DeductionIndivAmt"].ToString();
                string deddiv = reader["DeductionDeptAmt"].ToString();
                long dedin = Int64.Parse(deductionwind);
                long dedd = Int64.Parse(deddiv);
                long dedadd = dedin + dedd;
                label49.Text = dedadd.ToString();
                string profession = reader["ProffessionalTax"].ToString();
                long profess = Int64.Parse(profession);
                string epf = reader["EPFContributions"].ToString();
                long ef = Int64.Parse(epf);
                string epf1 = reader["AdvanceAmt"].ToString();
                long ef1 = Int64.Parse(epf);
                long totalded = dedadd + profess + ef + ef1;
                long basicsalary;
                label28.Text = totalded.ToString();

                basicsalary = int.Parse(label37.Text);
                string oth = reader["OverTime"].ToString();
                int othrs = Int16.Parse(oth);
                long otpaym = basicsalary * 2 / 100;
                if (othrs <= 1)
                {
                    label43.Text = otpaym.ToString();
                }
                else if (othrs <= 2)
                {
                    otpaym = otpaym * 2;
                    label43.Text = otpaym.ToString();
                }
                else if (othrs <= 3)
                {
                    otpaym = otpaym * 3;
                    label43.Text = otpaym.ToString();
                }
                myDbconnection.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Id");
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }
    }
}
