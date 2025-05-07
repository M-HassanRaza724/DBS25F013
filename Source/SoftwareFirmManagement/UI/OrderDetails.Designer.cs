namespace SoftwareFirmManagement.UI
{
    partial class OrderDetails
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
            SoftwareFirmManagement.BL.Customer customer1 = new SoftwareFirmManagement.BL.Customer();
            SoftwareFirmManagement.BL.Employee employee1 = new SoftwareFirmManagement.BL.Employee();
            this.menuStrip_filters = new System.Windows.Forms.MenuStrip();
            this.actions = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDisplay = new SoftwareFirmManagement.UI.OrderDisplay();
            this.lbl_title = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_customer_details = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.customerDisplay = new SoftwareFirmManagement.UI.CustomerDisplay();
            this.lbl_supervision = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_details = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.employeeDisplay = new SoftwareFirmManagement.UI.EmployeeDisplay();
            this.menuStrip_filters.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_filters
            // 
            this.menuStrip_filters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip_filters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.menuStrip_filters.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_filters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.menuStrip_filters.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_filters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actions});
            this.menuStrip_filters.Location = new System.Drawing.Point(860, 9);
            this.menuStrip_filters.Name = "menuStrip_filters";
            this.menuStrip_filters.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip_filters.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip_filters.Size = new System.Drawing.Size(77, 25);
            this.menuStrip_filters.TabIndex = 40;
            this.menuStrip_filters.Text = "Filters";
            // 
            // actions
            // 
            this.actions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteOrderToolStripMenuItem,
            this.editOrderToolStripMenuItem});
            this.actions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(71, 23);
            this.actions.Text = "Actions";
            // 
            // deleteOrderToolStripMenuItem
            // 
            this.deleteOrderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.deleteOrderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.deleteOrderToolStripMenuItem.Image = global::SoftwareFirmManagement.Properties.Resources.Trash;
            this.deleteOrderToolStripMenuItem.Name = "deleteOrderToolStripMenuItem";
            this.deleteOrderToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.deleteOrderToolStripMenuItem.Text = "Delete Order";
            // 
            // editOrderToolStripMenuItem
            // 
            this.editOrderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.editOrderToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.editOrderToolStripMenuItem.Image = global::SoftwareFirmManagement.Properties.Resources.Edit;
            this.editOrderToolStripMenuItem.Name = "editOrderToolStripMenuItem";
            this.editOrderToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.editOrderToolStripMenuItem.Text = "Edit Order";
            // 
            // orderDisplay
            // 
            this.orderDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderDisplay.BackColor = System.Drawing.Color.Transparent;
            this.orderDisplay.Location = new System.Drawing.Point(68, 77);
            this.orderDisplay.Name = "orderDisplay";
            this.orderDisplay.OrderDetails = null;
            this.orderDisplay.Size = new System.Drawing.Size(681, 226);
            this.orderDisplay.TabIndex = 41;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_title.Location = new System.Drawing.Point(367, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(199, 48);
            this.lbl_title.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.TabIndex = 44;
            this.lbl_title.Values.Text = "Order Details";
            // 
            // lbl_customer_details
            // 
            this.lbl_customer_details.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_customer_details.Location = new System.Drawing.Point(84, 327);
            this.lbl_customer_details.Name = "lbl_customer_details";
            this.lbl_customer_details.Size = new System.Drawing.Size(129, 26);
            this.lbl_customer_details.TabIndex = 45;
            this.lbl_customer_details.Values.Text = "Customer Details";
            // 
            // customerDisplay
            // 
            this.customerDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerDisplay.BackColor = System.Drawing.Color.Transparent;
            customer1.CustomerId = 0;
            customer1.Email = "customer@gmail.com";
            customer1.Name = "Customer";
            customer1.Password = null;
            customer1.Role = null;
            customer1.RoleId = 0;
            customer1.UserId = 0;
            customer1.Username = null;
            this.customerDisplay.Customer = customer1;
            this.customerDisplay.Location = new System.Drawing.Point(68, 347);
            this.customerDisplay.Name = "customerDisplay";
            this.customerDisplay.Size = new System.Drawing.Size(680, 100);
            this.customerDisplay.TabIndex = 46;
            // 
            // lbl_supervision
            // 
            this.lbl_supervision.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_supervision.Location = new System.Drawing.Point(84, 464);
            this.lbl_supervision.Name = "lbl_supervision";
            this.lbl_supervision.Size = new System.Drawing.Size(143, 26);
            this.lbl_supervision.TabIndex = 47;
            this.lbl_supervision.Values.Text = "Supervision Details";
            // 
            // lbl_details
            // 
            this.lbl_details.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_details.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_details.Location = new System.Drawing.Point(90, 56);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(59, 26);
            this.lbl_details.TabIndex = 48;
            this.lbl_details.Values.Text = "Details";
            // 
            // employeeDisplay
            // 
            this.employeeDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.employeeDisplay.BackColor = System.Drawing.Color.Transparent;
            employee1.Designation = "Software Engineer";
            employee1.DesignationId = 0;
            employee1.Email = "employee@gmail.com";
            employee1.EmployeeId = 0;
            employee1.JoinedDate = new System.DateTime(((long)(0)));
            employee1.Name = "Employee";
            employee1.Password = null;
            employee1.Phone = "03000000000";
            employee1.Role = null;
            employee1.RoleId = 0;
            employee1.UserId = 0;
            employee1.Username = "employee12";
            this.employeeDisplay.Employee = employee1;
            this.employeeDisplay.Location = new System.Drawing.Point(68, 484);
            this.employeeDisplay.Name = "employeeDisplay";
            this.employeeDisplay.Size = new System.Drawing.Size(820, 150);
            this.employeeDisplay.TabIndex = 49;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(946, 590);
            this.Controls.Add(this.employeeDisplay);
            this.Controls.Add(this.lbl_supervision);
            this.Controls.Add(this.customerDisplay);
            this.Controls.Add(this.lbl_customer_details);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.orderDisplay);
            this.Controls.Add(this.menuStrip_filters);
            this.Controls.Add(this.lbl_details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDetails";
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            this.menuStrip_filters.ResumeLayout(false);
            this.menuStrip_filters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_filters;
        private System.Windows.Forms.ToolStripMenuItem actions;
        private System.Windows.Forms.ToolStripMenuItem deleteOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editOrderToolStripMenuItem;
        private OrderDisplay orderDisplay;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_title;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_customer_details;
        private CustomerDisplay customerDisplay;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_supervision;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_details;
        private EmployeeDisplay employeeDisplay;
    }
}