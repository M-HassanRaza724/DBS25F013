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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txt_Password = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.txt_email = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.lbl_Password = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Email = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_name = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.txt_username = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.lbl_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_username = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel1.Location = new System.Drawing.Point(470, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(330, 516);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Transparent;
            this.txt_Password.Location = new System.Drawing.Point(43, 281);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Password.MultiLine = false;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceHolder = "Password";
            this.txt_Password.Size = new System.Drawing.Size(379, 49);
            this.txt_Password.Style = "Standalone";
            this.txt_Password.TabIndex = 47;
            this.txt_Password.TextBoxText = "Password";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.Transparent;
            this.txt_email.Location = new System.Drawing.Point(43, 203);
            this.txt_email.Margin = new System.Windows.Forms.Padding(5);
            this.txt_email.MultiLine = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceHolder = "Email";
            this.txt_email.Size = new System.Drawing.Size(379, 49);
            this.txt_email.Style = "Standalone";
            this.txt_email.TabIndex = 46;
            this.txt_email.TextBoxText = "Email";
            // 
            // lbl_Password
            // 
            this.lbl_Password.Location = new System.Drawing.Point(57, 260);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(128, 28);
            this.lbl_Password.TabIndex = 45;
            this.lbl_Password.Values.Text = "Enter Password:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.Location = new System.Drawing.Point(57, 183);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(98, 28);
            this.lbl_Email.TabIndex = 44;
            this.lbl_Email.Values.Text = "Enter Email:";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_name.Location = new System.Drawing.Point(43, 138);
            this.txt_name.Margin = new System.Windows.Forms.Padding(5);
            this.txt_name.MultiLine = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.PlaceHolder = "Name";
            this.txt_name.Size = new System.Drawing.Size(379, 49);
            this.txt_name.Style = "Standalone";
            this.txt_name.TabIndex = 51;
            this.txt_name.TextBoxText = "Name";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.Location = new System.Drawing.Point(43, 60);
            this.txt_username.Margin = new System.Windows.Forms.Padding(5);
            this.txt_username.MultiLine = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.PlaceHolder = "Email";
            this.txt_username.Size = new System.Drawing.Size(379, 49);
            this.txt_username.Style = "Standalone";
            this.txt_username.TabIndex = 50;
            this.txt_username.TextBoxText = "Username";
            // 
            // lbl_name
            // 
            this.lbl_name.Location = new System.Drawing.Point(57, 117);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(103, 28);
            this.lbl_name.TabIndex = 49;
            this.lbl_name.Values.Text = "Enter Name:";
            // 
            // lbl_username
            // 
            this.lbl_username.Location = new System.Drawing.Point(57, 40);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(133, 28);
            this.lbl_username.TabIndex = 48;
            this.lbl_username.Values.Text = "Enter Username:";
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private TextBoxWithPlaceHolder txt_Password;
        private TextBoxWithPlaceHolder txt_email;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Password;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Email;
        private TextBoxWithPlaceHolder txt_name;
        private TextBoxWithPlaceHolder txt_username;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_username;
    }
}