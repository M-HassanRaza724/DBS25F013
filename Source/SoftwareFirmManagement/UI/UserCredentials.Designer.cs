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
            this.txt_password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_username = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbl_username = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_email = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_password = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(0, 196);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(250, 49);
            this.txt_password.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_password.TabIndex = 23;
            this.txt_password.Text = "Password";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(0, 109);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(250, 49);
            this.txt_email.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_email.TabIndex = 22;
            this.txt_email.Text = "Email";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(0, 22);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(250, 49);
            this.txt_username.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_username.TabIndex = 21;
            this.txt_username.Text = "Username";
            // 
            // lbl_username
            // 
            this.lbl_username.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_username.Location = new System.Drawing.Point(3, 3);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(82, 26);
            this.lbl_username.TabIndex = 24;
            this.lbl_username.Values.Text = "Username";
            // 
            // lbl_email
            // 
            this.lbl_email.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_email.Location = new System.Drawing.Point(3, 90);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(50, 26);
            this.lbl_email.TabIndex = 25;
            this.lbl_email.Values.Text = "Email";
            // 
            // lbl_password
            // 
            this.lbl_password.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_password.Location = new System.Drawing.Point(3, 177);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(78, 26);
            this.lbl_password.TabIndex = 26;
            this.lbl_password.Values.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 258);
            this.panel1.TabIndex = 27;
            // 
            // UserCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.panel1);
            this.Name = "UserCredentials";
            this.Size = new System.Drawing.Size(257, 258);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_password;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_email;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_username;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_username;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_email;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_password;
        private System.Windows.Forms.Panel panel1;
    }
}
