using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Payroll
{
    public partial class PerspectivePayslip : UserControl
    {
        public PerspectivePayslip()
        {
            InitializeComponent();
        }

        

        private void PerspectivePayslip_Load(object sender, EventArgs e)
        {
            
                 Month monthObj = new Month();
            selectMonth_combobox.DataSource = monthObj.GetMonths();
            selectMonth_combobox.DisplayMember = "Name";
            selectMonth_combobox.ValueMember = "Id";
        
                EmployeeArtifact empArtifactObj = new EmployeeArtifact();
                List<EmployeeArtifact> list = new List<EmployeeArtifact>();
                list = empArtifactObj.GetAllEmployee();

                fname_combobox.DataSource = list;
                fname_combobox.DisplayMember = "FirstName";
                fname_combobox.ValueMember = "Id";
            
        }
        private void DisplayEmployeeDetails()
        {
            EmployeeArtifact selectedEmployee = (EmployeeArtifact)fname_combobox.SelectedItem;
            lname_txtbox.Text = selectedEmployee.LastName;

                 Month selectedMonth = (Month)selectMonth_combobox.SelectedItem;
            
            SalaryDetails salaryParameter = new SalaryDetails();

            SalaryDetails tempObj = salaryParameter.GetMonthlySalaryByEmpId(selectedEmployee.Id.ToString(), selectedMonth.Id.ToString(), selectYear_combobox.SelectedItem.ToString(), selectedMonth.NumberOfDays.ToString());

            emp_idtxtbox.Text = selectedEmployee.Id.ToString();
            
            designation_txtbox.Text = selectedEmployee.Designation;
            monthlySalary_txtbox.Text = tempObj.MonthlySalary.ToString();
            netSalary_txtbox.Text = tempObj.NetSalary.ToString(); 
            allowance_txt.Text = tempObj.Allowance.ToString();
            insurance_txt.Text = tempObj.Insurance.ToString();
        }

             private void show_button_Click(object sender, EventArgs e)
             {
                 DisplayEmployeeDetails();
             }

             private void selectMonth_combobox_SelectedIndexChanged(object sender, EventArgs e)
             {

             }

             private void fname_combobox_SelectedIndexChanged(object sender, EventArgs e)
             {
                 
                 
             }
    }
}
