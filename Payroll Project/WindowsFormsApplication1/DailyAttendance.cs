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
    public partial class DailyAttendance : UserControl
    {
        public DailyAttendance()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Notice.Text = "";
            DisplayEmployeeDetails(empfname_combobox.Text);
        }

        private void DailyAttendance_Load(object sender, EventArgs e)
        {
            EmployeeArtifact empArtifactObj = new EmployeeArtifact();
            List<EmployeeArtifact> list = new List<EmployeeArtifact>();
            list = empArtifactObj.GetAllEmployee();

            empfname_combobox.DataSource = list;
            empfname_combobox.DisplayMember = "FirstName";
            empfname_combobox.ValueMember = "Id";
        }
        private void DisplayEmployeeDetails(string employeename)
        {
            EmployeeArtifact selectedEmployee = (EmployeeArtifact)empfname_combobox.SelectedItem;
            empid_txtbox.Text = selectedEmployee.Id.ToString();
            emplname_txtbox.Text = selectedEmployee.LastName;
            designation_txtbox.Text = selectedEmployee.Designation;

        }
        private void AddAttendanceDetails(string empid)
        {

            DbConnectionManager connect = new DbConnectionManager();
            SqlConnection conn = connect.connectToDb();

            string query1 = "select * from attendance where attendance_date = '" + dateTimePicker1.Value.Date + "'";
            SqlCommand cmd1 = new SqlCommand(query1);
            cmd1.Connection = conn;
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "attendance");
            if (ds1.Tables["attendance"].Rows.Count != 0)
            {

                foreach (DataRow dr in ds1.Tables["attendance"].Rows)
                {
                    if (empid == (dr["employee_id"].ToString()))
                    {
                        Notice.Text = "Attendance Already Marked";
                    }
                    else
                    {
                        if (attendanceMarked(empid, conn) == true)
                        {
                            Notice.Text = "Attendance Marked Successfully";
                        }
                        else
                        {
                            Notice.Text = "Error! Try Again!";
                        }
                        
                    }
                }
            }
            else
            {
                if (attendanceMarked(empid, conn) == true)
                {
                    Notice.Text = "Attendance Marked Successfully";
                }
                else
                {
                    Notice.Text = "Error! Try Again!";
                }
                
            }
            connect.diconnectFromDb(conn);

        }
        public bool attendanceMarked(string empid, SqlConnection conn)
        {
            bool isPresent;
            isPresent = false;
            
            if (attendance_combobox.SelectedItem.ToString() == "Present")
            {
                isPresent = true;

            }
            else if (attendance_combobox.SelectedItem.ToString() == "Absent")
            {
                isPresent = false;
            }else
            
            {
                Notice.Text = "Please select an option";
            }

            string query = "insert into attendance(employee_id,attendance_date,present) values(" + empid + ",'" + dateTimePicker1.Value.Date + "','" + isPresent + "')";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void attendance_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void done_button_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date <= System.DateTime.Today.Date)
            {
                AddAttendanceDetails(empid_txtbox.Text);
            }
            else
            {
                MessageBox.Show("The selected date exceeds today's date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
