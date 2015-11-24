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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            bool workstate;
            if (active.Checked == true)
            {
                workstate = true;
            }
            else
            {
                workstate = false;
            }
            DbConnectionManager connect = new DbConnectionManager();
            SqlConnection conn = connect.connectToDb();
            string query = "insert into employee(fname,lname,middlename,designation,address,contactdetails,active,deleted,dateofbirth,qualification) values ('" + fname_txtbox.Text+"','"+ lname_txtbox.Text + "','" + mname_txtbox.Text +"','"+ designation_txtbox.Text +"','" + address_txtbox.Text+"','"+ contact_txtbox.Text + "','"+workstate+"','False','" + dob_pick.Value.Date +"','" + qualification_txtbox.Text + "')";
            SqlCommand command = new SqlCommand(query);
            command.Connection = conn;
            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
            string selectid = "select max(id) as id from employee";
            command.CommandText = selectid;
            command.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataSet ds = new DataSet();
            da.Fill(ds, "employee_id");
                DataRow dr = ds.Tables["employee_id"].Rows[0];
            string employee_id = dr["id"].ToString();
            string salary = "insert into salary(employee_id,basic_salary,allowance, insurance) values(" + employee_id + ",0,0,0)";
            SqlCommand command1 = new SqlCommand(salary);
            command1.Connection = conn;
            command1.ExecuteNonQuery();
                                          
                MessageBox.Show("New Employee Added");
                connect.diconnectFromDb(conn);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Failed adding New Employee");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
