using SoftwareFirmManagement.BL;

namespace SoftwareFirmManagement.UI
{
    partial class OrderDetailsForm
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
            SoftwareFirmManagement.BL.Customer customer4 = new SoftwareFirmManagement.BL.Customer();
            SoftwareFirmManagement.BL.Employee employee4 = new SoftwareFirmManagement.BL.Employee();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.btn_exit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gbx_add_update_order = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_status = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_status = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmb_supervision = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_platform = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_service = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btn_cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_update_order = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.menuStrip_actions = new System.Windows.Forms.MenuStrip();
            this.actions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_delete_order = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_edit_order = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_title = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.orderDisplay = new SoftwareFirmManagement.UI.OrderDisplay();
            this.lbl_details = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.customerDisplay = new SoftwareFirmManagement.UI.CustomerDisplay();
            this.lbl_customer_details = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.employeeDisplay = new SoftwareFirmManagement.UI.EmployeeDisplay();
            this.lbl_supervision = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_order.Panel)).BeginInit();
            this.gbx_add_update_order.Panel.SuspendLayout();
            this.gbx_add_update_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_supervision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_service)).BeginInit();
            this.menuStrip_actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar.Location = new System.Drawing.Point(933, 0);
            this.vScrollBar.Maximum = 20;
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(17, 600);
            this.vScrollBar.TabIndex = 56;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.Controls.Add(this.btn_exit);
            this.pnl_main.Controls.Add(this.gbx_add_update_order);
            this.pnl_main.Controls.Add(this.menuStrip_actions);
            this.pnl_main.Controls.Add(this.lbl_title);
            this.pnl_main.Controls.Add(this.orderDisplay);
            this.pnl_main.Controls.Add(this.lbl_details);
            this.pnl_main.Controls.Add(this.customerDisplay);
            this.pnl_main.Controls.Add(this.lbl_customer_details);
            this.pnl_main.Controls.Add(this.employeeDisplay);
            this.pnl_main.Controls.Add(this.lbl_supervision);
            this.pnl_main.Location = new System.Drawing.Point(-6, 0);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(939, 701);
            this.pnl_main.TabIndex = 57;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(18, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(150, 50);
            this.btn_exit.TabIndex = 71;
            this.btn_exit.Values.Text = "Back";
            this.btn_exit.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // gbx_add_update_order
            // 
            this.gbx_add_update_order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_add_update_order.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlAlternate;
            this.gbx_add_update_order.Location = new System.Drawing.Point(300, 80);
            this.gbx_add_update_order.Name = "gbx_add_update_order";
            // 
            // gbx_add_update_order.Panel
            // 
            this.gbx_add_update_order.Panel.Controls.Add(this.kryptonLabel2);
            this.gbx_add_update_order.Panel.Controls.Add(this.lbl_status);
            this.gbx_add_update_order.Panel.Controls.Add(this.cmb_status);
            this.gbx_add_update_order.Panel.Controls.Add(this.cmb_supervision);
            this.gbx_add_update_order.Panel.Controls.Add(this.kryptonLabel3);
            this.gbx_add_update_order.Panel.Controls.Add(this.cmb_platform);
            this.gbx_add_update_order.Panel.Controls.Add(this.kryptonLabel4);
            this.gbx_add_update_order.Panel.Controls.Add(this.cmb_service);
            this.gbx_add_update_order.Panel.Controls.Add(this.btn_cancel);
            this.gbx_add_update_order.Panel.Controls.Add(this.btn_update_order);
            this.gbx_add_update_order.Panel.Controls.Add(this.kryptonLabel5);
            this.gbx_add_update_order.Size = new System.Drawing.Size(345, 398);
            this.gbx_add_update_order.TabIndex = 67;
            this.gbx_add_update_order.Values.Heading = "Edit Order";
            this.gbx_add_update_order.Visible = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(24, 6);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(92, 26);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Supervision";
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_status.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_status.Location = new System.Drawing.Point(24, 75);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(55, 26);
            this.lbl_status.TabIndex = 35;
            this.lbl_status.Values.Text = "Status";
            // 
            // cmb_status
            // 
            this.cmb_status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_status.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList;
            this.cmb_status.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cmb_status.DropDownWidth = 188;
            this.cmb_status.Location = new System.Drawing.Point(24, 91);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(265, 36);
            this.cmb_status.TabIndex = 34;
            // 
            // cmb_supervision
            // 
            this.cmb_supervision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_supervision.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList;
            this.cmb_supervision.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cmb_supervision.DropDownWidth = 188;
            this.cmb_supervision.Location = new System.Drawing.Point(24, 24);
            this.cmb_supervision.Name = "cmb_supervision";
            this.cmb_supervision.Size = new System.Drawing.Size(265, 36);
            this.cmb_supervision.TabIndex = 33;
            this.cmb_supervision.Text = "Select Supervision";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(24, 210);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(72, 26);
            this.kryptonLabel3.TabIndex = 31;
            this.kryptonLabel3.Values.Text = "Platform";
            // 
            // cmb_platform
            // 
            this.cmb_platform.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_platform.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList;
            this.cmb_platform.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cmb_platform.DropDownWidth = 188;
            this.cmb_platform.Location = new System.Drawing.Point(24, 225);
            this.cmb_platform.Name = "cmb_platform";
            this.cmb_platform.Size = new System.Drawing.Size(265, 36);
            this.cmb_platform.TabIndex = 32;
            this.cmb_platform.Text = "Select Platform";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(24, 139);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(61, 26);
            this.kryptonLabel4.TabIndex = 27;
            this.kryptonLabel4.Values.Text = "Service";
            // 
            // cmb_service
            // 
            this.cmb_service.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_service.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList;
            this.cmb_service.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cmb_service.DropDownWidth = 188;
            this.cmb_service.Location = new System.Drawing.Point(24, 158);
            this.cmb_service.Name = "cmb_service";
            this.cmb_service.Size = new System.Drawing.Size(265, 36);
            this.cmb_service.TabIndex = 28;
            this.cmb_service.Text = "Select Service";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_cancel.Location = new System.Drawing.Point(10, 298);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 50);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Values.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update_order
            // 
            this.btn_update_order.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_update_order.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_update_order.Location = new System.Drawing.Point(166, 298);
            this.btn_update_order.Name = "btn_update_order";
            this.btn_update_order.Size = new System.Drawing.Size(150, 50);
            this.btn_update_order.TabIndex = 2;
            this.btn_update_order.Values.Text = "Edit Order";
            this.btn_update_order.Click += new System.EventHandler(this.btn_update_order_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(6, 72);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(6, 4);
            this.kryptonLabel5.TabIndex = 9;
            this.kryptonLabel5.Values.Text = "";
            // 
            // menuStrip_actions
            // 
            this.menuStrip_actions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip_actions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.menuStrip_actions.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_actions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.menuStrip_actions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actions});
            this.menuStrip_actions.Location = new System.Drawing.Point(851, 11);
            this.menuStrip_actions.Name = "menuStrip_actions";
            this.menuStrip_actions.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip_actions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip_actions.Size = new System.Drawing.Size(77, 25);
            this.menuStrip_actions.TabIndex = 66;
            this.menuStrip_actions.Text = "Filters";
            // 
            // actions
            // 
            this.actions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_delete_order,
            this.toolStripMenuItem_edit_order});
            this.actions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(71, 23);
            this.actions.Text = "Actions";
            // 
            // toolStripMenuItem_delete_order
            // 
            this.toolStripMenuItem_delete_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.toolStripMenuItem_delete_order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.toolStripMenuItem_delete_order.Image = global::SoftwareFirmManagement.Properties.Resources.Trash;
            this.toolStripMenuItem_delete_order.Name = "toolStripMenuItem_delete_order";
            this.toolStripMenuItem_delete_order.Size = new System.Drawing.Size(188, 30);
            this.toolStripMenuItem_delete_order.Text = "Delete Order";
            this.toolStripMenuItem_delete_order.Click += new System.EventHandler(this.toolStripMenuItem_delete_order_Click);
            // 
            // toolStripMenuItem_edit_order
            // 
            this.toolStripMenuItem_edit_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.toolStripMenuItem_edit_order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.toolStripMenuItem_edit_order.Image = global::SoftwareFirmManagement.Properties.Resources.Edit;
            this.toolStripMenuItem_edit_order.Name = "toolStripMenuItem_edit_order";
            this.toolStripMenuItem_edit_order.Size = new System.Drawing.Size(188, 30);
            this.toolStripMenuItem_edit_order.Text = "Edit Order";
            this.toolStripMenuItem_edit_order.Click += new System.EventHandler(this.toolStripMenuItem_edit_order_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_title.Location = new System.Drawing.Point(364, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(199, 48);
            this.lbl_title.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.TabIndex = 62;
            this.lbl_title.Values.Text = "Order Details";
            // 
            // orderDisplay
            // 
            this.orderDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.orderDisplay.BackColor = System.Drawing.Color.Transparent;
            this.orderDisplay.Location = new System.Drawing.Point(53, 102);
            this.orderDisplay.Name = "orderDisplay";
            this.orderDisplay.OrderDetails = null;
            this.orderDisplay.Size = new System.Drawing.Size(820, 220);
            this.orderDisplay.TabIndex = 68;
            // 
            // lbl_details
            // 
            this.lbl_details.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_details.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_details.Location = new System.Drawing.Point(71, 80);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(59, 26);
            this.lbl_details.TabIndex = 65;
            this.lbl_details.Values.Text = "Details";
            // 
            // customerDisplay
            // 
            this.customerDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customerDisplay.BackColor = System.Drawing.Color.Transparent;
            customer4.CustomerId = 0;
            customer4.Email = null;
            customer4.Name = null;
            customer4.Password = null;
            customer4.Role = null;
            customer4.RoleId = 0;
            customer4.UserId = 0;
            customer4.Username = null;
            this.customerDisplay.Customer = customer4;
            this.customerDisplay.Location = new System.Drawing.Point(53, 363);
            this.customerDisplay.Name = "customerDisplay";
            this.customerDisplay.Size = new System.Drawing.Size(820, 100);
            this.customerDisplay.TabIndex = 69;
            // 
            // lbl_customer_details
            // 
            this.lbl_customer_details.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_customer_details.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_customer_details.Location = new System.Drawing.Point(71, 342);
            this.lbl_customer_details.Name = "lbl_customer_details";
            this.lbl_customer_details.Size = new System.Drawing.Size(129, 26);
            this.lbl_customer_details.TabIndex = 63;
            this.lbl_customer_details.Values.Text = "Customer Details";
            // 
            // employeeDisplay
            // 
            this.employeeDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.employeeDisplay.BackColor = System.Drawing.Color.Transparent;
            employee4.Designation = null;
            employee4.DesignationId = 0;
            employee4.Email = null;
            employee4.EmployeeId = 0;
            employee4.JoinedDate = new System.DateTime(((long)(0)));
            employee4.Name = null;
            employee4.Password = null;
            employee4.Phone = null;
            employee4.Role = null;
            employee4.RoleId = 0;
            employee4.UserId = 0;
            employee4.Username = null;
            this.employeeDisplay.Employee = employee4;
            this.employeeDisplay.Location = new System.Drawing.Point(53, 496);
            this.employeeDisplay.Name = "employeeDisplay";
            this.employeeDisplay.Size = new System.Drawing.Size(820, 150);
            this.employeeDisplay.TabIndex = 70;
            // 
            // lbl_supervision
            // 
            this.lbl_supervision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_supervision.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_supervision.Location = new System.Drawing.Point(71, 476);
            this.lbl_supervision.Name = "lbl_supervision";
            this.lbl_supervision.Size = new System.Drawing.Size(143, 26);
            this.lbl_supervision.TabIndex = 64;
            this.lbl_supervision.Values.Text = "Supervision Details";
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.vScrollBar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_order.Panel)).EndInit();
            this.gbx_add_update_order.Panel.ResumeLayout(false);
            this.gbx_add_update_order.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_order)).EndInit();
            this.gbx_add_update_order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_supervision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_service)).EndInit();
            this.menuStrip_actions.ResumeLayout(false);
            this.menuStrip_actions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.MenuStrip menuStrip_actions;
        private System.Windows.Forms.ToolStripMenuItem actions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_delete_order;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_edit_order;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_supervision;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_title;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_details;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_customer_details;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_add_update_order;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_status;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmb_status;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmb_supervision;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmb_platform;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmb_service;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_update_order;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private OrderDisplay orderDisplay;
        private CustomerDisplay customerDisplay;
        private EmployeeDisplay employeeDisplay;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_exit;
    }
}