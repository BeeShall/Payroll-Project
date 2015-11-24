namespace Payroll
{
    partial class EditEmployeeDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.dob_pick = new System.Windows.Forms.DateTimePicker();
            this.lname_txtbox = new System.Windows.Forms.TextBox();
            this.mname_txtbox = new System.Windows.Forms.TextBox();
            this.inactive = new System.Windows.Forms.RadioButton();
            this.active = new System.Windows.Forms.RadioButton();
            this.work_state = new System.Windows.Forms.Label();
            this.qualification_txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contact_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.designation_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.empid_txtbox = new System.Windows.Forms.TextBox();
            this.empname_combobox = new System.Windows.Forms.ComboBox();
            this.leave = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(167, 318);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 3;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(248, 318);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(333, 318);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 6;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // dob_pick
            // 
            this.dob_pick.Location = new System.Drawing.Point(111, 166);
            this.dob_pick.Name = "dob_pick";
            this.dob_pick.Size = new System.Drawing.Size(247, 20);
            this.dob_pick.TabIndex = 33;
            // 
            // lname_txtbox
            // 
            this.lname_txtbox.Location = new System.Drawing.Point(276, 53);
            this.lname_txtbox.Name = "lname_txtbox";
            this.lname_txtbox.ReadOnly = true;
            this.lname_txtbox.Size = new System.Drawing.Size(80, 20);
            this.lname_txtbox.TabIndex = 28;
            // 
            // mname_txtbox
            // 
            this.mname_txtbox.Location = new System.Drawing.Point(217, 53);
            this.mname_txtbox.Name = "mname_txtbox";
            this.mname_txtbox.ReadOnly = true;
            this.mname_txtbox.Size = new System.Drawing.Size(53, 20);
            this.mname_txtbox.TabIndex = 29;
            // 
            // inactive
            // 
            this.inactive.AutoSize = true;
            this.inactive.Location = new System.Drawing.Point(114, 245);
            this.inactive.Name = "inactive";
            this.inactive.Size = new System.Drawing.Size(63, 17);
            this.inactive.TabIndex = 36;
            this.inactive.TabStop = true;
            this.inactive.Text = "Inactive";
            this.inactive.UseVisualStyleBackColor = true;
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Location = new System.Drawing.Point(114, 222);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(55, 17);
            this.active.TabIndex = 35;
            this.active.TabStop = true;
            this.active.Text = "Active";
            this.active.UseVisualStyleBackColor = true;
            // 
            // work_state
            // 
            this.work_state.AutoSize = true;
            this.work_state.Location = new System.Drawing.Point(16, 222);
            this.work_state.Name = "work_state";
            this.work_state.Size = new System.Drawing.Size(75, 13);
            this.work_state.TabIndex = 43;
            this.work_state.Text = "Working State";
            // 
            // qualification_txtbox
            // 
            this.qualification_txtbox.Location = new System.Drawing.Point(111, 195);
            this.qualification_txtbox.Name = "qualification_txtbox";
            this.qualification_txtbox.Size = new System.Drawing.Size(247, 20);
            this.qualification_txtbox.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Qualification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Date Of Birth";
            // 
            // contact_txtbox
            // 
            this.contact_txtbox.Location = new System.Drawing.Point(111, 140);
            this.contact_txtbox.Name = "contact_txtbox";
            this.contact_txtbox.Size = new System.Drawing.Size(247, 20);
            this.contact_txtbox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Contact Number";
            // 
            // designation_txtbox
            // 
            this.designation_txtbox.Location = new System.Drawing.Point(114, 112);
            this.designation_txtbox.Name = "designation_txtbox";
            this.designation_txtbox.Size = new System.Drawing.Size(244, 20);
            this.designation_txtbox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Designation";
            // 
            // address_txtbox
            // 
            this.address_txtbox.Location = new System.Drawing.Point(114, 86);
            this.address_txtbox.Name = "address_txtbox";
            this.address_txtbox.Size = new System.Drawing.Size(244, 20);
            this.address_txtbox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name";
            // 
            // empid_txtbox
            // 
            this.empid_txtbox.Location = new System.Drawing.Point(114, 22);
            this.empid_txtbox.Name = "empid_txtbox";
            this.empid_txtbox.ReadOnly = true;
            this.empid_txtbox.Size = new System.Drawing.Size(242, 20);
            this.empid_txtbox.TabIndex = 1;
            // 
            // empname_combobox
            // 
            this.empname_combobox.FormattingEnabled = true;
            this.empname_combobox.Location = new System.Drawing.Point(111, 53);
            this.empname_combobox.Name = "empname_combobox";
            this.empname_combobox.Size = new System.Drawing.Size(100, 21);
            this.empname_combobox.TabIndex = 44;
            this.empname_combobox.SelectedIndexChanged += new System.EventHandler(this.empname_combobox_SelectedIndexChanged);
            // 
            // leave
            // 
            this.leave.AutoSize = true;
            this.leave.Location = new System.Drawing.Point(114, 268);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(43, 17);
            this.leave.TabIndex = 45;
            this.leave.TabStop = true;
            this.leave.Text = "Left";
            this.leave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.empid_txtbox);
            this.groupBox1.Controls.Add(this.leave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.empname_combobox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dob_pick);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lname_txtbox);
            this.groupBox1.Controls.Add(this.address_txtbox);
            this.groupBox1.Controls.Add(this.mname_txtbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.inactive);
            this.groupBox1.Controls.Add(this.designation_txtbox);
            this.groupBox1.Controls.Add(this.active);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.work_state);
            this.groupBox1.Controls.Add(this.contact_txtbox);
            this.groupBox1.Controls.Add(this.qualification_txtbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 300);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // EditEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(432, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Name = "EditEmployeeDetails";
            this.Text = "EditEmployeeDetails";
            this.Load += new System.EventHandler(this.EditEmployeeDetails_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditEmployeeDetails_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.DateTimePicker dob_pick;
        private System.Windows.Forms.TextBox lname_txtbox;
        private System.Windows.Forms.TextBox mname_txtbox;
        private System.Windows.Forms.RadioButton inactive;
        private System.Windows.Forms.RadioButton active;
        private System.Windows.Forms.Label work_state;
        private System.Windows.Forms.TextBox qualification_txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contact_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox designation_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empid_txtbox;
        private System.Windows.Forms.ComboBox empname_combobox;
        private System.Windows.Forms.RadioButton leave;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}