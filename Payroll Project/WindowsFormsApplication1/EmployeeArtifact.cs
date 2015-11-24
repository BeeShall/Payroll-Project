using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Payroll
{
    public class EmployeeArtifact
    {
        [DisplayName("Staff Id")]
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Date Of Birth")]
        public string DateOfBirth { get; set; }
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }
                public string Designation { get; set; }
        public string Address { get; set; }
        public string Qualification { get; set; }
        [DisplayName("Contact Number")]
        public string ContactDetails { get; set; }
        
        public bool Active { get; set; }
        
        public bool Deleted { get; set; }

       
      
      

        public List<EmployeeArtifact> GetAllEmployee()
        {
            DbConnectionManager connect = new DbConnectionManager();
            SqlConnection conn = connect.connectToDb();
            string employeeQuery = "select * from employee ";
            SqlCommand cmd1 = new SqlCommand(employeeQuery);
            cmd1.Connection = conn;
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd1;
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "employee");
           
                                    
            List<EmployeeArtifact> empArtifactList = new List<EmployeeArtifact>();
            foreach (DataRow dr in ds1.Tables["employee"].Rows)
            {
                EmployeeArtifact temp = new EmployeeArtifact(); 
                temp.DateOfBirth = dr["dateofbirth"].ToString();
                temp.FirstName = dr["fname"].ToString();
                temp.Address = dr["address"].ToString();
                temp.Id = int.Parse(dr["id"].ToString());
                temp.LastName = dr["lname"].ToString();
                temp.MiddleName = dr["middlename"].ToString();
                temp.Designation = dr["designation"].ToString();
                temp.Qualification = dr["qualification"].ToString();
                temp.ContactDetails = dr["contactdetails"].ToString();
                temp.Active = bool.Parse(dr["active"].ToString());
                temp.Deleted = bool.Parse(dr["deleted"].ToString());
                empArtifactList.Add(temp);             
            }
            return empArtifactList;
        }

       
         

        public bool EditEmployee(EmployeeArtifact obj)
        {

            string query = "update employee set lname ='" + obj.LastName + "', middlename='" + obj.MiddleName + "' ,designation='" + obj.Designation 
                + "',address='" + obj.Address + "',contactdetails = '" + obj.ContactDetails 
                + "',active = '" + obj.Active + "', deleted= '" + obj.Deleted + "', dateofbirth = '" + obj.DateOfBirth + "',qualification = '"+obj.Qualification+"' where id = " + obj.Id;
            DbConnectionManager dbConnectionManager = new DbConnectionManager();
            SqlConnection connection = dbConnectionManager.connectToDb();

            SqlCommand command = new SqlCommand(query);
            command.Connection = connection;
            int result = command.ExecuteNonQuery();
            dbConnectionManager.diconnectFromDb(connection);

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
