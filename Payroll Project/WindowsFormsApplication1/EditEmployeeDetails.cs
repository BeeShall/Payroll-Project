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
    public partial class EditEmployeeDetails : Form
    {
        public EditEmployeeDetails()
        {
            InitializeComponent();
        }

        private void EditEmployeeDetails_Load(object sender, EventArgs e)
        {
            EmployeeArtifact empArtifactObj = new EmployeeArtifact();
            List<EmployeeArtifact> list = new List<EmployeeArtifact>();
            list = empArtifactObj.GetAllEmployee();

            empname_combobox.DataSource = list;
            empname_combobox.DisplayMember = "FirstName";
            empname_combobox.ValueMember = "Id";

            /*
            DbConnectionManager connect = new DbConnectionManager();
            SqlConnection conn = connect.connectToDb();
            string query = "select * from employee";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "employee");
            empname_combobox.DataSource = ds.Tables["employee"];
            empname_combobox.DisplayMember = "fname";
            empname_combobox.ValueMember = "id";
            DataRowView id = (DataRowView)empname_combobox.SelectedItem;

            DisplayEmployeeDetails(empname_combobox.SelectedValue.ToString());
            connect.diconnectFromDb(conn);
             * */
        }
        private void DisplayEmployeeDetails(string employeename)
        {
            EmployeeArtifact selectedEmployee = (EmployeeArtifact)empname_combobox.SelectedItem;


            empid_txtbox.Text = selectedEmployee.Id.ToString();
            lname_txtbox.Text = selectedEmployee.LastName;
            mname_txtbox.Text = selectedEmployee.MiddleName;
            address_txtbox.Text = selectedEmployee.Address;
            contact_txtbox.Text = selectedEmployee.ContactDetails;
            dob_pick.Value = DateTime.Parse(selectedEmployee.DateOfBirth);
            qualification_txtbox.Text = selectedEmployee.Qualification;
            designation_txtbox.Text = selectedEmployee.Designation;
            active.Checked = selectedEmployee.Active;
            leave.Checked = selectedEmployee.Deleted;
            inactive.Checked = active.Checked ? false: true;

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            bool WorkState;
            if (active.Checked == true)
            {
                WorkState = true;
            }
            else
            {
                WorkState = false;
            }

            EmployeeArtifact artifactObj = new EmployeeArtifact();
            artifactObj.Active = WorkState;
            artifactObj.Address = address_txtbox.Text;
            artifactObj.ContactDetails = contact_txtbox.Text;
            artifactObj.DateOfBirth = dob_pick.Value.Date.ToString();
            artifactObj.Deleted = leave.Checked ? true : false;
            artifactObj.Designation = designation_txtbox.Text;
            artifactObj.FirstName = empname_combobox.Text;
            artifactObj.MiddleName = mname_txtbox.Text;
            artifactObj.LastName = lname_txtbox.Text;
            artifactObj.Qualification = qualification_txtbox.Text;
            artifactObj.Id = int.Parse(empid_txtbox.Text);
            if (artifactObj.EditEmployee(artifactObj))
            {
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void empname_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEmployeeDetails(empname_combobox.SelectedValue.ToString());
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DbConnectionManager connect = new DbConnectionManager();
            SqlConnection conn = connect.connectToDb();
            string query = "delete from employee where id = " + empid_txtbox.Text;
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = conn;
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Successfully Deleted");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {


        }

        private void EditEmployeeDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
