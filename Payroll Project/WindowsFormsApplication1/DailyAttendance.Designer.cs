namespace Payroll
{
    partial class DailyAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyAttendance));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.empfname_combobox = new System.Windows.Forms.ComboBox();
            this.empid_txtbox = new System.Windows.Forms.TextBox();
            this.designation_txtbox = new System.Windows.Forms.TextBox();
            this.attendance_combobox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.done_button = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.emplname_txtbox = new System.Windows.Forms.TextBox();
            this.Notice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(486, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Id";
            // 
            // empfname_combobox
            // 
            this.empfname_combobox.FormattingEnabled = true;
            this.empfname_combobox.Location = new System.Drawing.Point(201, 21);
            this.empfname_combobox.Name = "empfname_combobox";
            this.empfname_combobox.Size = new System.Drawing.Size(118, 21);
            this.empfname_combobox.TabIndex = 3;
            this.empfname_combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // empid_txtbox
            // 
            this.empid_txtbox.Location = new System.Drawing.Point(201, 64);
            this.empid_txtbox.Name = "empid_txtbox";
            this.empid_txtbox.ReadOnly = true;
            this.empid_txtbox.Size = new System.Drawing.Size(200, 20);
            this.empid_txtbox.TabIndex = 5;
            // 
            // designation_txtbox
            // 
            this.designation_txtbox.Location = new System.Drawing.Point(201, 108);
            this.designation_txtbox.Name = "designation_txtbox";
            this.designation_txtbox.ReadOnly = true;
            this.designation_txtbox.Size = new System.Drawing.Size(200, 20);
            this.designation_txtbox.TabIndex = 7;
            // 
            // attendance_combobox
            // 
            this.attendance_combobox.FormattingEnabled = true;
            this.attendance_combobox.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.attendance_combobox.Location = new System.Drawing.Point(201, 147);
            this.attendance_combobox.Name = "attendance_combobox";
            this.attendance_combobox.Size = new System.Drawing.Size(200, 21);
            this.attendance_combobox.TabIndex = 9;
            this.attendance_combobox.SelectedIndexChanged += new System.EventHandler(this.attendance_combobox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Attendance";
            // 
            // done_button
            // 
            this.done_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done_button.Location = new System.Drawing.Point(704, 493);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(119, 43);
            this.done_button.TabIndex = 13;
            this.done_button.Text = "Done";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(878, 221);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // emplname_txtbox
            // 
            this.emplname_txtbox.Location = new System.Drawing.Point(332, 22);
            this.emplname_txtbox.Name = "emplname_txtbox";
            this.emplname_txtbox.ReadOnly = true;
            this.emplname_txtbox.Size = new System.Drawing.Size(90, 20);
            this.emplname_txtbox.TabIndex = 15;
            // 
            // Notice
            // 
            this.Notice.AutoSize = true;
            this.Notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Notice.Location = new System.Drawing.Point(302, 493);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(0, 24);
            this.Notice.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.emplname_txtbox);
            this.groupBox1.Controls.Add(this.empfname_combobox);
            this.groupBox1.Controls.Add(this.empid_txtbox);
            this.groupBox1.Controls.Add(this.designation_txtbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.attendance_combobox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(278, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 204);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1240, 73);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 34);
            this.label5.TabIndex = 20;
            this.label5.Text = "Daily Attendance";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DailyAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Notice);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "DailyAttendance";
            this.Size = new System.Drawing.Size(1151, 679);
            this.Load += new System.EventHandler(this.DailyAttendance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox empfname_combobox;
        private System.Windows.Forms.TextBox empid_txtbox;
        private System.Windows.Forms.TextBox designation_txtbox;
        private System.Windows.Forms.ComboBox attendance_combobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox emplname_txtbox;
        private System.Windows.Forms.Label Notice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}
