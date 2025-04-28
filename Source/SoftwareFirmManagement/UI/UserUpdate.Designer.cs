namespace SoftwareFirmManagement.UI
{
    partial class UserUpdate
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
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.txt_password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_username = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.txt_password);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txt_email);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txt_username);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(314, 272);
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "Add User";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(24, 163);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(250, 49);
            this.txt_password.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_password.TabIndex = 20;
            this.txt_password.Text = "Password";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(24, 95);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(250, 49);
            this.txt_email.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_email.TabIndex = 19;
            this.txt_email.Text = "Email";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(24, 29);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(250, 49);
            this.txt_username.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_username.TabIndex = 18;
            this.txt_username.Text = "Username";
            // 
            // UserUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kryptonGroupBox1);
            this.Name = "UserUpdate";
            this.Size = new System.Drawing.Size(314, 272);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_password;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_email;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_username;
    }
}
