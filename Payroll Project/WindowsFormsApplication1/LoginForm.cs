using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Payroll
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            {
                if (validate())
                {

                    checklogin login = new checklogin();
                    bool isSuccessful = login.CheckLoginCredential(username_txtbox.Text, password_txtbox.Text);

                    if (isSuccessful)
                    {
                        alert.Text = "";
                        UserUtils.USERNAME = username_txtbox.Text;
                        MessageBox.Show("Welcome to the system!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainWindow newfrom = new MainWindow();
                        newfrom.Show();
                        this.Hide();
                    }
                    else
                    {
                        alert.Text = "Wrong credentials";

                    }
                }
            }
        }
        private void cancel_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private bool validate()
        {
            if (username_txtbox.Text == null || username_txtbox.Text == "")
            {
                alert.Text = "Username Required";
                return false;
            }

            if (password_txtbox.Text == null || password_txtbox.Text == "")
            {
                alert.Text = "Password Required";
                return false;
            }
            return true;
        }
    }
}
