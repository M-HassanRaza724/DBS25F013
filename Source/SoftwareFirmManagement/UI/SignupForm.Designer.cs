namespace SoftwareFirmManagement.UI
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.txtPassword = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.txt_email = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.txtusername = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.txtname = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.btn_signup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_login = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Location = new System.Drawing.Point(43, 232);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.MultiLine = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceHolder = "place holder";
            this.txtPassword.Size = new System.Drawing.Size(342, 49);
            this.txtPassword.Style = "Standalone";
            this.txtPassword.TabIndex = 60;
            this.txtPassword.TextBoxText = "Password";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.Transparent;
            this.txt_email.Location = new System.Drawing.Point(43, 173);
            this.txt_email.Margin = new System.Windows.Forms.Padding(5);
            this.txt_email.MultiLine = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceHolder = "place holder";
            this.txt_email.Size = new System.Drawing.Size(342, 49);
            this.txt_email.Style = "Standalone";
            this.txt_email.TabIndex = 59;
            this.txt_email.TextBoxText = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(432, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.Color.White;
            this.lbl_heading.Location = new System.Drawing.Point(164, 24);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(83, 31);
            this.lbl_heading.TabIndex = 52;
            this.lbl_heading.Text = "Signup";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.Transparent;
            this.txtusername.Location = new System.Drawing.Point(43, 119);
            this.txtusername.Margin = new System.Windows.Forms.Padding(5);
            this.txtusername.MultiLine = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.PlaceHolder = "place holder";
            this.txtusername.Size = new System.Drawing.Size(342, 49);
            this.txtusername.Style = "Standalone";
            this.txtusername.TabIndex = 61;
            this.txtusername.TextBoxText = "Username";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Transparent;
            this.txtname.Location = new System.Drawing.Point(43, 60);
            this.txtname.Margin = new System.Windows.Forms.Padding(5);
            this.txtname.MultiLine = false;
            this.txtname.Name = "txtname";
            this.txtname.PlaceHolder = "place holder";
            this.txtname.Size = new System.Drawing.Size(342, 49);
            this.txtname.Style = "Standalone";
            this.txtname.TabIndex = 62;
            this.txtname.TextBoxText = "Name";
            // 
            // btn_signup
            // 
            this.btn_signup.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_signup.Location = new System.Drawing.Point(123, 290);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(4);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(146, 49);
            this.btn_signup.TabIndex = 64;
            this.btn_signup.Values.Text = "Signup";
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_login.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_login.Location = new System.Drawing.Point(63, 347);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(284, 31);
            this.lbl_login.TabIndex = 65;
            this.lbl_login.Values.Text = "Already have an account? Login";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_heading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxWithPlaceHolder txtPassword;
        private TextBoxWithPlaceHolder txt_email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_heading;
        private TextBoxWithPlaceHolder txtusername;
        private TextBoxWithPlaceHolder txtname;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_signup;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_login;
    }
}