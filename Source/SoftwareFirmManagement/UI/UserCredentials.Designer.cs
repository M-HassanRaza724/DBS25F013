namespace SoftwareFirmManagement.UI
{
    partial class UserCredentials
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
            this.lbl_username = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_email = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_password = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_email = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.txt_password = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.txt_username = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_username.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_username.Location = new System.Drawing.Point(3, -1);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(82, 26);
            this.lbl_username.TabIndex = 24;
            this.lbl_username.Values.Text = "Username";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_email.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_email.Location = new System.Drawing.Point(3, 65);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(50, 26);
            this.lbl_email.TabIndex = 25;
            this.lbl_email.Values.Text = "Email";
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_password.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_password.Location = new System.Drawing.Point(3, 131);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(78, 26);
            this.lbl_password.TabIndex = 26;
            this.lbl_password.Values.Text = "Password";
            this.lbl_password.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_password_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 196);
            this.panel1.TabIndex = 27;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.BackColor = System.Drawing.Color.Transparent;
            this.txt_email.Location = new System.Drawing.Point(0, 78);
            this.txt_email.Margin = new System.Windows.Forms.Padding(0);
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceHolder = "Email";
            this.txt_email.Size = new System.Drawing.Size(251, 40);
            this.txt_email.Style = "Standalone";
            this.txt_email.TabIndex = 24;
            this.txt_email.TextBoxText = "Email";
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.Location = new System.Drawing.Point(0, 150);
            this.txt_password.Margin = new System.Windows.Forms.Padding(0);
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceHolder = "Password";
            this.txt_password.Size = new System.Drawing.Size(251, 40);
            this.txt_password.Style = "Standalone";
            this.txt_password.TabIndex = 23;
            this.txt_password.TextBoxText = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.Location = new System.Drawing.Point(0, 18);
            this.txt_username.Margin = new System.Windows.Forms.Padding(0);
            this.txt_username.Name = "txt_username";
            this.txt_username.PlaceHolder = "Username";
            this.txt_username.Size = new System.Drawing.Size(251, 40);
            this.txt_username.Style = "Standalone";
            this.txt_username.TabIndex = 0;
            this.txt_username.TextBoxText = "Username";
            // 
            // UserCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.panel1);
            this.Name = "UserCredentials";
            this.Size = new System.Drawing.Size(251, 196);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_username;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_email;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_password;
        private System.Windows.Forms.Panel panel1;
        private TextBoxWithPlaceHolder txt_username;
        private TextBoxWithPlaceHolder txt_email;
        private TextBoxWithPlaceHolder txt_password;
    }
}
