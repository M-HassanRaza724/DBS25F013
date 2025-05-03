namespace SoftwareFirmManagement.UI
{
    partial class EmployeeManagement
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
            this.EmployeeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filter_item_direction = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_filter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_add_employee = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.contextMenuStrip_grd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_add_update_employee = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btn_cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_add_update_employee = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_last_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_full_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbox_grd_users = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgv_employees = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCredentials1 = new SoftwareFirmManagement.UI.UserCredentials();
            this.txt_full_name = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.EmployeeIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel_filters.SuspendLayout();
            this.menuStrip_filters.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip_grd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_employee.Panel)).BeginInit();
            this.gbx_add_update_employee.Panel.SuspendLayout();
            this.gbx_add_update_employee.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_users.Panel)).BeginInit();
            this.gbox_grd_users.Panel.SuspendLayout();
            this.gbox_grd_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.updateToolStripMenuItem.Image = global::SoftwareFirmManagement.Properties.Resources.Available_Updates;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1076, 61);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel_filters
            // 
            this.tableLayoutPanel_filters.ColumnCount = 2;
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel_filters.Controls.Add(this.menuStrip_filters, 1, 0);
            this.tableLayoutPanel_filters.Controls.Add(this.lbl_filter, 0, 0);
            this.tableLayoutPanel_filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_filters.Location = new System.Drawing.Point(430, 0);
            this.tableLayoutPanel_filters.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_filters.Name = "tableLayoutPanel_filters";
            this.tableLayoutPanel_filters.RowCount = 1;
            this.tableLayoutPanel_filters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_filters.Size = new System.Drawing.Size(646, 61);
            this.tableLayoutPanel_filters.TabIndex = 3;
            // 
            // menuStrip_filters
            // 
            this.menuStrip_filters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.menuStrip_filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip_filters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.menuStrip_filters.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_filters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filter_item_sort_by,
            this.filter_item_direction});
            this.menuStrip_filters.Location = new System.Drawing.Point(258, 0);
            this.menuStrip_filters.Name = "menuStrip_filters";
            this.menuStrip_filters.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip_filters.Size = new System.Drawing.Size(388, 61);
            this.menuStrip_filters.TabIndex = 1;
            this.menuStrip_filters.Text = "Filters";
            // 
            // filter_item_sort_by
            // 
            this.filter_item_sort_by.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeNameToolStripMenuItem,
            this.userNameToolStripMenuItem});
            this.filter_item_sort_by.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.filter_item_sort_by.Name = "filter_item_sort_by";
            this.filter_item_sort_by.Size = new System.Drawing.Size(63, 57);
            this.filter_item_sort_by.Text = "Sort By";
            // 
            // EmployeeNameToolStripMenuItem
            // 
            this.EmployeeNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.EmployeeNameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.EmployeeNameToolStripMenuItem.Name = "EmployeeNameToolStripMenuItem";
            this.EmployeeNameToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.EmployeeNameToolStripMenuItem.Text = "EmployeeName";
            this.EmployeeNameToolStripMenuItem.Click += new System.EventHandler(this.EmployeeNameToolStripMenuItem_Click);
            // 
            // userNameToolStripMenuItem
            // 
            this.userNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.userNameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.userNameToolStripMenuItem.Name = "userNameToolStripMenuItem";
            this.userNameToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.userNameToolStripMenuItem.Text = "UserName";
            this.userNameToolStripMenuItem.Click += new System.EventHandler(this.userNameToolStripMenuItem_Click);
            // 
            // filter_item_direction
            // 
            this.filter_item_direction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.filter_item_direction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.filter_item_direction.Name = "filter_item_direction";
            this.filter_item_direction.Size = new System.Drawing.Size(74, 57);
            this.filter_item_direction.Text = "Direction";
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.ascendingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.ascendingToolStripMenuItem.Text = "Ascending";
            this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.ascendingToolStripMenuItem_Click);
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.descendingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.descendingToolStripMenuItem.Text = "Descending";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.descendingToolStripMenuItem_Click);
            // 
            // lbl_filter
            // 
            this.lbl_filter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_filter.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_filter.Location = new System.Drawing.Point(188, 15);
            this.lbl_filter.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(66, 31);
            this.lbl_filter.TabIndex = 38;
            this.lbl_filter.Values.Text = "Filters";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_add_employee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 61);
            this.panel2.TabIndex = 4;
            // 
            // btn_add_employee
            // 
            this.btn_add_employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_employee.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_add_employee.Location = new System.Drawing.Point(26, 3);
            this.btn_add_employee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_employee.Name = "btn_add_employee";
            this.btn_add_employee.Size = new System.Drawing.Size(189, 54);
            this.btn_add_employee.TabIndex = 0;
            this.btn_add_employee.Values.Text = "Add Employee";
            this.btn_add_employee.Click += new System.EventHandler(this.btn_add_employee_Click);
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
            this.contextMenuStrip_grd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.contextMenuStrip_grd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_grd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip_grd.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip_grd.Name = "contextMenuStrip_grd";
            this.contextMenuStrip_grd.Size = new System.Drawing.Size(132, 56);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.deleteToolStripMenuItem.Image = global::SoftwareFirmManagement.Properties.Resources.Trash;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // gbx_add_update_employee
            // 
            this.gbx_add_update_employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_add_update_employee.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlAlternate;
            this.gbx_add_update_employee.Location = new System.Drawing.Point(228, 3);
            this.gbx_add_update_employee.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_add_update_employee.Name = "gbx_add_update_employee";
            // 
            // gbx_add_update_employee.Panel
            // 
            this.gbx_add_update_employee.Panel.Controls.Add(this.kryptonComboBox1);
            this.gbx_add_update_employee.Panel.Controls.Add(this.kryptonLabel1);
            this.gbx_add_update_employee.Panel.Controls.Add(this.btn_cancel);
            this.gbx_add_update_employee.Panel.Controls.Add(this.btn_add_update_employee);
            this.gbx_add_update_employee.Panel.Controls.Add(this.userCredentials1);
            this.gbx_add_update_employee.Panel.Controls.Add(this.lbl_last_name);
            this.gbx_add_update_employee.Panel.Controls.Add(this.lbl_full_name);
            this.gbx_add_update_employee.Panel.Controls.Add(this.txt_full_name);
            this.gbx_add_update_employee.Size = new System.Drawing.Size(519, 535);
            this.gbx_add_update_employee.TabIndex = 1;
            this.gbx_add_update_employee.Values.Heading = "Add Customer";
            this.gbx_add_update_employee.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(50, 399);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(200, 62);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Values.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add_update_employee
            // 
            this.btn_add_update_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_update_employee.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_add_update_employee.Location = new System.Drawing.Point(258, 399);
            this.btn_add_update_employee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_update_employee.Name = "btn_add_update_employee";
            this.btn_add_update_employee.Size = new System.Drawing.Size(200, 62);
            this.btn_add_update_employee.TabIndex = 2;
            this.btn_add_update_employee.Values.Text = "Add Employee";
            this.btn_add_update_employee.Click += new System.EventHandler(this.btn_add_update_employee_Click);
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_last_name.Location = new System.Drawing.Point(8, 89);
            this.lbl_last_name.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(6, 4);
            this.lbl_last_name.TabIndex = 9;
            this.lbl_last_name.Values.Text = "";
            // 
            // lbl_full_name
            // 
            this.lbl_full_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_full_name.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_full_name.Location = new System.Drawing.Point(55, 11);
            this.lbl_full_name.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_full_name.Name = "lbl_full_name";
            this.lbl_full_name.Size = new System.Drawing.Size(95, 31);
            this.lbl_full_name.TabIndex = 8;
            this.lbl_full_name.Values.Text = "FullName";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1076, 618);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbox_grd_users);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 549);
            this.panel1.TabIndex = 2;
            // 
            // gbox_grd_users
            // 
            this.gbox_grd_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_grd_users.Location = new System.Drawing.Point(12, 4);
            this.gbox_grd_users.Margin = new System.Windows.Forms.Padding(4);
            this.gbox_grd_users.Name = "gbox_grd_users";
            // 
            // gbox_grd_users.Panel
            // 
            this.gbox_grd_users.Panel.Controls.Add(this.gbx_add_update_employee);
            this.gbox_grd_users.Panel.Controls.Add(this.dgv_employees);
            this.gbox_grd_users.Size = new System.Drawing.Size(1044, 534);
            this.gbox_grd_users.TabIndex = 1;
            this.gbox_grd_users.Values.Heading = "Users";
            // 
            // dgv_employees
            // 
            this.dgv_employees.AutoGenerateColumns = false;
            this.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeIdColumn,
            this.UserIdColumn,
            this.FullNameColumn,
            this.UsernameColumn,
            this.EmailColumn,
            this.PasswordColumn,
            this.RoleIdColumn,
            this.RoleColumn});
            this.dgv_employees.DataSource = this.EmployeeBindingSource;
            this.dgv_employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_employees.Location = new System.Drawing.Point(0, 0);
            this.dgv_employees.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_employees.Name = "dgv_employees";
            this.dgv_employees.RowHeadersWidth = 51;
            this.dgv_employees.Size = new System.Drawing.Size(1030, 496);
            this.dgv_employees.TabIndex = 0;
            this.dgv_employees.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_employees_CellMouseDown);
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullNameColumn.DataPropertyName = "Name";
            this.FullNameColumn.HeaderText = "FullName";
            this.FullNameColumn.MinimumWidth = 6;
            this.FullNameColumn.Name = "FullNameColumn";
            // 
            // userCredentials1
            // 
            this.userCredentials1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userCredentials1.BackColor = System.Drawing.Color.Transparent;
            this.userCredentials1.Email = "Email";
            this.userCredentials1.EmailPlaceHolder = "Email";
            this.userCredentials1.Location = new System.Drawing.Point(51, 94);
            this.userCredentials1.Margin = new System.Windows.Forms.Padding(5);
            this.userCredentials1.Name = "userCredentials1";
            this.userCredentials1.Password = "Password";
            this.userCredentials1.PasswordPlaceHolder = "Password";
            this.userCredentials1.Size = new System.Drawing.Size(367, 233);
            this.userCredentials1.TabIndex = 12;
            this.userCredentials1.Username = "Username";
            this.userCredentials1.UsernamePlaceHolder = "Username";
            // 
            // txt_full_name
            // 
            this.txt_full_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_full_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_full_name.Location = new System.Drawing.Point(51, 32);
            this.txt_full_name.Margin = new System.Windows.Forms.Padding(5);
            this.txt_full_name.Name = "txt_full_name";
            this.txt_full_name.PlaceHolder = "FullName";
            this.txt_full_name.Size = new System.Drawing.Size(367, 52);
            this.txt_full_name.Style = "Standalone";
            this.txt_full_name.TabIndex = 3;
            this.txt_full_name.TextBoxText = "FullName";
            // 
            // EmployeeIdColumn
            // 
            this.EmployeeIdColumn.DataPropertyName = "EmployeeId";
            this.EmployeeIdColumn.HeaderText = "EmployeeId";
            this.EmployeeIdColumn.MinimumWidth = 6;
            this.EmployeeIdColumn.Name = "EmployeeIdColumn";
            this.EmployeeIdColumn.Visible = false;
            this.EmployeeIdColumn.Width = 125;
            // 
            // UserIdColumn
            // 
            this.UserIdColumn.DataPropertyName = "UserId";
            this.UserIdColumn.HeaderText = "UserId";
            this.UserIdColumn.MinimumWidth = 6;
            this.UserIdColumn.Name = "UserIdColumn";
            this.UserIdColumn.Visible = false;
            this.UserIdColumn.Width = 125;
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UsernameColumn.DataPropertyName = "Username";
            this.UsernameColumn.HeaderText = "Username";
            this.UsernameColumn.MinimumWidth = 6;
            this.UsernameColumn.Name = "UsernameColumn";
            // 
            // EmailColumn
            // 
            this.EmailColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailColumn.DataPropertyName = "Email";
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.MinimumWidth = 6;
            this.EmailColumn.Name = "EmailColumn";
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.DataPropertyName = "Password";
            this.PasswordColumn.HeaderText = "Password";
            this.PasswordColumn.MinimumWidth = 6;
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.Visible = false;
            this.PasswordColumn.Width = 125;
            // 
            // RoleIdColumn
            // 
            this.RoleIdColumn.DataPropertyName = "RoleId";
            this.RoleIdColumn.HeaderText = "RoleId";
            this.RoleIdColumn.MinimumWidth = 6;
            this.RoleIdColumn.Name = "RoleIdColumn";
            this.RoleIdColumn.Visible = false;
            this.RoleIdColumn.Width = 125;
            // 
            // RoleColumn
            // 
            this.RoleColumn.DataPropertyName = "Role";
            this.RoleColumn.HeaderText = "Role";
            this.RoleColumn.MinimumWidth = 6;
            this.RoleColumn.Name = "RoleColumn";
            this.RoleColumn.Visible = false;
            this.RoleColumn.Width = 125;
            // 
            // EmployeeBindingSource
            // 
            this.EmployeeBindingSource.DataSource = typeof(SoftwareFirmManagement.BL.Employee);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(55, 326);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(115, 31);
            this.kryptonLabel1.TabIndex = 15;
            this.kryptonLabel1.Values.Text = "Designation";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 357;
            this.kryptonComboBox1.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.kryptonComboBox1.Location = new System.Drawing.Point(55, 352);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(369, 40);
            this.kryptonComboBox1.TabIndex = 2;
            this.kryptonComboBox1.Text = "Designation";
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1076, 618);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip_filters;
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel_filters.ResumeLayout(false);
            this.tableLayoutPanel_filters.PerformLayout();
            this.menuStrip_filters.ResumeLayout(false);
            this.menuStrip_filters.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip_grd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_employee.Panel)).EndInit();
            this.gbx_add_update_employee.Panel.ResumeLayout(false);
            this.gbx_add_update_employee.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_employee)).EndInit();
            this.gbx_add_update_employee.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_users.Panel)).EndInit();
            this.gbox_grd_users.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_users)).EndInit();
            this.gbox_grd_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_filters;
        private System.Windows.Forms.MenuStrip menuStrip_filters;
        private System.Windows.Forms.ToolStripMenuItem filter_item_sort_by;
        private System.Windows.Forms.ToolStripMenuItem EmployeeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filter_item_direction;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_filter;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_add_employee;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_grd;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_add_update_employee;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_add_update_employee;
        private UserCredentials userCredentials1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_last_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_full_name;
        private TextBoxWithPlaceHolder txt_full_name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbox_grd_users;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
    }
}