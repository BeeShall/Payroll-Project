using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Payroll
{
    class AttendanceArtifact
    {
        [DisplayName("Staff Id")]
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Contact Number")]
        public string ContactDetails { get; set; }
        public string Designation { get; set; }
        [DisplayName("Number Of Present Days")]
        public string NumberOfPresentDays { get; set; }

        public string GetAttendanceCountByEmpID(string empid, string month, string year, string numberOfDays)
        {

            DbConnectionManager connect = new DbConnectionManager();
            SqlConnection conn = connect.connectToDb();
            string attendanceQuery = "select * from attendance where employee_id = " + empid + " and attendance_date between '" + year + "/" + month + "/1 00:00:00.000' and '" + year + "/" + month + "/" + numberOfDays + " 00:00:00.000' and present = 'True'";
            SqlCommand cmd1 = new SqlCommand(attendanceQuery);
            cmd1.Connection = conn;
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "attendance");
            return ds1.Tables["attendance"].Rows.Count.ToString();


        }

        public List<AttendanceArtifact> GetAttendanceCount(string month, string year, string numberOfDays)
        {

            DbConnectionManager connect = new DbConnectionManager();
            SqlConnection conn = connect.connectToDb();

            string noOfDays = numberOfDays;

            string employeeQuery = "select * from employee ";
            SqlCommand cmd = new SqlCommand(employeeQuery);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "employee");
            List<AttendanceArtifact> attendanceArtifactList = new List<AttendanceArtifact>();
            foreach (DataRow dr in ds.Tables["employee"].Rows)
            {
                string empid = (dr["id"].ToString());
                string attendanceQuery = "select * from attendance where employee_id = " + empid + " and attendance_date between '" + year + "/" + month + "/1 00:00:00.000' and '" + year + "/" + month + "/" + noOfDays + " 00:00:00.000' and present = 'True'";
                SqlCommand cmd1 = new SqlCommand(attendanceQuery);
                cmd1.Connection = conn;
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "attendance");

                AttendanceArtifact attendance = new AttendanceArtifact();

                attendance.Id = int.Parse(empid);
                attendance.FirstName = dr["fname"].ToString();
                attendance.MiddleName = dr["middlename"].ToString();
                attendance.LastName = dr["lname"].ToString();
                attendance.Designation = dr["designation"].ToString();
                attendance.ContactDetails = dr["contactdetails"].ToString();
                attendance.NumberOfPresentDays = ds1.Tables["attendance"].Rows.Count.ToString();
                attendanceArtifactList.Add(attendance);
                connect.diconnectFromDb(conn);

            }
            return attendanceArtifactList;
        }

    }
}
