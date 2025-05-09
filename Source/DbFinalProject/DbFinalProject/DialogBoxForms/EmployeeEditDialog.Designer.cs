namespace DbFinalProject.DialogBoxForms
{
    partial class EmployeeEditDialog
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
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.nmudBonus = new System.Windows.Forms.NumericUpDown();
            this.nmudSalary = new System.Windows.Forms.NumericUpDown();
            this.dtmPayDate = new System.Windows.Forms.DateTimePicker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbUsernameToUpdate = new System.Windows.Forms.ComboBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsernameToUpdate = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nmudBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSalary)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpMain.SetColumnSpan(this.btnUpdateEmployee, 2);
            this.btnUpdateEmployee.Location = new System.Drawing.Point(316, 403);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(167, 35);
            this.btnUpdateEmployee.TabIndex = 16;
            this.btnUpdateEmployee.Text = "Update employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // mtbPhone
            // 
            this.mtbPhone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtbPhone.Location = new System.Drawing.Point(497, 221);
            this.mtbPhone.Mask = "(+92) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(206, 26);
            this.mtbPhone.TabIndex = 15;
            // 
            // nmudBonus
            // 
            this.nmudBonus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nmudBonus.Location = new System.Drawing.Point(496, 371);
            this.nmudBonus.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmudBonus.Name = "nmudBonus";
            this.nmudBonus.Size = new System.Drawing.Size(207, 26);
            this.nmudBonus.TabIndex = 14;
            // 
            // nmudSalary
            // 
            this.nmudSalary.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nmudSalary.Location = new System.Drawing.Point(496, 321);
            this.nmudSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmudSalary.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmudSalary.Name = "nmudSalary";
            this.nmudSalary.Size = new System.Drawing.Size(207, 26);
            this.nmudSalary.TabIndex = 13;
            this.nmudSalary.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // dtmPayDate
            // 
            this.dtmPayDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtmPayDate.Location = new System.Drawing.Point(500, 271);
            this.dtmPayDate.Name = "dtmPayDate";
            this.dtmPayDate.Size = new System.Drawing.Size(200, 26);
            this.dtmPayDate.TabIndex = 12;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbName.Location = new System.Drawing.Point(498, 171);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(203, 26);
            this.tbName.TabIndex = 10;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbPassword.Location = new System.Drawing.Point(498, 121);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(203, 26);
            this.tbPassword.TabIndex = 9;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbEmail.Location = new System.Drawing.Point(498, 71);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(203, 26);
            this.tbEmail.TabIndex = 0;
            // 
            // cbUsernameToUpdate
            // 
            this.cbUsernameToUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbUsernameToUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsernameToUpdate.FormattingEnabled = true;
            this.cbUsernameToUpdate.Location = new System.Drawing.Point(500, 19);
            this.cbUsernameToUpdate.Name = "cbUsernameToUpdate";
            this.cbUsernameToUpdate.Size = new System.Drawing.Size(200, 28);
            this.cbUsernameToUpdate.TabIndex = 8;
            // 
            // lblBonus
            // 
            this.lblBonus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblBonus.AutoSize = true;
            this.lblBonus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblBonus.Location = new System.Drawing.Point(172, 380);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(55, 20);
            this.lblBonus.TabIndex = 7;
            this.lblBonus.Text = "Bonus";
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSalary.Location = new System.Drawing.Point(173, 330);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(53, 20);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Salary";
            // 
            // lblPayDate
            // 
            this.lblPayDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblPayDate.Location = new System.Drawing.Point(164, 280);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(71, 20);
            this.lblPayDate.TabIndex = 5;
            this.lblPayDate.Text = "Pay date";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblPhone.Location = new System.Drawing.Point(172, 230);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblName.Location = new System.Drawing.Point(174, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblPassword.Location = new System.Drawing.Point(161, 130);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblEmail.Location = new System.Drawing.Point(176, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblUsernameToUpdate
            // 
            this.lblUsernameToUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUsernameToUpdate.AutoSize = true;
            this.lblUsernameToUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblUsernameToUpdate.Location = new System.Drawing.Point(124, 30);
            this.lblUsernameToUpdate.Name = "lblUsernameToUpdate";
            this.lblUsernameToUpdate.Size = new System.Drawing.Size(151, 20);
            this.lblUsernameToUpdate.TabIndex = 0;
            this.lblUsernameToUpdate.Text = "Employee to update";
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.lblUsernameToUpdate, 0, 0);
            this.tlpMain.Controls.Add(this.lblEmail, 0, 1);
            this.tlpMain.Controls.Add(this.lblPassword, 0, 2);
            this.tlpMain.Controls.Add(this.lblName, 0, 3);
            this.tlpMain.Controls.Add(this.lblPhone, 0, 4);
            this.tlpMain.Controls.Add(this.lblPayDate, 0, 5);
            this.tlpMain.Controls.Add(this.lblSalary, 0, 6);
            this.tlpMain.Controls.Add(this.lblBonus, 0, 7);
            this.tlpMain.Controls.Add(this.cbUsernameToUpdate, 1, 0);
            this.tlpMain.Controls.Add(this.tbEmail, 1, 1);
            this.tlpMain.Controls.Add(this.tbPassword, 1, 2);
            this.tlpMain.Controls.Add(this.tbName, 1, 3);
            this.tlpMain.Controls.Add(this.dtmPayDate, 1, 5);
            this.tlpMain.Controls.Add(this.nmudSalary, 1, 6);
            this.tlpMain.Controls.Add(this.nmudBonus, 1, 7);
            this.tlpMain.Controls.Add(this.mtbPhone, 1, 4);
            this.tlpMain.Controls.Add(this.btnUpdateEmployee, 0, 8);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 9;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // EmployeeEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeeEditDialog";
            this.Text = "EmployeeEditDialog";
            ((System.ComponentModel.ISupportInitialize)(this.nmudBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSalary)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblUsernameToUpdate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPayDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.ComboBox cbUsernameToUpdate;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtmPayDate;
        private System.Windows.Forms.NumericUpDown nmudSalary;
        private System.Windows.Forms.NumericUpDown nmudBonus;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
    }
}