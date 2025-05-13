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
            this.pnl_main = new System.Windows.Forms.Panel();
            this.gbox_grd_orders = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgv_orders = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbpnl_header = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_filters = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip_filters = new System.Windows.Forms.MenuStrip();
            this.filter_item_sort_by = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filter_item_direction = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_status_pending = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_in_progress = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_completed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_cancelled = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_on_hold = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_rejected = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_filter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.contextMenuStrip_grd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_header = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_orders.Panel)).BeginInit();
            this.gbox_grd_orders.Panel.SuspendLayout();
            this.gbox_grd_orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbpnl_header.SuspendLayout();
            this.tableLayoutPanel_filters.SuspendLayout();
            this.menuStrip_filters.SuspendLayout();
            this.contextMenuStrip_grd.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(800, 450);
            this.pnl_main.TabIndex = 0;
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
            this.gbox_grd_orders.Panel.Controls.Add(this.dgv_orders);
            this.gbox_grd_orders.Size = new System.Drawing.Size(776, 388);
            this.gbox_grd_orders.TabIndex = 1;
            this.gbox_grd_orders.Values.Heading = "";
            // 
            // dgv_orders
            // 
            this.dgv_orders.AllowUserToAddRows = false;
            this.dgv_orders.AllowUserToDeleteRows = false;
            this.dgv_orders.AutoGenerateColumns = false;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionColumn,
            this.orderIdColumn,
            this.serviceColumn,
            this.customerColumn,
            this.createdAtColumn,
            this.statusColumn});
            this.dgv_orders.DataSource = this.OrderBindingSource;
            this.dgv_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_orders.Location = new System.Drawing.Point(0, 0);
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.ReadOnly = true;
            this.dgv_orders.RowHeadersWidth = 62;
            this.dgv_orders.Size = new System.Drawing.Size(762, 374);
            this.dgv_orders.TabIndex = 0;
            this.dgv_orders.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_orders_CellMouseDown);
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.DataPropertyName = "Description";
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.MinimumWidth = 6;
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.ReadOnly = true;
            this.descriptionColumn.Visible = false;
            this.descriptionColumn.Width = 125;
            // 
            // orderIdColumn
            // 
            this.orderIdColumn.DataPropertyName = "OrderId";
            this.orderIdColumn.HeaderText = "OrderId";
            this.orderIdColumn.Name = "orderIdColumn";
            this.orderIdColumn.ReadOnly = true;
            this.orderIdColumn.Visible = false;
            // 
            // serviceColumn
            // 
            this.serviceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serviceColumn.DataPropertyName = "Service";
            this.serviceColumn.HeaderText = "Service";
            this.serviceColumn.MinimumWidth = 6;
            this.serviceColumn.Name = "serviceColumn";
            this.serviceColumn.ReadOnly = true;
            // 
            // customerColumn
            // 
            this.customerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerColumn.DataPropertyName = "Customer";
            this.customerColumn.HeaderText = "Customer";
            this.customerColumn.MinimumWidth = 6;
            this.customerColumn.Name = "customerColumn";
            this.customerColumn.ReadOnly = true;
            // 
            // createdAtColumn
            // 
            this.createdAtColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdAtColumn.DataPropertyName = "CreatedAt";
            this.createdAtColumn.HeaderText = "CreatedAt";
            this.createdAtColumn.MinimumWidth = 6;
            this.createdAtColumn.Name = "createdAtColumn";
            this.createdAtColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            this.statusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusColumn.DataPropertyName = "Status";
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(SoftwareFirmManagement.BL.OrderDTO);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbox_grd_orders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 399);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbpnl_header, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tbpnl_header
            // 
            this.tbpnl_header.ColumnCount = 1;
            this.tbpnl_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpnl_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbpnl_header.Controls.Add(this.tableLayoutPanel_filters, 0, 0);
            this.tbpnl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpnl_header.Location = new System.Drawing.Point(0, 0);
            this.tbpnl_header.Margin = new System.Windows.Forms.Padding(0);
            this.tbpnl_header.Name = "tbpnl_header";
            this.tbpnl_header.RowCount = 1;
            this.tbpnl_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpnl_header.Size = new System.Drawing.Size(800, 45);
            this.tbpnl_header.TabIndex = 3;
            // 
            // tableLayoutPanel_filters
            // 
            this.tableLayoutPanel_filters.ColumnCount = 1;
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_filters.Controls.Add(this.pnl_header, 0, 0);
            this.tableLayoutPanel_filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_filters.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_filters.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_filters.Name = "tableLayoutPanel_filters";
            this.tableLayoutPanel_filters.RowCount = 1;
            this.tableLayoutPanel_filters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_filters.Size = new System.Drawing.Size(800, 45);
            this.tableLayoutPanel_filters.TabIndex = 3;
            this.tableLayoutPanel_filters.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_filters_Paint);
            // 
            // menuStrip_filters
            // 
            this.menuStrip_filters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip_filters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.menuStrip_filters.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_filters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.menuStrip_filters.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_filters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filter_item_sort_by,
            this.filter_item_direction,
            this.statusToolStripMenuItem});
            this.menuStrip_filters.Location = new System.Drawing.Point(292, 6);
            this.menuStrip_filters.Name = "menuStrip_filters";
            this.menuStrip_filters.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip_filters.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip_filters.Size = new System.Drawing.Size(180, 24);
            this.menuStrip_filters.TabIndex = 1;
            this.menuStrip_filters.Text = "Filters";
            // 
            // filter_item_sort_by
            // 
            this.filter_item_sort_by.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerNameToolStripMenuItem,
            this.ServiceNameToolStripMenuItem,
            this.dateToolStripMenuItem});
            this.filter_item_sort_by.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.filter_item_sort_by.Name = "filter_item_sort_by";
            this.filter_item_sort_by.Size = new System.Drawing.Size(56, 22);
            this.filter_item_sort_by.Text = "Sort By";
            // 
            // CustomerNameToolStripMenuItem
            // 
            this.CustomerNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.CustomerNameToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CustomerNameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.CustomerNameToolStripMenuItem.Name = "CustomerNameToolStripMenuItem";
            this.CustomerNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CustomerNameToolStripMenuItem.Text = "CustomerName";
            this.CustomerNameToolStripMenuItem.Click += new System.EventHandler(this.CustomerNameToolStripMenuItem_Click_1);
            // 
            // ServiceNameToolStripMenuItem
            // 
            this.ServiceNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.ServiceNameToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ServiceNameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.ServiceNameToolStripMenuItem.Name = "ServiceNameToolStripMenuItem";
            this.ServiceNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ServiceNameToolStripMenuItem.Text = "ServiceName";
            this.ServiceNameToolStripMenuItem.Click += new System.EventHandler(this.ServiceNameToolStripMenuItem_Click_1);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.dateToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateToolStripMenuItem.Text = "Orderdate";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // filter_item_direction
            // 
            this.filter_item_direction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.filter_item_direction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.filter_item_direction.Name = "filter_item_direction";
            this.filter_item_direction.Size = new System.Drawing.Size(67, 22);
            this.filter_item_direction.Text = "Direction";
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.ascendingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ascendingToolStripMenuItem.Text = "Ascending";
            this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.ascendingToolStripMenuItem_Click);
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.descendingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descendingToolStripMenuItem.Text = "Descending";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.descendingToolStripMenuItem_Click);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_status_pending,
            this.tsm_in_progress,
            this.tsm_completed,
            this.tsm_cancelled,
            this.tsm_on_hold,
            this.tsm_rejected});
            this.statusToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.DropDownClosed += new System.EventHandler(this.statusToolStripMenuItem_DropDownClosed);
            this.statusToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStripMenuItem_DropDownItemClicked);
            // 
            // tsm_status_pending
            // 
            this.tsm_status_pending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.tsm_status_pending.Checked = true;
            this.tsm_status_pending.CheckOnClick = true;
            this.tsm_status_pending.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsm_status_pending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.tsm_status_pending.Name = "tsm_status_pending";
            this.tsm_status_pending.Size = new System.Drawing.Size(180, 22);
            this.tsm_status_pending.Text = "Pending";
            this.tsm_status_pending.CheckedChanged += new System.EventHandler(this.tsm_status_pending_CheckedChanged);
            // 
            // tsm_in_progress
            // 
            this.tsm_in_progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.tsm_in_progress.Checked = true;
            this.tsm_in_progress.CheckOnClick = true;
            this.tsm_in_progress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsm_in_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.tsm_in_progress.Name = "tsm_in_progress";
            this.tsm_in_progress.Size = new System.Drawing.Size(180, 22);
            this.tsm_in_progress.Text = "In-Progress";
            this.tsm_in_progress.CheckedChanged += new System.EventHandler(this.tsm_in_progress_CheckedChanged);
            // 
            // tsm_completed
            // 
            this.tsm_completed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.tsm_completed.Checked = true;
            this.tsm_completed.CheckOnClick = true;
            this.tsm_completed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsm_completed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.tsm_completed.Name = "tsm_completed";
            this.tsm_completed.Size = new System.Drawing.Size(180, 22);
            this.tsm_completed.Text = "Completed";
            this.tsm_completed.CheckedChanged += new System.EventHandler(this.tsm_completed_CheckedChanged);
            // 
            // tsm_cancelled
            // 
            this.tsm_cancelled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.tsm_cancelled.Checked = true;
            this.tsm_cancelled.CheckOnClick = true;
            this.tsm_cancelled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsm_cancelled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.tsm_cancelled.Name = "tsm_cancelled";
            this.tsm_cancelled.Size = new System.Drawing.Size(180, 22);
            this.tsm_cancelled.Text = "Cancelled";
            this.tsm_cancelled.CheckedChanged += new System.EventHandler(this.tsm_cancelled_CheckedChanged);
            // 
            // tsm_on_hold
            // 
            this.tsm_on_hold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.tsm_on_hold.Checked = true;
            this.tsm_on_hold.CheckOnClick = true;
            this.tsm_on_hold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsm_on_hold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.tsm_on_hold.Name = "tsm_on_hold";
            this.tsm_on_hold.Size = new System.Drawing.Size(180, 22);
            this.tsm_on_hold.Text = "On-Hold";
            this.tsm_on_hold.CheckedChanged += new System.EventHandler(this.tsm_on_hold_CheckedChanged);
            // 
            // tsm_rejected
            // 
            this.tsm_rejected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.tsm_rejected.Checked = true;
            this.tsm_rejected.CheckOnClick = true;
            this.tsm_rejected.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsm_rejected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.tsm_rejected.Name = "tsm_rejected";
            this.tsm_rejected.Size = new System.Drawing.Size(180, 22);
            this.tsm_rejected.Text = "Rejected";
            this.tsm_rejected.CheckedChanged += new System.EventHandler(this.tsm_rejected_CheckedChanged);
            // 
            // lbl_filter
            // 
            this.lbl_filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_filter.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_filter.Location = new System.Drawing.Point(235, 6);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(54, 24);
            this.lbl_filter.TabIndex = 38;
            this.lbl_filter.Values.Text = "Filters";
            // 
            // contextMenuStrip_grd
            // 
            this.contextMenuStrip_grd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.contextMenuStrip_grd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenuStrip_grd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip_grd.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_grd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.contextMenuStrip_grd.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip_grd.Name = "contextMenuStrip_grd";
            this.contextMenuStrip_grd.Size = new System.Drawing.Size(118, 34);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.updateToolStripMenuItem.Image = global::SoftwareFirmManagement.Properties.Resources.Search_More;
            this.updateToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(117, 30);
            this.updateToolStripMenuItem.Text = "Details";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "Menu Item";
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // pnl_header
            // 
            this.pnl_header.Controls.Add(this.menuStrip_filters);
            this.pnl_header.Controls.Add(this.lbl_filter);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_header.Location = new System.Drawing.Point(3, 3);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(794, 39);
            this.pnl_header.TabIndex = 2;
            this.pnl_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderManagement";
            this.Text = "OrderManagement1";
            this.Load += new System.EventHandler(this.OrderManagement_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_orders.Panel)).EndInit();
            this.gbox_grd_orders.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_orders)).EndInit();
            this.gbox_grd_orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbpnl_header.ResumeLayout(false);
            this.tableLayoutPanel_filters.ResumeLayout(false);
            this.menuStrip_filters.ResumeLayout(false);
            this.menuStrip_filters.PerformLayout();
            this.contextMenuStrip_grd.ResumeLayout(false);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbox_grd_orders;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_orders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tbpnl_header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_filters;
        private System.Windows.Forms.MenuStrip menuStrip_filters;
        private System.Windows.Forms.ToolStripMenuItem filter_item_sort_by;
        private System.Windows.Forms.ToolStripMenuItem CustomerNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServiceNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filter_item_direction;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_filter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_grd;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_status_pending;
        private System.Windows.Forms.ToolStripMenuItem tsm_in_progress;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsm_completed;
        private System.Windows.Forms.ToolStripMenuItem tsm_cancelled;
        private System.Windows.Forms.ToolStripMenuItem tsm_on_hold;
        private System.Windows.Forms.ToolStripMenuItem tsm_rejected;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.Panel pnl_header;
    }
}