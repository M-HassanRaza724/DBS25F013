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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbl_heading2 = new System.Windows.Forms.Label();
            this.lbl_heading3 = new System.Windows.Forms.Label();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.btn_login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Signup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_forgetpassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_email = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.txtPassword = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_heading2
            // 
            this.lbl_heading2.AutoSize = true;
            this.lbl_heading2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading2.ForeColor = System.Drawing.Color.White;
            this.lbl_heading2.Location = new System.Drawing.Point(32, 144);
            this.lbl_heading2.Name = "lbl_heading2";
            this.lbl_heading2.Size = new System.Drawing.Size(291, 21);
            this.lbl_heading2.TabIndex = 18;
            this.lbl_heading2.Text = "Digital solution for your digital problems";
            // 
            // lbl_heading3
            // 
            this.lbl_heading3.AutoSize = true;
            this.lbl_heading3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading3.ForeColor = System.Drawing.Color.White;
            this.lbl_heading3.Location = new System.Drawing.Point(33, 165);
            this.lbl_heading3.Name = "lbl_heading3";
            this.lbl_heading3.Size = new System.Drawing.Size(189, 21);
            this.lbl_heading3.TabIndex = 20;
            this.lbl_heading3.Text = "Synchronization you need";
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.Color.White;
            this.lbl_heading.Location = new System.Drawing.Point(31, 90);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(305, 31);
            this.lbl_heading.TabIndex = 17;
            this.lbl_heading.Text = "Software Firm Management";
            // 
            // btn_login
            // 
            this.btn_login.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Location = new System.Drawing.Point(37, 351);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(146, 49);
            this.btn_login.TabIndex = 47;
            this.btn_login.Values.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_Signup
            // 
            this.btn_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Signup.Location = new System.Drawing.Point(233, 351);
            this.btn_Signup.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.Size = new System.Drawing.Size(146, 49);
            this.btn_Signup.TabIndex = 48;
            this.btn_Signup.Values.Text = "Signup";
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // lbl_forgetpassword
            // 
            this.lbl_forgetpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_forgetpassword.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_forgetpassword.Location = new System.Drawing.Point(219, 312);
            this.lbl_forgetpassword.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_forgetpassword.Name = "lbl_forgetpassword";
            this.lbl_forgetpassword.Size = new System.Drawing.Size(166, 31);
            this.lbl_forgetpassword.TabIndex = 49;
            this.lbl_forgetpassword.Values.Text = "Forgot Password?";
            this.lbl_forgetpassword.Click += new System.EventHandler(this.lbl_forgetpassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(432, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.Transparent;
            this.txt_email.Location = new System.Drawing.Point(37, 191);
            this.txt_email.Margin = new System.Windows.Forms.Padding(5);
            this.txt_email.MultiLine = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceHolder = "place holder";
            this.txt_email.Size = new System.Drawing.Size(342, 49);
            this.txt_email.Style = "Standalone";
            this.txt_email.TabIndex = 50;
            this.txt_email.TextBoxText = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Location = new System.Drawing.Point(43, 250);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.MultiLine = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceHolder = "place holder";
            this.txtPassword.Size = new System.Drawing.Size(342, 49);
            this.txtPassword.Style = "Standalone";
            this.txtPassword.TabIndex = 51;
            this.txtPassword.TextBoxText = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(875, 521);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_forgetpassword);
            this.Controls.Add(this.btn_Signup);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_heading3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_heading2);
            this.Controls.Add(this.lbl_heading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_heading2;
        private System.Windows.Forms.Label lbl_heading3;
        private System.Windows.Forms.Label lbl_heading;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_login;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Signup;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_forgetpassword;
        private TextBoxWithPlaceHolder txt_email;
        private TextBoxWithPlaceHolder txtPassword;
    }
}