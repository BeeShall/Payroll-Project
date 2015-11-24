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
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            EmployeeArtifact empArtifactObj = new EmployeeArtifact();
            List<EmployeeArtifact> list = new List<EmployeeArtifact>();
            list = empArtifactObj.GetAllEmployee();

                      view_employee.DataSource = list;

           
           
        }
    }
}
