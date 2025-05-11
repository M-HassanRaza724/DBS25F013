namespace SoftwareFirmManagement.UI
{
    partial class LoginForm
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
            this.lbl_heading1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_heading2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_heading3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Email = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Password = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_email = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.txt_Password = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.btn_login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_forgotpassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_account = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_signup = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl_loginpic = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_loginpic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_heading1
            // 
            this.lbl_heading1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_heading1.Location = new System.Drawing.Point(44, 61);
            this.lbl_heading1.Name = "lbl_heading1";
            this.lbl_heading1.Size = new System.Drawing.Size(254, 31);
            this.lbl_heading1.TabIndex = 0;
            this.lbl_heading1.Values.Text = "Software Firm Management";
            // 
            // lbl_heading2
            // 
            this.lbl_heading2.Location = new System.Drawing.Point(44, 98);
            this.lbl_heading2.Name = "lbl_heading2";
            this.lbl_heading2.Size = new System.Drawing.Size(321, 28);
            this.lbl_heading2.TabIndex = 1;
            this.lbl_heading2.Values.Text = "Digital solution for your digital probleems";
            // 
            // lbl_heading3
            // 
            this.lbl_heading3.Location = new System.Drawing.Point(44, 135);
            this.lbl_heading3.Name = "lbl_heading3";
            this.lbl_heading3.Size = new System.Drawing.Size(203, 28);
            this.lbl_heading3.TabIndex = 2;
            this.lbl_heading3.Values.Text = "Synchronization you need";
            // 
            // lbl_Email
            // 
            this.lbl_Email.Location = new System.Drawing.Point(56, 191);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(98, 28);
            this.lbl_Email.TabIndex = 3;
            this.lbl_Email.Values.Text = "Enter Email:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.Location = new System.Drawing.Point(56, 268);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(128, 28);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Values.Text = "Enter Password:";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.Transparent;
            this.txt_email.Location = new System.Drawing.Point(42, 211);
            this.txt_email.Margin = new System.Windows.Forms.Padding(5);
            this.txt_email.MultiLine = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceHolder = "Email";
            this.txt_email.Size = new System.Drawing.Size(379, 49);
            this.txt_email.Style = "Standalone";
            this.txt_email.TabIndex = 42;
            this.txt_email.TextBoxText = "Email";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Transparent;
            this.txt_Password.Location = new System.Drawing.Point(42, 289);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Password.MultiLine = false;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceHolder = "Password";
            this.txt_Password.Size = new System.Drawing.Size(379, 49);
            this.txt_Password.Style = "Standalone";
            this.txt_Password.TabIndex = 43;
            this.txt_Password.TextBoxText = "Password";
            // 
            // btn_login
            // 
            this.btn_login.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Location = new System.Drawing.Point(110, 370);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(217, 60);
            this.btn_login.TabIndex = 46;
            this.btn_login.Values.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_forgotpassword
            // 
            this.lbl_forgotpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_forgotpassword.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom2;
            this.lbl_forgotpassword.Location = new System.Drawing.Point(283, 335);
            this.lbl_forgotpassword.Name = "lbl_forgotpassword";
            this.lbl_forgotpassword.Size = new System.Drawing.Size(138, 28);
            this.lbl_forgotpassword.TabIndex = 47;
            this.lbl_forgotpassword.Values.Text = "ForgotPassword?";
            this.lbl_forgotpassword.Click += new System.EventHandler(this.lbl_forgotpassword_Click);
            // 
            // lbl_account
            // 
            this.lbl_account.Location = new System.Drawing.Point(88, 437);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(185, 28);
            this.lbl_account.TabIndex = 48;
            this.lbl_account.Values.Text = "Don\'t have an account?";
            // 
            // lbl_signup
            // 
            this.lbl_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_signup.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_signup.Location = new System.Drawing.Point(279, 434);
            this.lbl_signup.Name = "lbl_signup";
            this.lbl_signup.Size = new System.Drawing.Size(69, 31);
            this.lbl_signup.TabIndex = 49;
            this.lbl_signup.Values.Text = "Create";
            this.lbl_signup.Click += new System.EventHandler(this.lbl_signup_Click);
            // 
            // pnl_loginpic
            // 
            this.pnl_loginpic.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_loginpic.Location = new System.Drawing.Point(478, 0);
            this.pnl_loginpic.Name = "pnl_loginpic";
            this.pnl_loginpic.Size = new System.Drawing.Size(416, 559);
            this.pnl_loginpic.TabIndex = 50;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(894, 559);
            this.Controls.Add(this.pnl_loginpic);
            this.Controls.Add(this.lbl_signup);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.lbl_forgotpassword);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_heading3);
            this.Controls.Add(this.lbl_heading2);
            this.Controls.Add(this.lbl_heading1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pnl_loginpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_heading1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_heading2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_heading3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Email;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Password;
        private TextBoxWithPlaceHolder txt_email;
        private TextBoxWithPlaceHolder txt_Password;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_login;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_forgotpassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_account;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_signup;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnl_loginpic;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}