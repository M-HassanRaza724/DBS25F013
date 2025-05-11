namespace DbFinalProject.DialogBoxForms
{
    partial class EmployeeAddDialog
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbDesignation = new System.Windows.Forms.ComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.nmudSalary = new System.Windows.Forms.NumericUpDown();
            this.nmudBonus = new System.Windows.Forms.NumericUpDown();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.dtmPayDate = new System.Windows.Forms.DateTimePicker();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.lblUsername, 0, 0);
            this.tlpMain.Controls.Add(this.lblPassword, 0, 1);
            this.tlpMain.Controls.Add(this.lblEmail, 0, 2);
            this.tlpMain.Controls.Add(this.lblName, 0, 3);
            this.tlpMain.Controls.Add(this.lblPhone, 0, 4);
            this.tlpMain.Controls.Add(this.lblDesignation, 0, 5);
            this.tlpMain.Controls.Add(this.tbUsername, 1, 0);
            this.tlpMain.Controls.Add(this.tbPassword, 1, 1);
            this.tlpMain.Controls.Add(this.tbEmail, 1, 2);
            this.tlpMain.Controls.Add(this.tbName, 1, 3);
            this.tlpMain.Controls.Add(this.cbDesignation, 1, 5);
            this.tlpMain.Controls.Add(this.lblSalary, 0, 6);
            this.tlpMain.Controls.Add(this.lblBonus, 0, 7);
            this.tlpMain.Controls.Add(this.nmudSalary, 1, 6);
            this.tlpMain.Controls.Add(this.nmudBonus, 1, 7);
            this.tlpMain.Controls.Add(this.btnAddEmployee, 0, 9);
            this.tlpMain.Controls.Add(this.lblPayDate, 0, 8);
            this.tlpMain.Controls.Add(this.dtmPayDate, 1, 8);
            this.tlpMain.Controls.Add(this.mtbPhone, 1, 4);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 10;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblUsername.Location = new System.Drawing.Point(158, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblPassword.Location = new System.Drawing.Point(161, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblEmail.Location = new System.Drawing.Point(176, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblName.Location = new System.Drawing.Point(174, 160);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblPhone.Location = new System.Drawing.Point(172, 205);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // lblDesignation
            // 
            this.lblDesignation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDesignation.Location = new System.Drawing.Point(153, 250);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(94, 20);
            this.lblDesignation.TabIndex = 5;
            this.lblDesignation.Text = "Designation";
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbUsername.Location = new System.Drawing.Point(515, 16);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(170, 26);
            this.tbUsername.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbPassword.Location = new System.Drawing.Point(515, 61);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(170, 26);
            this.tbPassword.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbEmail.Location = new System.Drawing.Point(515, 106);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(170, 26);
            this.tbEmail.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbName.Location = new System.Drawing.Point(515, 151);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 26);
            this.tbName.TabIndex = 10;
            // 
            // cbDesignation
            // 
            this.cbDesignation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesignation.FormattingEnabled = true;
            this.cbDesignation.Location = new System.Drawing.Point(513, 239);
            this.cbDesignation.Name = "cbDesignation";
            this.cbDesignation.Size = new System.Drawing.Size(173, 28);
            this.cbDesignation.TabIndex = 12;
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSalary.Location = new System.Drawing.Point(173, 295);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(53, 20);
            this.lblSalary.TabIndex = 13;
            this.lblSalary.Text = "Salary";
            // 
            // lblBonus
            // 
            this.lblBonus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblBonus.AutoSize = true;
            this.lblBonus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblBonus.Location = new System.Drawing.Point(172, 340);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(55, 20);
            this.lblBonus.TabIndex = 14;
            this.lblBonus.Text = "Bonus";
            // 
            // nmudSalary
            // 
            this.nmudSalary.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nmudSalary.Location = new System.Drawing.Point(512, 286);
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
            this.nmudSalary.Size = new System.Drawing.Size(175, 26);
            this.nmudSalary.TabIndex = 15;
            this.nmudSalary.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nmudBonus
            // 
            this.nmudBonus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nmudBonus.Location = new System.Drawing.Point(511, 331);
            this.nmudBonus.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmudBonus.Name = "nmudBonus";
            this.nmudBonus.Size = new System.Drawing.Size(177, 26);
            this.nmudBonus.TabIndex = 16;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpMain.SetColumnSpan(this.btnAddEmployee, 2);
            this.btnAddEmployee.Location = new System.Drawing.Point(334, 408);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(132, 31);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lblPayDate
            // 
            this.lblPayDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblPayDate.Location = new System.Drawing.Point(164, 385);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(71, 20);
            this.lblPayDate.TabIndex = 17;
            this.lblPayDate.Text = "Pay date";
            // 
            // dtmPayDate
            // 
            this.dtmPayDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtmPayDate.Location = new System.Drawing.Point(511, 376);
            this.dtmPayDate.Name = "dtmPayDate";
            this.dtmPayDate.Size = new System.Drawing.Size(178, 26);
            this.dtmPayDate.TabIndex = 18;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtbPhone.Location = new System.Drawing.Point(512, 196);
            this.mtbPhone.Mask = "(+92) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(175, 26);
            this.mtbPhone.TabIndex = 19;
            // 
            // EmployeeAddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeeAddDialog";
            this.Text = "EmployeeAddDialog";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudBonus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbDesignation;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.NumericUpDown nmudSalary;
        private System.Windows.Forms.NumericUpDown nmudBonus;
        private System.Windows.Forms.Label lblPayDate;
        private System.Windows.Forms.DateTimePicker dtmPayDate;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
    }
}