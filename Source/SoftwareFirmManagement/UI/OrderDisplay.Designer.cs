namespace SoftwareFirmManagement.UI
{
    partial class OrderDisplay
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
            this.dbx_order_display = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_order_date_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_order_date = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_status = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_platform_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_order_id_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_service_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_description_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_description = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_service = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_platform = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_order_id = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dbx_order_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbx_order_display.Panel)).BeginInit();
            this.dbx_order_display.Panel.SuspendLayout();
            this.dbx_order_display.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbx_order_display
            // 
            this.dbx_order_display.CaptionVisible = false;
            this.dbx_order_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbx_order_display.Location = new System.Drawing.Point(0, 0);
            this.dbx_order_display.Name = "dbx_order_display";
            // 
            // dbx_order_display.Panel
            // 
            this.dbx_order_display.Panel.Controls.Add(this.lbl_order_date_text);
            this.dbx_order_display.Panel.Controls.Add(this.lbl_order_date);
            this.dbx_order_display.Panel.Controls.Add(this.kryptonLabel1);
            this.dbx_order_display.Panel.Controls.Add(this.lbl_status);
            this.dbx_order_display.Panel.Controls.Add(this.lbl_platform_text);
            this.dbx_order_display.Panel.Controls.Add(this.lbl_order_id_text);
            this.dbx_order_display.Panel.Controls.Add(this.lbl_service_text);
            this.dbx_order_display.Panel.Controls.Add(this.lbl_description_text);
            this.dbx_order_display.Panel.Controls.Add(this.lbl_description);
            this.dbx_order_display.Panel.Controls.Add(this.lbl_service);
            this.dbx_order_display.Panel.Controls.Add(this.lbl_platform);
            this.dbx_order_display.Panel.Controls.Add(this.lbl_order_id);
            this.dbx_order_display.Size = new System.Drawing.Size(820, 220);
            this.dbx_order_display.TabIndex = 0;
            // 
            // lbl_order_date_text
            // 
            this.lbl_order_date_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_order_date_text.Location = new System.Drawing.Point(62, 93);
            this.lbl_order_date_text.Name = "lbl_order_date_text";
            this.lbl_order_date_text.Size = new System.Drawing.Size(96, 28);
            this.lbl_order_date_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date_text.TabIndex = 20;
            this.lbl_order_date_text.Values.Text = "12/12/2024";
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_order_date.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_order_date.Location = new System.Drawing.Point(62, 64);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(123, 37);
            this.lbl_order_date.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date.TabIndex = 19;
            this.lbl_order_date.Values.Text = "OrderDate";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel1.Location = new System.Drawing.Point(594, 35);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(92, 28);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 18;
            this.kryptonLabel1.Values.Text = "Completed";
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_status.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_status.Location = new System.Drawing.Point(594, 6);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(79, 37);
            this.lbl_status.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.TabIndex = 17;
            this.lbl_status.Values.Text = "Status";
            // 
            // lbl_platform_text
            // 
            this.lbl_platform_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_platform_text.Location = new System.Drawing.Point(334, 35);
            this.lbl_platform_text.Name = "lbl_platform_text";
            this.lbl_platform_text.Size = new System.Drawing.Size(72, 28);
            this.lbl_platform_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_platform_text.TabIndex = 16;
            this.lbl_platform_text.Values.Text = "Desktop";
            // 
            // lbl_order_id_text
            // 
            this.lbl_order_id_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_order_id_text.Location = new System.Drawing.Point(62, 35);
            this.lbl_order_id_text.Name = "lbl_order_id_text";
            this.lbl_order_id_text.Size = new System.Drawing.Size(148, 28);
            this.lbl_order_id_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_id_text.TabIndex = 15;
            this.lbl_order_id_text.Values.Text = "Web Development";
            // 
            // lbl_service_text
            // 
            this.lbl_service_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_service_text.Location = new System.Drawing.Point(334, 93);
            this.lbl_service_text.Name = "lbl_service_text";
            this.lbl_service_text.Size = new System.Drawing.Size(148, 28);
            this.lbl_service_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service_text.TabIndex = 14;
            this.lbl_service_text.Values.Text = "Web Development";
            // 
            // lbl_description_text
            // 
            this.lbl_description_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_description_text.Location = new System.Drawing.Point(62, 152);
            this.lbl_description_text.Name = "lbl_description_text";
            this.lbl_description_text.Size = new System.Drawing.Size(456, 49);
            this.lbl_description_text.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description_text.TabIndex = 13;
            this.lbl_description_text.Values.Text = "We build responsive, scalable, and engaging websites to help \r\nyou establish a ro" +
    "bust online presence.";
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_description.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_description.Location = new System.Drawing.Point(62, 122);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(132, 37);
            this.lbl_description.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.TabIndex = 12;
            this.lbl_description.Values.Text = "Description";
            // 
            // lbl_service
            // 
            this.lbl_service.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_service.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_service.Location = new System.Drawing.Point(334, 64);
            this.lbl_service.Name = "lbl_service";
            this.lbl_service.Size = new System.Drawing.Size(88, 37);
            this.lbl_service.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service.TabIndex = 11;
            this.lbl_service.Values.Text = "Service";
            // 
            // lbl_platform
            // 
            this.lbl_platform.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_platform.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_platform.Location = new System.Drawing.Point(334, 6);
            this.lbl_platform.Name = "lbl_platform";
            this.lbl_platform.Size = new System.Drawing.Size(104, 37);
            this.lbl_platform.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_platform.TabIndex = 10;
            this.lbl_platform.Values.Text = "Platform";
            // 
            // lbl_order_id
            // 
            this.lbl_order_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_order_id.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_order_id.Location = new System.Drawing.Point(62, 6);
            this.lbl_order_id.Name = "lbl_order_id";
            this.lbl_order_id.Size = new System.Drawing.Size(94, 37);
            this.lbl_order_id.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_id.TabIndex = 9;
            this.lbl_order_id.Values.Text = "OrderId";
            // 
            // OrderDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dbx_order_display);
            this.Name = "OrderDisplay";
            this.Size = new System.Drawing.Size(820, 220);
            ((System.ComponentModel.ISupportInitialize)(this.dbx_order_display.Panel)).EndInit();
            this.dbx_order_display.Panel.ResumeLayout(false);
            this.dbx_order_display.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbx_order_display)).EndInit();
            this.dbx_order_display.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox dbx_order_display;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_platform_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_order_id_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_service_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_description_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_description;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_service;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_platform;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_order_id;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_status;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_order_date_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_order_date;
    }
}
