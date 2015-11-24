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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
           
            if (newpassword_txt.Text == confirmpassword_txt.Text)
            {
                 checklogin login = new checklogin();
                bool isSuccessful = login.CheckLoginCredential(UserUtils.USERNAME.ToString(), oldpassword_txt.Text);
                if (isSuccessful)
                {
                    string query = "update login set password ='"+ newpassword_txt.Text + "' where username = '" +UserUtils.USERNAME+ "' ";
                     DbConnectionManager dbConnectionManager= new DbConnectionManager ();
                    SqlConnection connection=dbConnectionManager.connectToDb();
                   
                    SqlCommand command = new SqlCommand(query); 
                    command.Connection = connection;
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Password Successfully Changed");
                    }
                    else
                    {
                        MessageBox.Show("Unable to change password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dbConnectionManager.diconnectFromDb(connection);

                }
            }   
            else
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
    }
}
