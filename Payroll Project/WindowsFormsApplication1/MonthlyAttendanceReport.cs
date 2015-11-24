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
    public partial class MonthlyAttendanceReport : UserControl
    {
        public MonthlyAttendanceReport()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void MonthlyAttendanceReport_Load(object sender, EventArgs e)
        {
            Month monthObj = new Month();
            selectMonth_combobox.DataSource = monthObj.GetMonths();
            selectMonth_combobox.DisplayMember = "Name";
            selectMonth_combobox.ValueMember = "Id";
        }

        private void show_button_Click(object sender, EventArgs e)
        {
           
            AttendanceArtifact attendance = new AttendanceArtifact();

            Month selectedmonth = (Month)selectMonth_combobox.SelectedItem;
            
            List<AttendanceArtifact> list = new List<AttendanceArtifact>();
            list = attendance.GetAttendanceCount(selectedmonth.Id.ToString(),selectYear_combobox.SelectedItem.ToString(),selectedmonth.NumberOfDays.ToString());
            dataGridView1.DataSource = list;
        }
    }
}
