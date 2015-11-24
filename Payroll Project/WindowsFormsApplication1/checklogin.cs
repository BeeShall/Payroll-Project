using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Payroll
{
    class checklogin
    {
        public bool CheckLoginCredential(string username, string password)
        {
            DbConnectionManager connect = new DbConnectionManager();
            SqlConnection conn = connect.connectToDb();
            string query = "select * from login " + "where username='" + username + "' and password='" + password + "'";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = conn;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "login");

            if (ds.Tables["Login"].Rows.Count > 0)
            {
                connect.diconnectFromDb(conn);
                return true;
            }
            else
            {
                connect.diconnectFromDb(conn);
                return false;
            }

        }

    }
}
