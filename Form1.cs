using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace mainpage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form2 objForm = new Form2();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            empedit objForm = new empedit();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Allowance objForm = new Allowance();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Deduction objForm = new Deduction();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Advance objForm = new Advance();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Loan objForm = new Loan();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
           Salary_Transaction objForm = new Salary_Transaction();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Attendance objForm = new Attendance();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelSalaryTransationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancel_salary_transaction can = new Cancel_salary_transaction();
            can.Show();
        }

        private void allowanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Allowance objForm = new Allowance();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void advanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Advance objForm = new Advance();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void deducationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Deduction objForm = new Deduction();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void salaryTransationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Salary_Transaction objForm = new Salary_Transaction();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Process.Start("calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void leaveRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Attendance objForm = new Attendance();
            objForm.Show();
        }

        private void timeSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OverTime over = new OverTime();
            over.Show();

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            empedit objForm = new empedit();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form2 objForm = new Form2();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Payroll_System pay = new Payroll_System();
            pay.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Payroll_System pay = new Payroll_System();
            pay.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void payslipToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            payslip pay = new payslip();
            pay.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allowanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Allowance objForm = new Allowance();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void deductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Deduction objForm = new Deduction();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void advanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Advance objForm = new Advance();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }
    }
}
