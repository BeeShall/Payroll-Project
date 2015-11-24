using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payroll
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You sure that You want to exit?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            
            
           
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee newform = new AddEmployee();
            newform.ShowDialog();
        }

        private void viewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEmployee newform = new ViewEmployee();
            newform.Show();
        }

        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEmployeeDetails newform = new EditEmployeeDetails();
            newform.ShowDialog();
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changepassword = new ChangePassword();
            changepassword.ShowDialog();
        }

        private void MainWindow_Load_1(object sender, EventArgs e)
        {
            
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DailyAttendance uc = new DailyAttendance();
            panel1.Controls.Add(uc);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthy_attendreport_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MonthlyAttendanceReport uc = new MonthlyAttendanceReport();
            panel1.Controls.Add(uc);
        }

        private void monthly_salarysheet_Click(object sender, EventArgs e)
        {
            panel1 .Controls.Clear();
            MonthlySalarySheet  uc = new MonthlySalarySheet();
            panel1.Controls.Add(uc);
        }

        private void perspective_payslip_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PerspectivePayslip uc = new PerspectivePayslip();
            panel1.Controls.Add(uc);

        }

        private void parameterSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryCredentialAssigner newform = new SalaryCredentialAssigner();
            newform.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 newform = new AboutBox1();
            newform.ShowDialog();
        }
    }
}
