namespace Payroll
{
    partial class ChangePassword
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
            this.old_password = new System.Windows.Forms.Label();
            this.oldpassword_txt = new System.Windows.Forms.TextBox();
            this.change_btn = new System.Windows.Forms.Button();
            this.new_password = new System.Windows.Forms.Label();
            this.newpassword_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmpassword_txt = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // old_password
            // 
            this.old_password.AutoSize = true;
            this.old_password.Location = new System.Drawing.Point(15, 16);
            this.old_password.Name = "old_password";
            this.old_password.Size = new System.Drawing.Size(100, 13);
            this.old_password.TabIndex = 0;
            this.old_password.Text = "Enter Old Password";
            // 
            // oldpassword_txt
            // 
            this.oldpassword_txt.Location = new System.Drawing.Point(131, 13);
            this.oldpassword_txt.Name = "oldpassword_txt";
            this.oldpassword_txt.PasswordChar = '*';
            this.oldpassword_txt.Size = new System.Drawing.Size(132, 20);
            this.oldpassword_txt.TabIndex = 1;
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(111, 132);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(75, 23);
            this.change_btn.TabIndex = 2;
            this.change_btn.Text = "Change";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // new_password
            // 
            this.new_password.AutoSize = true;
            this.new_password.Location = new System.Drawing.Point(15, 55);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(106, 13);
            this.new_password.TabIndex = 3;
            this.new_password.Text = "Enter New Password";
            // 
            // newpassword_txt
            // 
            this.newpassword_txt.Location = new System.Drawing.Point(131, 52);
            this.newpassword_txt.Name = "newpassword_txt";
            this.newpassword_txt.PasswordChar = '*';
            this.newpassword_txt.Size = new System.Drawing.Size(132, 20);
            this.newpassword_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirm New Password";
            // 
            // confirmpassword_txt
            // 
            this.confirmpassword_txt.Location = new System.Drawing.Point(131, 85);
            this.confirmpassword_txt.Name = "confirmpassword_txt";
            this.confirmpassword_txt.PasswordChar = '*';
            this.confirmpassword_txt.Size = new System.Drawing.Size(132, 20);
            this.confirmpassword_txt.TabIndex = 6;
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(192, 132);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.old_password);
            this.groupBox1.Controls.Add(this.oldpassword_txt);
            this.groupBox1.Controls.Add(this.confirmpassword_txt);
            this.groupBox1.Controls.Add(this.new_password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newpassword_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // ChangePassword
            // 
            this.AcceptButton = this.change_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(311, 169);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.change_btn);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label old_password;
        private System.Windows.Forms.TextBox oldpassword_txt;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Label new_password;
        private System.Windows.Forms.TextBox newpassword_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmpassword_txt;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}