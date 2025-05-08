namespace SoftwareFirmManagement.UI
{
    partial class ServiceDisplay
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
            this.gbx_service = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_sub_services_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_name_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_technologies_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_description_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_description = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_technology = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_sub_services = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_service.Panel)).BeginInit();
            this.gbx_service.Panel.SuspendLayout();
            this.gbx_service.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_service
            // 
            this.gbx_service.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_service.Location = new System.Drawing.Point(0, 0);
            this.gbx_service.Name = "gbx_service";
            // 
            // gbx_service.Panel
            // 
            this.gbx_service.Panel.Controls.Add(this.lbl_sub_services_text);
            this.gbx_service.Panel.Controls.Add(this.lbl_name_text);
            this.gbx_service.Panel.Controls.Add(this.lbl_technologies_text);
            this.gbx_service.Panel.Controls.Add(this.lbl_description_text);
            this.gbx_service.Panel.Controls.Add(this.lbl_description);
            this.gbx_service.Panel.Controls.Add(this.lbl_technology);
            this.gbx_service.Panel.Controls.Add(this.lbl_sub_services);
            this.gbx_service.Panel.Controls.Add(this.lbl_name);
            this.gbx_service.Size = new System.Drawing.Size(714, 235);
            this.gbx_service.TabIndex = 0;
            this.gbx_service.Values.Heading = "";
            // 
            // lbl_sub_services_text
            // 
            this.lbl_sub_services_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_sub_services_text.Location = new System.Drawing.Point(96, 179);
            this.lbl_sub_services_text.Name = "lbl_sub_services_text";
            this.lbl_sub_services_text.Size = new System.Drawing.Size(508, 28);
            this.lbl_sub_services_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sub_services_text.TabIndex = 8;
            this.lbl_sub_services_text.Values.Text = "E-commerce sites, CMS solutions, landing pages, corporate websites";
            // 
            // lbl_name_text
            // 
            this.lbl_name_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_name_text.Location = new System.Drawing.Point(96, 28);
            this.lbl_name_text.Name = "lbl_name_text";
            this.lbl_name_text.Size = new System.Drawing.Size(148, 28);
            this.lbl_name_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_text.TabIndex = 7;
            this.lbl_name_text.Values.Text = "Web Development";
            // 
            // lbl_technologies_text
            // 
            this.lbl_technologies_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_technologies_text.Location = new System.Drawing.Point(96, 133);
            this.lbl_technologies_text.Name = "lbl_technologies_text";
            this.lbl_technologies_text.Size = new System.Drawing.Size(316, 28);
            this.lbl_technologies_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_technologies_text.TabIndex = 6;
            this.lbl_technologies_text.Values.Text = "HTML, CSS, JavaScript, React, Nodejs, PHP";
            // 
            // lbl_description_text
            // 
            this.lbl_description_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_description_text.Location = new System.Drawing.Point(96, 70);
            this.lbl_description_text.Name = "lbl_description_text";
            this.lbl_description_text.Size = new System.Drawing.Size(456, 49);
            this.lbl_description_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description_text.TabIndex = 5;
            this.lbl_description_text.Values.Text = "We build responsive, scalable, and engaging websites to help \r\nyou establish a ro" +
    "bust online presence.";
            this.lbl_description_text.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_description.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_description.Location = new System.Drawing.Point(16, 45);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(132, 37);
            this.lbl_description.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.TabIndex = 3;
            this.lbl_description.Values.Text = "Description";
            // 
            // lbl_technology
            // 
            this.lbl_technology.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_technology.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_technology.Location = new System.Drawing.Point(18, 107);
            this.lbl_technology.Name = "lbl_technology";
            this.lbl_technology.Size = new System.Drawing.Size(149, 37);
            this.lbl_technology.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_technology.TabIndex = 2;
            this.lbl_technology.Values.Text = "Technologies";
            // 
            // lbl_sub_services
            // 
            this.lbl_sub_services.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_sub_services.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_sub_services.Location = new System.Drawing.Point(18, 153);
            this.lbl_sub_services.Name = "lbl_sub_services";
            this.lbl_sub_services.Size = new System.Drawing.Size(136, 37);
            this.lbl_sub_services.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sub_services.TabIndex = 1;
            this.lbl_sub_services.Values.Text = "SubServices";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_name.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_name.Location = new System.Drawing.Point(16, 4);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(76, 37);
            this.lbl_name.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Values.Text = "Name";
            // 
            // ServiceDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbx_service);
            this.Name = "ServiceDisplay";
            this.Size = new System.Drawing.Size(714, 235);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_service.Panel)).EndInit();
            this.gbx_service.Panel.ResumeLayout(false);
            this.gbx_service.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_service)).EndInit();
            this.gbx_service.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_service;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_description;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_technology;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_sub_services;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_description_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_sub_services_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_name_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_technologies_text;
    }
}
