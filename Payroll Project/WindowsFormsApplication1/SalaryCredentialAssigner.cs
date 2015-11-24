using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Payroll
{
    public partial class SalaryCredentialAssigner : Form
    {
        public SalaryCredentialAssigner()
        {
            InitializeComponent();
        }

        private void SalaryCredentialAssigner_Load(object sender, EventArgs e)
        {
            EmployeeArtifact empArtifactObj = new EmployeeArtifact();
            List<EmployeeArtifact> list = new List<EmployeeArtifact>();
            list = empArtifactObj.GetAllEmployee();
           

            empname_combobox.DataSource = list;
            empname_combobox.DisplayMember = "FirstName";
            empname_combobox.ValueMember = "Id";
        }

        private void DisplayEmployeeDetails(object p)
        {
            throw new NotImplementedException();
        }
       
        private void DisplayEmployeeDetails(string employeename)
        {
            EmployeeArtifact  selectedEmployee = (EmployeeArtifact)empname_combobox.SelectedItem;
            SalaryDetails salaryParameter = new SalaryDetails();

            SalaryDetails tempObj = salaryParameter.GetSalaryCredentialsByEmpId(selectedEmployee.Id.ToString());


            

            emp_idtxtbox.Text = selectedEmployee.Id.ToString();
            emplname_txtbox.Text = selectedEmployee.LastName;
            designation_txtbox.Text = selectedEmployee.Designation;
            basicSalary_txt.Text = tempObj.BasicSalary.ToString();
            allowance_txt.Text = tempObj.Allowance.ToString();
            insurance_txt.Text = tempObj.Insurance.ToString();

        }
         
        private void empid_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEmployeeDetails(empname_combobox.Text);
        }
        

        private void Update_button_Click(object sender, EventArgs e)
        {
            
            SalaryDetails artifactObj = new SalaryDetails();
            artifactObj.Id = int.Parse(emp_idtxtbox.Text);
            artifactObj.BasicSalary = float.Parse(basicSalary_txt.Text);
            artifactObj.Insurance = float.Parse(insurance_txt.Text);
            artifactObj.Allowance = float.Parse(allowance_txt.Text);
            if (artifactObj.UpdateSalaryDetails(artifactObj))
            {
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        


    }


}