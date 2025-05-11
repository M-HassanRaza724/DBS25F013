namespace SoftwareFirmManagement.UI
{
    partial class EmployeeDisplay
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
            this.gbx_customer_details = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_phone_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_phone = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_designation_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_designation = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_username_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_email_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_full_name_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_email = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_full_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbtn_assign = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_customer_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_customer_details.Panel)).BeginInit();
            this.gbx_customer_details.Panel.SuspendLayout();
            this.gbx_customer_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_username.Location = new System.Drawing.Point(264, 7);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(120, 37);
            this.lbl_username.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.TabIndex = 21;
            this.lbl_username.Values.Text = "Username";
            // 
            // gbx_customer_details
            // 
            this.gbx_customer_details.CaptionVisible = false;
            this.gbx_customer_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_customer_details.Location = new System.Drawing.Point(0, 0);
            this.gbx_customer_details.Name = "gbx_customer_details";
            // 
            // gbx_customer_details.Panel
            // 
            this.gbx_customer_details.Panel.Controls.Add(this.cbtn_assign);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_phone_text);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_phone);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_designation_text);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_designation);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_username_text);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_username);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_email_text);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_full_name_text);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_email);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_full_name);
            this.gbx_customer_details.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.gbx_customer_details_Panel_Paint);
            this.gbx_customer_details.Size = new System.Drawing.Size(820, 150);
            this.gbx_customer_details.TabIndex = 1;
            // 
            // lbl_phone_text
            // 
            this.lbl_phone_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_phone_text.Location = new System.Drawing.Point(22, 101);
            this.lbl_phone_text.Name = "lbl_phone_text";
            this.lbl_phone_text.Size = new System.Drawing.Size(127, 28);
            this.lbl_phone_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone_text.TabIndex = 26;
            this.lbl_phone_text.Values.Text = "0300000000000";
            // 
            // lbl_phone
            // 
            this.lbl_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_phone.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_phone.Location = new System.Drawing.Point(18, 71);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(80, 37);
            this.lbl_phone.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.TabIndex = 25;
            this.lbl_phone.Values.Text = "Phone";
            // 
            // lbl_designation_text
            // 
            this.lbl_designation_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_designation_text.Location = new System.Drawing.Point(545, 37);
            this.lbl_designation_text.Name = "lbl_designation_text";
            this.lbl_designation_text.Size = new System.Drawing.Size(159, 28);
            this.lbl_designation_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_designation_text.TabIndex = 24;
            this.lbl_designation_text.Values.Text = "Full Stack Developer";
            // 
            // lbl_designation
            // 
            this.lbl_designation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_designation.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_designation.Location = new System.Drawing.Point(542, 7);
            this.lbl_designation.Name = "lbl_designation";
            this.lbl_designation.Size = new System.Drawing.Size(137, 37);
            this.lbl_designation.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_designation.TabIndex = 23;
            this.lbl_designation.Values.Text = "Designation";
            // 
            // lbl_username_text
            // 
            this.lbl_username_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username_text.Location = new System.Drawing.Point(267, 37);
            this.lbl_username_text.Name = "lbl_username_text";
            this.lbl_username_text.Size = new System.Drawing.Size(153, 28);
            this.lbl_username_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username_text.TabIndex = 22;
            this.lbl_username_text.Values.Text = "Customeruseranme";
            // 
            // lbl_email_text
            // 
            this.lbl_email_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email_text.Location = new System.Drawing.Point(268, 101);
            this.lbl_email_text.Name = "lbl_email_text";
            this.lbl_email_text.Size = new System.Drawing.Size(171, 28);
            this.lbl_email_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email_text.TabIndex = 20;
            this.lbl_email_text.Values.Text = "customer@gmail.com";
            // 
            // lbl_full_name_text
            // 
            this.lbl_full_name_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_full_name_text.Location = new System.Drawing.Point(18, 37);
            this.lbl_full_name_text.Name = "lbl_full_name_text";
            this.lbl_full_name_text.Size = new System.Drawing.Size(82, 28);
            this.lbl_full_name_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_full_name_text.TabIndex = 19;
            this.lbl_full_name_text.Values.Text = "Customer";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_email.Location = new System.Drawing.Point(264, 71);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(71, 37);
            this.lbl_email.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Values.Text = "Email";
            // 
            // lbl_full_name
            // 
            this.lbl_full_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_full_name.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_full_name.Location = new System.Drawing.Point(15, 7);
            this.lbl_full_name.Name = "lbl_full_name";
            this.lbl_full_name.Size = new System.Drawing.Size(76, 37);
            this.lbl_full_name.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_full_name.TabIndex = 17;
            this.lbl_full_name.Values.Text = "Name";
            // 
            // cbtn_assign
            // 
            this.cbtn_assign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtn_assign.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cbtn_assign.Location = new System.Drawing.Point(535, 80);
            this.cbtn_assign.Name = "cbtn_assign";
            this.cbtn_assign.Size = new System.Drawing.Size(182, 42);
            this.cbtn_assign.TabIndex = 32;
            this.cbtn_assign.Values.Text = "Assign";
            this.cbtn_assign.Visible = false;
            this.cbtn_assign.CheckedChanged += new System.EventHandler(this.cbtn_assign_CheckedChanged);
            // 
            // EmployeeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbx_customer_details);
            this.Name = "EmployeeDisplay";
            this.Size = new System.Drawing.Size(820, 150);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_customer_details.Panel)).EndInit();
            this.gbx_customer_details.Panel.ResumeLayout(false);
            this.gbx_customer_details.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_customer_details)).EndInit();
            this.gbx_customer_details.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_username;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_customer_details;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_username_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_email_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_full_name_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_email;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_full_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_designation_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_designation;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_phone_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_phone;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton cbtn_assign;
    }
}
