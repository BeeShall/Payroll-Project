using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Payroll
{
    class DbConnectionManager
    {
        public SqlConnection connectToDb()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["payroll_conn"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
                return connection;

            }
            else
            {
                return null;
            }
        }
        public void diconnectFromDb(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();

            }
        }
    }
}

