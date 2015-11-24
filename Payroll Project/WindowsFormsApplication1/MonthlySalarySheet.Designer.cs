namespace Payroll
{
    partial class MonthlySalarySheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlySalarySheet));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.show_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.Label();
            this.selectYear_combobox = new System.Windows.Forms.ComboBox();
            this.selectMonth_combobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 340);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(650, 294);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(75, 23);
            this.show_button.TabIndex = 16;
            this.show_button.Text = "Show";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Year";
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Location = new System.Drawing.Point(344, 237);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(37, 13);
            this.Month.TabIndex = 14;
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
            this.selectYear_combobox.Location = new System.Drawing.Point(598, 234);
            this.selectYear_combobox.Name = "selectYear_combobox";
            this.selectYear_combobox.Size = new System.Drawing.Size(121, 21);
            this.selectYear_combobox.TabIndex = 13;
            this.selectYear_combobox.Text = "--Select One--";
            // 
            // selectMonth_combobox
            // 
            this.selectMonth_combobox.FormattingEnabled = true;
            this.selectMonth_combobox.Location = new System.Drawing.Point(399, 234);
            this.selectMonth_combobox.Name = "selectMonth_combobox";
            this.selectMonth_combobox.Size = new System.Drawing.Size(121, 21);
            this.selectMonth_combobox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select a date:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(849, 162);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1130, 73);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(528, 34);
            this.label5.TabIndex = 22;
            this.label5.Text = "Monthly Salary Sheet";
            // 
            // MonthlySalarySheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.selectYear_combobox);
            this.Controls.Add(this.selectMonth_combobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MonthlySalarySheet";
            this.Size = new System.Drawing.Size(1151, 679);
            this.Load += new System.EventHandler(this.MonthlySalarySheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Month;
        private System.Windows.Forms.ComboBox selectYear_combobox;
        private System.Windows.Forms.ComboBox selectMonth_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}
