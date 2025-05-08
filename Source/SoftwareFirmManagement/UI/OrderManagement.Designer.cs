namespace SoftwareFirmManagement.UI
{
    partial class OrderManagement
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
            this.components = new System.ComponentModel.Container();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_filters = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip_filters = new System.Windows.Forms.MenuStrip();
            this.filter_item_sort_by = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filter_item_direction = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_filter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_create_order = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.contextMenuStrip_grd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbox_grd_orders = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_note = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.gbx_add_update_order = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDescription = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.lblPlatform = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbPlatform = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblInitialBudget = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtInitialBudget = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.lblService = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbService = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btn_cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_add_update_order = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_last_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Customer_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_customer_name = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.dgv_orders = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel_filters.SuspendLayout();
            this.menuStrip_filters.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip_grd.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_orders.Panel)).BeginInit();
            this.gbox_grd_orders.Panel.SuspendLayout();
            this.gbox_grd_orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_order.Panel)).BeginInit();
            this.gbx_add_update_order.Panel.SuspendLayout();
            this.gbx_add_update_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.updateToolStripMenuItem.Image = global::SoftwareFirmManagement.Properties.Resources.Available_Updates;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(120, 30);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel_filters, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(806, 51);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel_filters
            // 
            this.tableLayoutPanel_filters.ColumnCount = 2;
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_filters.Controls.Add(this.menuStrip_filters, 1, 0);
            this.tableLayoutPanel_filters.Controls.Add(this.lbl_filter, 0, 0);
            this.tableLayoutPanel_filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_filters.Location = new System.Drawing.Point(322, 0);
            this.tableLayoutPanel_filters.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_filters.Name = "tableLayoutPanel_filters";
            this.tableLayoutPanel_filters.RowCount = 1;
            this.tableLayoutPanel_filters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_filters.Size = new System.Drawing.Size(484, 51);
            this.tableLayoutPanel_filters.TabIndex = 3;
            // 
            // menuStrip_filters
            // 
            this.menuStrip_filters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.menuStrip_filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip_filters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.menuStrip_filters.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_filters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filter_item_sort_by,
            this.filter_item_direction});
            this.menuStrip_filters.Location = new System.Drawing.Point(193, 0);
            this.menuStrip_filters.Name = "menuStrip_filters";
            this.menuStrip_filters.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip_filters.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip_filters.Size = new System.Drawing.Size(291, 51);
            this.menuStrip_filters.TabIndex = 1;
            this.menuStrip_filters.Text = "Filters";
            // 
            // filter_item_sort_by
            // 
            this.filter_item_sort_by.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerNameToolStripMenuItem,
            this.ServiceNameToolStripMenuItem});
            this.filter_item_sort_by.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.filter_item_sort_by.Name = "filter_item_sort_by";
            this.filter_item_sort_by.Size = new System.Drawing.Size(56, 49);
            this.filter_item_sort_by.Text = "Sort By";
            // 
            // CustomerNameToolStripMenuItem
            // 
            this.CustomerNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.CustomerNameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.CustomerNameToolStripMenuItem.Name = "CustomerNameToolStripMenuItem";
            this.CustomerNameToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.CustomerNameToolStripMenuItem.Text = "CustomerName";
            this.CustomerNameToolStripMenuItem.Click += new System.EventHandler(this.CustomerNameToolStripMenuItem_Click);
            // 
            // ServiceNameToolStripMenuItem
            // 
            this.ServiceNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.ServiceNameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.ServiceNameToolStripMenuItem.Name = "ServiceNameToolStripMenuItem";
            this.ServiceNameToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ServiceNameToolStripMenuItem.Text = "ServiceName";
            this.ServiceNameToolStripMenuItem.Click += new System.EventHandler(this.ServiceNameToolStripMenuItem_Click);
            // 
            // filter_item_direction
            // 
            this.filter_item_direction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.filter_item_direction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.filter_item_direction.Name = "filter_item_direction";
            this.filter_item_direction.Size = new System.Drawing.Size(67, 49);
            this.filter_item_direction.Text = "Direction";
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.ascendingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ascendingToolStripMenuItem.Text = "Ascending";
            this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.ascendingToolStripMenuItem_Click);
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.descendingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.descendingToolStripMenuItem.Text = "Descending";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.descendingToolStripMenuItem_Click);
            // 
            // lbl_filter
            // 
            this.lbl_filter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_filter.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_filter.Location = new System.Drawing.Point(136, 12);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(54, 26);
            this.lbl_filter.TabIndex = 38;
            this.lbl_filter.Values.Text = "Filters";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_create_order);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 51);
            this.panel2.TabIndex = 4;
            // 
            // btn_create_order
            // 
            this.btn_create_order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_create_order.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_create_order.Location = new System.Drawing.Point(19, 3);
            this.btn_create_order.Name = "btn_create_order";
            this.btn_create_order.Size = new System.Drawing.Size(142, 44);
            this.btn_create_order.TabIndex = 0;
            this.btn_create_order.Values.Text = "Create Order";
            this.btn_create_order.Click += new System.EventHandler(this.btn_create_order_Click);
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "Menu Item";
            // 
            // contextMenuStrip_grd
            // 
            this.contextMenuStrip_grd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.contextMenuStrip_grd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenuStrip_grd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.contextMenuStrip_grd.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_grd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip_grd.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip_grd.Name = "contextMenuStrip_grd";
            this.contextMenuStrip_grd.Size = new System.Drawing.Size(121, 64);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.deleteToolStripMenuItem.Image = global::SoftwareFirmManagement.Properties.Resources.Trash;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(120, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 512);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbox_grd_orders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 455);
            this.panel1.TabIndex = 2;
            // 
            // gbox_grd_orders
            // 
            this.gbox_grd_orders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_grd_orders.Location = new System.Drawing.Point(9, 3);
            this.gbox_grd_orders.Name = "gbox_grd_orders";
            // 
            // gbox_grd_orders.Panel
            // 
            this.gbox_grd_orders.Panel.Controls.Add(this.lbl_note);
            this.gbox_grd_orders.Panel.Controls.Add(this.gbx_add_update_order);
            this.gbox_grd_orders.Panel.Controls.Add(this.dgv_orders);
            this.gbox_grd_orders.Size = new System.Drawing.Size(782, 444);
            this.gbox_grd_orders.TabIndex = 1;
            this.gbox_grd_orders.Values.Heading = "Users";
            // 
            // lbl_note
            // 
            this.lbl_note.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_note.Location = new System.Drawing.Point(496, 154);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(144, 26);
            this.lbl_note.TabIndex = 2;
            this.lbl_note.Values.Text = "Under construction";
            // 
            // gbx_add_update_order
            // 
            this.gbx_add_update_order.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_add_update_order.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlAlternate;
            this.gbx_add_update_order.Location = new System.Drawing.Point(147, -16);
            this.gbx_add_update_order.Name = "gbx_add_update_order";
            // 
            // gbx_add_update_order.Panel
            // 
            this.gbx_add_update_order.Panel.Controls.Add(this.kryptonLabel1);
            this.gbx_add_update_order.Panel.Controls.Add(this.txtDescription);
            this.gbx_add_update_order.Panel.Controls.Add(this.lblPlatform);
            this.gbx_add_update_order.Panel.Controls.Add(this.cmbPlatform);
            this.gbx_add_update_order.Panel.Controls.Add(this.lblInitialBudget);
            this.gbx_add_update_order.Panel.Controls.Add(this.txtInitialBudget);
            this.gbx_add_update_order.Panel.Controls.Add(this.lblService);
            this.gbx_add_update_order.Panel.Controls.Add(this.cmbService);
            this.gbx_add_update_order.Panel.Controls.Add(this.btn_cancel);
            this.gbx_add_update_order.Panel.Controls.Add(this.btn_add_update_order);
            this.gbx_add_update_order.Panel.Controls.Add(this.lbl_last_name);
            this.gbx_add_update_order.Panel.Controls.Add(this.lbl_Customer_name);
            this.gbx_add_update_order.Panel.Controls.Add(this.txt_customer_name);
            this.gbx_add_update_order.Size = new System.Drawing.Size(389, 398);
            this.gbx_add_update_order.TabIndex = 1;
            this.gbx_add_update_order.Values.Heading = "Add Customer";
            this.gbx_add_update_order.Visible = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(41, 195);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(104, 26);
            this.kryptonLabel1.TabIndex = 34;
            this.kryptonLabel1.Values.Text = "Initial Budget";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.Location = new System.Drawing.Point(38, 212);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceHolder = "Description";
            this.txtDescription.Size = new System.Drawing.Size(195, 57);
            this.txtDescription.Style = "Standalone";
            this.txtDescription.TabIndex = 33;
            this.txtDescription.TextBoxText = "Description";
            // 
            // lblPlatform
            // 
            this.lblPlatform.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblPlatform.Location = new System.Drawing.Point(41, 160);
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
            this.cmbPlatform.Location = new System.Drawing.Point(41, 176);
            this.cmbPlatform.Name = "cmbPlatform";
            this.cmbPlatform.Size = new System.Drawing.Size(250, 36);
            this.cmbPlatform.TabIndex = 32;
            this.cmbPlatform.Text = "Platform";
            // 
            // lblInitialBudget
            // 
            this.lblInitialBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInitialBudget.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblInitialBudget.Location = new System.Drawing.Point(41, 30);
            this.lblInitialBudget.Name = "lblInitialBudget";
            this.lblInitialBudget.Size = new System.Drawing.Size(104, 26);
            this.lblInitialBudget.TabIndex = 30;
            this.lblInitialBudget.Values.Text = "Initial Budget";
            // 
            // txtInitialBudget
            // 
            this.txtInitialBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInitialBudget.BackColor = System.Drawing.Color.Transparent;
            this.txtInitialBudget.Location = new System.Drawing.Point(38, 47);
            this.txtInitialBudget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInitialBudget.Name = "txtInitialBudget";
            this.txtInitialBudget.PlaceHolder = "Initial Budget";
            this.txtInitialBudget.Size = new System.Drawing.Size(195, 42);
            this.txtInitialBudget.Style = "Standalone";
            this.txtInitialBudget.TabIndex = 29;
            this.txtInitialBudget.TextBoxText = "Initial Budget";
            // 
            // lblService
            // 
            this.lblService.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblService.Location = new System.Drawing.Point(41, 105);
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
            this.cmbService.Location = new System.Drawing.Point(41, 121);
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
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.btn_add_update_order.Click += new System.EventHandler(this.btn_add_update_order_Click);
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
            this.lbl_Customer_name.Location = new System.Drawing.Point(41, -19);
            this.lbl_Customer_name.Name = "lbl_Customer_name";
            this.lbl_Customer_name.Size = new System.Drawing.Size(123, 26);
            this.lbl_Customer_name.TabIndex = 8;
            this.lbl_Customer_name.Values.Text = "Customer Name";
            // 
            // txt_customer_name
            // 
            this.txt_customer_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customer_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_customer_name.Location = new System.Drawing.Point(38, -2);
            this.txt_customer_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_customer_name.Name = "txt_customer_name";
            this.txt_customer_name.PlaceHolder = "Customer Name";
            this.txt_customer_name.Size = new System.Drawing.Size(195, 42);
            this.txt_customer_name.Style = "Standalone";
            this.txt_customer_name.TabIndex = 3;
            this.txt_customer_name.TextBoxText = "Customer Name";
            // 
            // dgv_orders
            // 
            this.dgv_orders.AutoGenerateColumns = false;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn});
            this.dgv_orders.DataSource = this.OrderBindingSource;
            this.dgv_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_orders.Location = new System.Drawing.Point(0, 0);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.RowHeadersWidth = 62;
            this.dgv_orders.Size = new System.Drawing.Size(768, 411);
            this.dgv_orders.TabIndex = 0;
            this.dgv_orders.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_orders_CellMouseDown);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.Width = 125;
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(SoftwareFirmManagement.BL.OrderDTO);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(806, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip_filters;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderManagement";
            this.Text = "OrderManagement";
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel_filters.ResumeLayout(false);
            this.tableLayoutPanel_filters.PerformLayout();
            this.menuStrip_filters.ResumeLayout(false);
            this.menuStrip_filters.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip_grd.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_orders.Panel)).EndInit();
            this.gbox_grd_orders.Panel.ResumeLayout(false);
            this.gbox_grd_orders.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_orders)).EndInit();
            this.gbox_grd_orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_order.Panel)).EndInit();
            this.gbx_add_update_order.Panel.ResumeLayout(false);
            this.gbx_add_update_order.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_order)).EndInit();
            this.gbx_add_update_order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_filters;
        private System.Windows.Forms.MenuStrip menuStrip_filters;
        private System.Windows.Forms.ToolStripMenuItem filter_item_sort_by;
        private System.Windows.Forms.ToolStripMenuItem CustomerNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServiceNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filter_item_direction;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_filter;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_create_order;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_grd;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbox_grd_orders;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_add_update_order;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_add_update_order;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_last_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Customer_name;
        private TextBoxWithPlaceHolder txt_customer_name;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblService;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbService;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblInitialBudget;
        private TextBoxWithPlaceHolder txtInitialBudget;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPlatform;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbPlatform;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private TextBoxWithPlaceHolder txtDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_note;
    }
}