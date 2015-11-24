namespace Payroll
{
    partial class PerspectivePayslip
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerspectivePayslip));
            this.label2 = new System.Windows.Forms.Label();
            this.fname_combobox = new System.Windows.Forms.ComboBox();
            this.lname_txtbox = new System.Windows.Forms.TextBox();
            this.show_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.Label();
            this.selectYear_combobox = new System.Windows.Forms.ComboBox();
            this.selectMonth_combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insurance_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allowance_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthlySalary_txtbox = new System.Windows.Forms.TextBox();
            this.basic_salary = new System.Windows.Forms.Label();
            this.emp_idtxtbox = new System.Windows.Forms.TextBox();
            this.emp_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.netsalary = new System.Windows.Forms.Label();
            this.designation_txtbox = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.GroupBox();
            this.netSalary_txtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Salary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff Name";
            // 
            // fname_combobox
            // 
            this.fname_combobox.FormattingEnabled = true;
            this.fname_combobox.Location = new System.Drawing.Point(216, 56);
            this.fname_combobox.Name = "fname_combobox";
            this.fname_combobox.Size = new System.Drawing.Size(94, 21);
            this.fname_combobox.TabIndex = 3;
            this.fname_combobox.SelectedIndexChanged += new System.EventHandler(this.fname_combobox_SelectedIndexChanged);
            // 
            // lname_txtbox
            // 
            this.lname_txtbox.Location = new System.Drawing.Point(322, 56);
            this.lname_txtbox.Name = "lname_txtbox";
            this.lname_txtbox.ReadOnly = true;
            this.lname_txtbox.Size = new System.Drawing.Size(100, 20);
            this.lname_txtbox.TabIndex = 5;
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(366, 260);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(75, 23);
            this.show_button.TabIndex = 22;
            this.show_button.Text = "Show";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Year";
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Location = new System.Drawing.Point(505, 219);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(37, 13);
            this.Month.TabIndex = 20;
            this.Month.Text = "Month";
            // 
            // selectYear_combobox
            // 
            this.selectYear_combobox.FormattingEnabled = true;
            this.selectYear_combobox.Items.AddRange(new object[] {
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.selectYear_combobox.Location = new System.Drawing.Point(759, 216);
            this.selectYear_combobox.Name = "selectYear_combobox";
            this.selectYear_combobox.Size = new System.Drawing.Size(121, 21);
            this.selectYear_combobox.TabIndex = 19;
            this.selectYear_combobox.Text = "--Select One--";
            // 
            // selectMonth_combobox
            // 
            this.selectMonth_combobox.FormattingEnabled = true;
            this.selectMonth_combobox.Location = new System.Drawing.Point(560, 216);
            this.selectMonth_combobox.Name = "selectMonth_combobox";
            this.selectMonth_combobox.Size = new System.Drawing.Size(121, 21);
            this.selectMonth_combobox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Select a date:";
            // 
            // insurance_txt
            // 
            this.insurance_txt.Location = new System.Drawing.Point(216, 178);
            this.insurance_txt.Name = "insurance_txt";
            this.insurance_txt.ReadOnly = true;
            this.insurance_txt.Size = new System.Drawing.Size(181, 20);
            this.insurance_txt.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Insurance ";
            // 
            // allowance_txt
            // 
            this.allowance_txt.Location = new System.Drawing.Point(216, 148);
            this.allowance_txt.Name = "allowance_txt";
            this.allowance_txt.ReadOnly = true;
            this.allowance_txt.Size = new System.Drawing.Size(181, 20);
            this.allowance_txt.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Allowance";
            // 
            // monthlySalary_txtbox
            // 
            this.monthlySalary_txtbox.Location = new System.Drawing.Point(216, 118);
            this.monthlySalary_txtbox.Name = "monthlySalary_txtbox";
            this.monthlySalary_txtbox.ReadOnly = true;
            this.monthlySalary_txtbox.Size = new System.Drawing.Size(181, 20);
            this.monthlySalary_txtbox.TabIndex = 24;
            // 
            // basic_salary
            // 
            this.basic_salary.AutoSize = true;
            this.basic_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basic_salary.Location = new System.Drawing.Point(98, 118);
            this.basic_salary.Name = "basic_salary";
            this.basic_salary.Size = new System.Drawing.Size(112, 20);
            this.basic_salary.TabIndex = 23;
            this.basic_salary.Text = "Monthly Salary";
            // 
            // emp_idtxtbox
            // 
            this.emp_idtxtbox.Location = new System.Drawing.Point(216, 28);
            this.emp_idtxtbox.Name = "emp_idtxtbox";
            this.emp_idtxtbox.ReadOnly = true;
            this.emp_idtxtbox.Size = new System.Drawing.Size(181, 20);
            this.emp_idtxtbox.TabIndex = 31;
            // 
            // emp_id
            // 
            this.emp_id.AutoSize = true;
            this.emp_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_id.Location = new System.Drawing.Point(98, 28);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(62, 20);
            this.emp_id.TabIndex = 30;
            this.emp_id.Text = "Staff Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Designation";
            // 
            // netsalary
            // 
            this.netsalary.AutoSize = true;
            this.netsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netsalary.Location = new System.Drawing.Point(98, 208);
            this.netsalary.Name = "netsalary";
            this.netsalary.Size = new System.Drawing.Size(82, 20);
            this.netsalary.TabIndex = 33;
            this.netsalary.Text = "Net Salary";
            // 
            // designation_txtbox
            // 
            this.designation_txtbox.Location = new System.Drawing.Point(216, 92);
            this.designation_txtbox.Name = "designation_txtbox";
            this.designation_txtbox.ReadOnly = true;
            this.designation_txtbox.Size = new System.Drawing.Size(181, 20);
            this.designation_txtbox.TabIndex = 34;
            // 
            // Salary
            // 
            this.Salary.Controls.Add(this.netSalary_txtbox);
            this.Salary.Controls.Add(this.show_button);
            this.Salary.Controls.Add(this.emp_id);
            this.Salary.Controls.Add(this.designation_txtbox);
            this.Salary.Controls.Add(this.label2);
            this.Salary.Controls.Add(this.netsalary);
            this.Salary.Controls.Add(this.fname_combobox);
            this.Salary.Controls.Add(this.label6);
            this.Salary.Controls.Add(this.lname_txtbox);
            this.Salary.Controls.Add(this.emp_idtxtbox);
            this.Salary.Controls.Add(this.basic_salary);
            this.Salary.Controls.Add(this.monthlySalary_txtbox);
            this.Salary.Controls.Add(this.insurance_txt);
            this.Salary.Controls.Add(this.label5);
            this.Salary.Controls.Add(this.label1);
            this.Salary.Controls.Add(this.allowance_txt);
            this.Salary.Location = new System.Drawing.Point(314, 281);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(587, 308);
            this.Salary.TabIndex = 35;
            this.Salary.TabStop = false;
            // 
            // netSalary_txtbox
            // 
            this.netSalary_txtbox.Location = new System.Drawing.Point(216, 208);
            this.netSalary_txtbox.Name = "netSalary_txtbox";
            this.netSalary_txtbox.ReadOnly = true;
            this.netSalary_txtbox.Size = new System.Drawing.Size(181, 20);
            this.netSalary_txtbox.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1234, 82);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(437, 34);
            this.label7.TabIndex = 37;
            this.label7.Text = "Employee Payslips";
            // 
            // PerspectivePayslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.selectYear_combobox);
            this.Controls.Add(this.selectMonth_combobox);
            this.Controls.Add(this.label4);
            this.Name = "PerspectivePayslip";
            this.Size = new System.Drawing.Size(1237, 679);
            this.Load += new System.EventHandler(this.PerspectivePayslip_Load);
            this.Salary.ResumeLayout(false);
            this.Salary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fname_combobox;
        private System.Windows.Forms.TextBox lname_txtbox;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Month;
        private System.Windows.Forms.ComboBox selectYear_combobox;
        private System.Windows.Forms.ComboBox selectMonth_combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox insurance_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox allowance_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox monthlySalary_txtbox;
        private System.Windows.Forms.Label basic_salary;
        private System.Windows.Forms.TextBox emp_idtxtbox;
        private System.Windows.Forms.Label emp_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label netsalary;
        private System.Windows.Forms.TextBox designation_txtbox;
        private System.Windows.Forms.GroupBox Salary;
        private System.Windows.Forms.TextBox netSalary_txtbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}
