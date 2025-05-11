namespace SoftwareFirmManagement.UI
{
    partial class CustomerDisplay
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
            this.gbx_customer_details = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_username_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_username = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_email_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_full_name_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_full_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_email = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_customer_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_customer_details.Panel)).BeginInit();
            this.gbx_customer_details.Panel.SuspendLayout();
            this.gbx_customer_details.SuspendLayout();
            this.SuspendLayout();
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
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_username_text);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_username);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_email_text);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_full_name_text);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_email);
            this.gbx_customer_details.Panel.Controls.Add(this.lbl_full_name);
            this.gbx_customer_details.Size = new System.Drawing.Size(820, 100);
            this.gbx_customer_details.TabIndex = 0;
            // 
            // lbl_username_text
            // 
            this.lbl_username_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username_text.Location = new System.Drawing.Point(40, 43);
            this.lbl_username_text.Name = "lbl_username_text";
            this.lbl_username_text.Size = new System.Drawing.Size(153, 28);
            this.lbl_username_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username_text.TabIndex = 22;
            this.lbl_username_text.Values.Text = "Customeruseranme";
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_username.Location = new System.Drawing.Point(38, 13);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(120, 37);
            this.lbl_username.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.TabIndex = 21;
            this.lbl_username.Values.Text = "Username";
            // 
            // lbl_email_text
            // 
            this.lbl_email_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email_text.Location = new System.Drawing.Point(559, 43);
            this.lbl_email_text.Name = "lbl_email_text";
            this.lbl_email_text.Size = new System.Drawing.Size(171, 28);
            this.lbl_email_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email_text.TabIndex = 20;
            this.lbl_email_text.Values.Text = "customer@gmail.com";
            // 
            // lbl_full_name_text
            // 
            this.lbl_full_name_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_full_name_text.Location = new System.Drawing.Point(317, 43);
            this.lbl_full_name_text.Name = "lbl_full_name_text";
            this.lbl_full_name_text.Size = new System.Drawing.Size(82, 28);
            this.lbl_full_name_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_full_name_text.TabIndex = 19;
            this.lbl_full_name_text.Values.Text = "Customer";
            // 
            // lbl_full_name
            // 
            this.lbl_full_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_full_name.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_full_name.Location = new System.Drawing.Point(314, 13);
            this.lbl_full_name.Name = "lbl_full_name";
            this.lbl_full_name.Size = new System.Drawing.Size(76, 37);
            this.lbl_full_name.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_full_name.TabIndex = 17;
            this.lbl_full_name.Values.Text = "Name";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_email.Location = new System.Drawing.Point(556, 13);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(71, 37);
            this.lbl_email.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Values.Text = "Email";
            // 
            // CustomerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbx_customer_details);
            this.Name = "CustomerDisplay";
            this.Size = new System.Drawing.Size(820, 100);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_customer_details.Panel)).EndInit();
            this.gbx_customer_details.Panel.ResumeLayout(false);
            this.gbx_customer_details.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_customer_details)).EndInit();
            this.gbx_customer_details.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_customer_details;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_email_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_full_name_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_full_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_username_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_username;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_email;
    }
}
