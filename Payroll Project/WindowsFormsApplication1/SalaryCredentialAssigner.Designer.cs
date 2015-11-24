namespace Payroll
{
    partial class SalaryCredentialAssigner
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emp_id = new System.Windows.Forms.Label();
            this.basic_salary = new System.Windows.Forms.Label();
            this.basicSalary_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allowance_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.insurance_txt = new System.Windows.Forms.TextBox();
            this.empname_combobox = new System.Windows.Forms.ComboBox();
            this.Update_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.emp_idtxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emplname_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.designation_txtbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emp_id
            // 
            this.emp_id.AutoSize = true;
            this.emp_id.Location = new System.Drawing.Point(15, 49);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(65, 13);
            this.emp_id.TabIndex = 0;
            this.emp_id.Text = "Employee Id";
            // 
            // basic_salary
            // 
            this.basic_salary.AutoSize = true;
            this.basic_salary.Location = new System.Drawing.Point(15, 184);
            this.basic_salary.Name = "basic_salary";
            this.basic_salary.Size = new System.Drawing.Size(65, 13);
            this.basic_salary.TabIndex = 3;
            this.basic_salary.Text = "Basic Salary";
            // 
            // basicSalary_txt
            // 
            this.basicSalary_txt.Location = new System.Drawing.Point(117, 181);
            this.basicSalary_txt.Name = "basicSalary_txt";
            this.basicSalary_txt.Size = new System.Drawing.Size(181, 20);
            this.basicSalary_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Allowance (in %)";
            // 
            // allowance_txt
            // 
            this.allowance_txt.Location = new System.Drawing.Point(117, 215);
            this.allowance_txt.Name = "allowance_txt";
            this.allowance_txt.Size = new System.Drawing.Size(181, 20);
            this.allowance_txt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Insurance (in %)";
            // 
            // insurance_txt
            // 
            this.insurance_txt.Location = new System.Drawing.Point(117, 241);
            this.insurance_txt.Name = "insurance_txt";
            this.insurance_txt.Size = new System.Drawing.Size(181, 20);
            this.insurance_txt.TabIndex = 8;
            // 
            // empname_combobox
            // 
            this.empname_combobox.FormattingEnabled = true;
            this.empname_combobox.Location = new System.Drawing.Point(117, 81);
            this.empname_combobox.Name = "empname_combobox";
            this.empname_combobox.Size = new System.Drawing.Size(181, 21);
            this.empname_combobox.TabIndex = 9;
            this.empname_combobox.SelectedIndexChanged += new System.EventHandler(this.empid_combobox_SelectedIndexChanged);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(192, 280);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 10;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Employee Name";
            // 
            // emp_idtxtbox
            // 
            this.emp_idtxtbox.Location = new System.Drawing.Point(117, 49);
            this.emp_idtxtbox.Name = "emp_idtxtbox";
            this.emp_idtxtbox.ReadOnly = true;
            this.emp_idtxtbox.Size = new System.Drawing.Size(181, 20);
            this.emp_idtxtbox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Employee Last Name";
            // 
            // emplname_txtbox
            // 
            this.emplname_txtbox.Location = new System.Drawing.Point(117, 120);
            this.emplname_txtbox.Name = "emplname_txtbox";
            this.emplname_txtbox.ReadOnly = true;
            this.emplname_txtbox.Size = new System.Drawing.Size(181, 20);
            this.emplname_txtbox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Designation";
            // 
            // designation_txtbox
            // 
            this.designation_txtbox.Location = new System.Drawing.Point(117, 151);
            this.designation_txtbox.Name = "designation_txtbox";
            this.designation_txtbox.ReadOnly = true;
            this.designation_txtbox.Size = new System.Drawing.Size(181, 20);
            this.designation_txtbox.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emplname_txtbox);
            this.groupBox1.Controls.Add(this.designation_txtbox);
            this.groupBox1.Controls.Add(this.emp_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.basic_salary);
            this.groupBox1.Controls.Add(this.basicSalary_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.emp_idtxtbox);
            this.groupBox1.Controls.Add(this.allowance_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Update_button);
            this.groupBox1.Controls.Add(this.insurance_txt);
            this.groupBox1.Controls.Add(this.empname_combobox);
            this.groupBox1.Location = new System.Drawing.Point(32, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 338);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SalaryCredentialAssigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 372);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalaryCredentialAssigner";
            this.Text = "SalaryCredentialAssigner";
            this.Load += new System.EventHandler(this.SalaryCredentialAssigner_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label emp_id;
        private System.Windows.Forms.Label basic_salary;
        private System.Windows.Forms.TextBox basicSalary_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox allowance_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox insurance_txt;
        private System.Windows.Forms.ComboBox empname_combobox;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emp_idtxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emplname_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox designation_txtbox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}