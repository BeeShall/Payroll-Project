using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payroll
{
    public partial class MonthlySalarySheet : UserControl
    {
        public MonthlySalarySheet()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void show_button_Click(object sender, EventArgs e)
        {
            SalaryDetails salary = new SalaryDetails();

            Month selectedmonth = (Month)selectMonth_combobox.SelectedItem;

            List<SalaryDetails> list = new List<SalaryDetails>();
            if (DateTime.Parse(selectedmonth.Id + "/" + selectedmonth.NumberOfDays + "/" + selectYear_combobox.SelectedItem.ToString()) <= System.DateTime.Today.Date)
            {
                list = salary.GetMonthlySalaryDetails(selectedmonth.Id.ToString(), selectYear_combobox.SelectedItem.ToString(), selectedmonth.NumberOfDays.ToString());
                dataGridView1.DataSource = list;
            }
            else {
                MessageBox.Show("The selected date exceeds today's date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MonthlySalarySheet_Load(object sender, EventArgs e)
        {
            Month monthObj = new Month();
            selectMonth_combobox.DataSource = monthObj.GetMonths();
            selectMonth_combobox.DisplayMember = "Name";
            selectMonth_combobox.ValueMember = "Id";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
