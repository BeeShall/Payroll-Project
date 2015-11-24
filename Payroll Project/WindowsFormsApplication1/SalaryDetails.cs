using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;

namespace Payroll
{
    public class SalaryDetails
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Designation { get; set; }
        [DisplayName("Basic Salary")]
        public float BasicSalary { get; set; }
        [DisplayName("Number Of Present Days")]
        public int NoOfPresentDays { get; set; }
        [DisplayName("Monthly Salary")]
        public float MonthlySalary { get; set; }
        public float Allowance { get; set; }
        public float Insurance { get; set; }
        [DisplayName("Net Salary")]
        public float NetSalary { get; set; }
        public List<SalaryDetails> GetMonthlySalaryDetails(string month, string year, string numberOfDays)
        {
            DbConnectionManager connect = new DbConnectionManager();
            SqlConnection conn = connect.connectToDb();
                       string employeeQuery = "select * from employee ";
            SqlCommand cmd = new SqlCommand(employeeQuery);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "employee");
            List<SalaryDetails> monthlySalaryDetails = new List<SalaryDetails>();
            foreach (DataRow dr in ds.Tables["employee"].Rows)
            {
                
                string empid = (dr["id"].ToString());

                SalaryDetails salary = new SalaryDetails();
                AttendanceArtifact selectedMonth = new AttendanceArtifact();

                SalaryDetails tempObj = salary.GetSalaryCredentialsByEmpId(empid);
                salary.FirstName = dr["fname"].ToString();
                salary.MiddleName = dr["middlename"].ToString();
                salary.LastName = dr["lname"].ToString();
                salary.Designation = dr["designation"].ToString();
                salary.Id = int.Parse(empid);
                salary.BasicSalary = tempObj.BasicSalary;
                salary.NoOfPresentDays = int.Parse(selectedMonth.GetAttendanceCountByEmpID(empid, month, year, numberOfDays));
                salary.MonthlySalary = (salary.BasicSalary * salary.NoOfPresentDays);
                salary.Allowance = (salary.MonthlySalary * (tempObj.Allowance / 100));
                salary.Insurance = (salary.MonthlySalary * (tempObj.Insurance/100));
                salary.NetSalary = (salary.MonthlySalary + salary.Allowance - salary.Insurance);
                monthlySalaryDetails.Add(salary);

                string redundantCheckQuery = "select * from monthlySalary where emp_id = " + int.Parse(empid) + " and month = '" + year + "/" + month + "/" + numberOfDays + " 00:00:00.000'";
                SqlCommand cmd1 = new SqlCommand(redundantCheckQuery);
                cmd1.Connection = conn;
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "monthlySalary");
                if (ds1.Tables["monthlySalary"].Rows.Count == 0)
                {
                    string salaryQuery = "insert into monthlySalary(emp_id,month,monthlySalary,allowance,insurance,netSalary) values( " + int.Parse(empid) + ",'" + year + "/" + month + "/" + numberOfDays + " 00:00:00.000' ," +salary.MonthlySalary+","+salary.Allowance+","+salary.Insurance+","+ salary.NetSalary + ")";
                    SqlCommand command = new SqlCommand(salaryQuery);
                    command.Connection = conn;
                    command.ExecuteNonQuery();

                }
            }
            connect.diconnectFromDb(conn);
            return monthlySalaryDetails;
        }
        public SalaryDetails GetMonthlySalaryByEmpId(string empid, string month, string year, string numberOfDays)
        {
            DbConnectionManager connect = new DbConnectionManager();
            SqlConnection conn = connect.connectToDb();
            string salaryQuery = "select * from monthlySalary where emp_id = " + empid + " and month = '" + year + "/" + month + "/"+numberOfDays+" 00:00:00.000'";
            SqlCommand cmd = new SqlCommand(salaryQuery);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "monthlySalary");
            List<SalaryDetails> salaryArtifactList = new List<SalaryDetails>();

            SalaryDetails salary = new SalaryDetails();
            AttendanceArtifact selectedMonth = new AttendanceArtifact();
            foreach (DataRow dr in ds.Tables["monthlySalary"].Rows)
            {
                salary.Id = int.Parse(empid);
                salary.MonthlySalary = float.Parse(dr["monthlySalary"].ToString());
                salary.Allowance = float.Parse(dr["allowance"].ToString());
                salary.Insurance = float.Parse(dr["insurance"].ToString());
                salary.NetSalary = float.Parse(dr["netSalary"].ToString());
                
                salaryArtifactList.Add(salary);

            }
            return salary;
        }
        public SalaryDetails GetSalaryCredentialsByEmpId(string empId)
        {
            DbConnectionManager connect = new DbConnectionManager();
            SqlConnection conn = connect.connectToDb();
            string salaryQuery = "select * from salary where employee_id = " + empId;
            SqlCommand cmd = new SqlCommand(salaryQuery);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "salary");
            List<SalaryDetails> salaryArtifactList = new List<SalaryDetails>();

            SalaryDetails salary = new SalaryDetails();
            foreach (DataRow dr in ds.Tables["salary"].Rows)
            {
               

                salary.Id = int.Parse((dr["employee_id"].ToString()));
                salary.BasicSalary = float.Parse(dr["basic_salary"].ToString());
                salary.Allowance = float.Parse(dr["allowance"].ToString());
                salary.Insurance = float.Parse(dr["insurance"].ToString());
                
                salaryArtifactList.Add(salary);
            }


            connect.diconnectFromDb(conn);
            return salary;


        }

        public bool UpdateSalaryDetails(SalaryDetails obj)
        {
            DbConnectionManager dbConnectionManager = new DbConnectionManager();
            SqlConnection connection = dbConnectionManager.connectToDb();
            string query = "update salary set basic_salary =" + obj.BasicSalary + " ,allowance =" + obj.Allowance + " ,insurance =" + obj.Insurance + " where employee_id =" + obj.Id;
          

            SqlCommand command = new SqlCommand(query);
            command.Connection = connection;
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

       
    }
}
