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
            SoftwareFirmManagement.BL.Customer customer3 = new SoftwareFirmManagement.BL.Customer();
            SoftwareFirmManagement.BL.Employee employee3 = new SoftwareFirmManagement.BL.Employee();
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
            this.gbx_add_update_order = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lblPlatform = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbPlatform = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblService = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbService = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btn_cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_add_update_order = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_last_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Customer_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonComboBox2 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.menuStrip_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_order.Panel)).BeginInit();
            this.gbx_add_update_order.Panel.SuspendLayout();
            this.gbx_add_update_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
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
            customer3.CustomerId = 0;
            customer3.Email = "customer@gmail.com";
            customer3.Name = "Customer";
            customer3.Password = null;
            customer3.Role = null;
            customer3.RoleId = 0;
            customer3.UserId = 0;
            customer3.Username = null;
            this.customerDisplay.Customer = customer3;
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
            employee3.Designation = "Software Engineer";
            employee3.DesignationId = 0;
            employee3.Email = "employee@gmail.com";
            employee3.EmployeeId = 0;
            employee3.JoinedDate = new System.DateTime(((long)(0)));
            employee3.Name = "Employee";
            employee3.Password = null;
            employee3.Phone = "03000000000";
            employee3.Role = null;
            employee3.RoleId = 0;
            employee3.UserId = 0;
            employee3.Username = "employee12";
            this.employeeDisplay.Employee = employee3;
            this.employeeDisplay.Location = new System.Drawing.Point(68, 484);
            this.employeeDisplay.Name = "employeeDisplay";
            this.employeeDisplay.Size = new System.Drawing.Size(820, 150);
            this.employeeDisplay.TabIndex = 49;
            // 
            // gbx_add_update_order
            // 
            this.gbx_add_update_order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_add_update_order.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlAlternate;
            this.gbx_add_update_order.Location = new System.Drawing.Point(285, 56);
            this.gbx_add_update_order.Name = "gbx_add_update_order";
            // 
            // gbx_add_update_order.Panel
            // 
            this.gbx_add_update_order.Panel.Controls.Add(this.kryptonLabel1);
            this.gbx_add_update_order.Panel.Controls.Add(this.kryptonComboBox2);
            this.gbx_add_update_order.Panel.Controls.Add(this.kryptonComboBox1);
            this.gbx_add_update_order.Panel.Controls.Add(this.lblPlatform);
            this.gbx_add_update_order.Panel.Controls.Add(this.cmbPlatform);
            this.gbx_add_update_order.Panel.Controls.Add(this.lblService);
            this.gbx_add_update_order.Panel.Controls.Add(this.cmbService);
            this.gbx_add_update_order.Panel.Controls.Add(this.btn_cancel);
            this.gbx_add_update_order.Panel.Controls.Add(this.btn_add_update_order);
            this.gbx_add_update_order.Panel.Controls.Add(this.lbl_last_name);
            this.gbx_add_update_order.Panel.Controls.Add(this.lbl_Customer_name);
            this.gbx_add_update_order.Size = new System.Drawing.Size(389, 398);
            this.gbx_add_update_order.TabIndex = 50;
            this.gbx_add_update_order.Values.Heading = "Edit Order";
            this.gbx_add_update_order.Visible = false;
            // 
            // lblPlatform
            // 
            this.lblPlatform.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblPlatform.Location = new System.Drawing.Point(24, 210);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(72, 26);
            this.lblPlatform.TabIndex = 31;
            this.lblPlatform.Values.Text = "Platform";
            // 
            // cmbPlatform
            // 
            this.cmbPlatform.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList;
            this.cmbPlatform.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cmbPlatform.DropDownWidth = 188;
            this.cmbPlatform.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "item 6"});
            this.cmbPlatform.Location = new System.Drawing.Point(24, 226);
            this.cmbPlatform.Name = "cmbPlatform";
            this.cmbPlatform.Size = new System.Drawing.Size(250, 36);
            this.cmbPlatform.TabIndex = 32;
            this.cmbPlatform.Text = "Platform";
            // 
            // lblService
            // 
            this.lblService.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblService.Location = new System.Drawing.Point(24, 155);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(61, 26);
            this.lblService.TabIndex = 27;
            this.lblService.Values.Text = "Service";
            // 
            // cmbService
            // 
            this.cmbService.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList;
            this.cmbService.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cmbService.DropDownWidth = 188;
            this.cmbService.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "item 6"});
            this.cmbService.Location = new System.Drawing.Point(24, 171);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(250, 36);
            this.cmbService.TabIndex = 28;
            this.cmbService.Text = "Service";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(2, 269);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 50);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Values.Text = "Cancel";
            // 
            // btn_add_update_order
            // 
            this.btn_add_update_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_update_order.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_add_update_order.Location = new System.Drawing.Point(158, 269);
            this.btn_add_update_order.Name = "btn_add_update_order";
            this.btn_add_update_order.Size = new System.Drawing.Size(150, 50);
            this.btn_add_update_order.TabIndex = 2;
            this.btn_add_update_order.Values.Text = "Create Order";
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_last_name.Location = new System.Drawing.Point(6, 72);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(6, 4);
            this.lbl_last_name.TabIndex = 9;
            this.lbl_last_name.Values.Text = "";
            // 
            // lbl_Customer_name
            // 
            this.lbl_Customer_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Customer_name.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_Customer_name.Location = new System.Drawing.Point(24, 3);
            this.lbl_Customer_name.Name = "lbl_Customer_name";
            this.lbl_Customer_name.Size = new System.Drawing.Size(92, 26);
            this.lbl_Customer_name.TabIndex = 8;
            this.lbl_Customer_name.Values.Text = "Supervision";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList;
            this.kryptonComboBox1.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.kryptonComboBox1.DropDownWidth = 188;
            this.kryptonComboBox1.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.kryptonComboBox1.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "item 6"});
            this.kryptonComboBox1.Location = new System.Drawing.Point(24, 24);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(250, 37);
            this.kryptonComboBox1.TabIndex = 33;
            this.kryptonComboBox1.Text = "ComboBox";
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList;
            this.kryptonComboBox2.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.kryptonComboBox2.DropDownWidth = 188;
            this.kryptonComboBox2.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.kryptonComboBox2.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "item 6"});
            this.kryptonComboBox2.Location = new System.Drawing.Point(24, 97);
            this.kryptonComboBox2.Name = "kryptonComboBox2";
            this.kryptonComboBox2.Size = new System.Drawing.Size(250, 37);
            this.kryptonComboBox2.TabIndex = 34;
            this.kryptonComboBox2.Text = "ComboBox";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(24, 72);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(55, 26);
            this.kryptonLabel1.TabIndex = 35;
            this.kryptonLabel1.Values.Text = "Status";
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(946, 590);
            this.Controls.Add(this.gbx_add_update_order);
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
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_order.Panel)).EndInit();
            this.gbx_add_update_order.Panel.ResumeLayout(false);
            this.gbx_add_update_order.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_order)).EndInit();
            this.gbx_add_update_order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
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
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_add_update_order;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPlatform;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbPlatform;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblService;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbService;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_add_update_order;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_last_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Customer_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
    }
}