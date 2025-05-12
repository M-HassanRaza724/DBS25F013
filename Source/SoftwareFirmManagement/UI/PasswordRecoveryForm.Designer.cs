namespace SoftwareFirmManagement.UI
{
    partial class PasswordRecoveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRecoveryForm));
            this.btn_update = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtusername = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.txtnewPassword = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.txt_email = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_update.Location = new System.Drawing.Point(91, 317);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(185, 49);
            this.btn_update.TabIndex = 73;
            this.btn_update.Values.Text = "Reset Password";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.Transparent;
            this.txtusername.Location = new System.Drawing.Point(37, 67);
            this.txtusername.Margin = new System.Windows.Forms.Padding(5);
            this.txtusername.MultiLine = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.PlaceHolder = "place holder";
            this.txtusername.Size = new System.Drawing.Size(342, 49);
            this.txtusername.Style = "Standalone";
            this.txtusername.TabIndex = 70;
            this.txtusername.TextBoxText = "Username";
            // 
            // txtnewPassword
            // 
            this.txtnewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtnewPassword.Location = new System.Drawing.Point(37, 185);
            this.txtnewPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtnewPassword.MultiLine = false;
            this.txtnewPassword.Name = "txtnewPassword";
            this.txtnewPassword.PlaceHolder = "place holder";
            this.txtnewPassword.Size = new System.Drawing.Size(342, 49);
            this.txtnewPassword.Style = "Standalone";
            this.txtnewPassword.TabIndex = 69;
            this.txtnewPassword.TextBoxText = "New Password";
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.Transparent;
            this.txt_email.Location = new System.Drawing.Point(37, 126);
            this.txt_email.Margin = new System.Windows.Forms.Padding(5);
            this.txt_email.MultiLine = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.PlaceHolder = "place holder";
            this.txt_email.Size = new System.Drawing.Size(342, 49);
            this.txt_email.Style = "Standalone";
            this.txt_email.TabIndex = 68;
            this.txt_email.TextBoxText = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(426, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.ForeColor = System.Drawing.Color.White;
            this.lbl_heading.Location = new System.Drawing.Point(85, 19);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(215, 31);
            this.lbl_heading.TabIndex = 66;
            this.lbl_heading.Text = "Password Recovery";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtConfirmPassword.Location = new System.Drawing.Point(37, 244);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtConfirmPassword.MultiLine = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceHolder = "place holder";
            this.txtConfirmPassword.Size = new System.Drawing.Size(342, 49);
            this.txtConfirmPassword.Style = "Standalone";
            this.txtConfirmPassword.TabIndex = 75;
            this.txtConfirmPassword.TextBoxText = "Confirm Password";
            // 
            // PasswordRecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtnewPassword);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_heading);
            this.Name = "PasswordRecoveryForm";
            this.Text = "PasswordRecoveryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_update;
        private TextBoxWithPlaceHolder txtusername;
        private TextBoxWithPlaceHolder txtnewPassword;
        private TextBoxWithPlaceHolder txt_email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_heading;
        private TextBoxWithPlaceHolder txtConfirmPassword;
    }
}