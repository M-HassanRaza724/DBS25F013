namespace SoftwareFirmManagement.UI
{
    partial class SalaryManagement
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_filters = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip_filters = new System.Windows.Forms.MenuStrip();
            this.filter_item_sort_by = new System.Windows.Forms.ToolStripMenuItem();
            this.MonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filter_item_direction = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_filter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_add_salary = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.contextMenuStrip_grd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgv_salaries = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbox_grd_salaries = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.gbx_add_update_salaries = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_Employee = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbEmployee = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbl_bonus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_add_update_salary = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_last_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_Amount = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBonus = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.txt_amount = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel_filters.SuspendLayout();
            this.menuStrip_filters.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip_grd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salaries)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_salaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_salaries.Panel)).BeginInit();
            this.gbox_grd_salaries.Panel.SuspendLayout();
            this.gbox_grd_salaries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_salaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_salaries.Panel)).BeginInit();
            this.gbx_add_update_salaries.Panel.SuspendLayout();
            this.gbx_add_update_salaries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(807, 50);
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
            this.tableLayoutPanel_filters.Size = new System.Drawing.Size(485, 50);
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
            this.menuStrip_filters.Location = new System.Drawing.Point(194, 0);
            this.menuStrip_filters.Name = "menuStrip_filters";
            this.menuStrip_filters.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip_filters.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip_filters.Size = new System.Drawing.Size(291, 50);
            this.menuStrip_filters.TabIndex = 1;
            this.menuStrip_filters.Text = "Filters";
            // 
            // filter_item_sort_by
            // 
            this.filter_item_sort_by.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MonthToolStripMenuItem,
            this.AmountToolStripMenuItem});
            this.filter_item_sort_by.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.filter_item_sort_by.Name = "filter_item_sort_by";
            this.filter_item_sort_by.Size = new System.Drawing.Size(56, 48);
            this.filter_item_sort_by.Text = "Sort By";
            // 
            // MonthToolStripMenuItem
            // 
            this.MonthToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MonthToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MonthToolStripMenuItem.Name = "MonthToolStripMenuItem";
            this.MonthToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.MonthToolStripMenuItem.Text = "Month";
            this.MonthToolStripMenuItem.Click += new System.EventHandler(this.MonthToolStripMenuItem_Click);
            // 
            // AmountToolStripMenuItem
            // 
            this.AmountToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.AmountToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.AmountToolStripMenuItem.Name = "AmountToolStripMenuItem";
            this.AmountToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.AmountToolStripMenuItem.Text = "Amount";
            this.AmountToolStripMenuItem.Click += new System.EventHandler(this.AmountToolStripMenuItem_Click);
            // 
            // filter_item_direction
            // 
            this.filter_item_direction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.filter_item_direction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.filter_item_direction.Name = "filter_item_direction";
            this.filter_item_direction.Size = new System.Drawing.Size(67, 48);
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
            this.lbl_filter.Location = new System.Drawing.Point(137, 13);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(54, 24);
            this.lbl_filter.TabIndex = 38;
            this.lbl_filter.Values.Text = "Filters";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_add_salary);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 50);
            this.panel2.TabIndex = 4;
            // 
            // btn_add_salary
            // 
            this.btn_add_salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_salary.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_add_salary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_salary.Enabled = false;
            this.btn_add_salary.Location = new System.Drawing.Point(20, 2);
            this.btn_add_salary.Name = "btn_add_salary";
            this.btn_add_salary.Size = new System.Drawing.Size(142, 44);
            this.btn_add_salary.TabIndex = 0;
            this.btn_add_salary.Values.Text = "Add Salary";
            this.btn_add_salary.Visible = false;
            this.btn_add_salary.Click += new System.EventHandler(this.btn_add_salary_Click);
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
            this.contextMenuStrip_grd.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip_grd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip_grd.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip_grd.Name = "contextMenuStrip_grd";
            this.contextMenuStrip_grd.Size = new System.Drawing.Size(136, 64);
            // 
            // dgv_salaries
            // 
            this.dgv_salaries.AutoGenerateColumns = false;
            this.dgv_salaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullNameColumn,
            this.Employee,
            this.salaryIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.bonusDataGridViewTextBoxColumn});
            this.dgv_salaries.DataSource = this.salaryBindingSource;
            this.dgv_salaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_salaries.Location = new System.Drawing.Point(0, 0);
            this.dgv_salaries.Name = "dgv_salaries";
            this.dgv_salaries.RowHeadersWidth = 62;
            this.dgv_salaries.Size = new System.Drawing.Size(769, 402);
            this.dgv_salaries.TabIndex = 0;
            this.dgv_salaries.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_salaries_CellMouseDown);
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullNameColumn.DataPropertyName = "EmployeeName";
            this.FullNameColumn.HeaderText = "FullName";
            this.FullNameColumn.MinimumWidth = 8;
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            this.FullNameColumn.Visible = false;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 502);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbox_grd_salaries);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 446);
            this.panel1.TabIndex = 2;
            // 
            // gbox_grd_salaries
            // 
            this.gbox_grd_salaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_grd_salaries.Location = new System.Drawing.Point(9, 3);
            this.gbox_grd_salaries.Name = "gbox_grd_salaries";
            // 
            // gbox_grd_salaries.Panel
            // 
            this.gbox_grd_salaries.Panel.Controls.Add(this.gbx_add_update_salaries);
            this.gbox_grd_salaries.Panel.Controls.Add(this.dgv_salaries);
            this.gbox_grd_salaries.Size = new System.Drawing.Size(783, 435);
            this.gbox_grd_salaries.TabIndex = 1;
            this.gbox_grd_salaries.Values.Heading = "Salaries";
            // 
            // gbx_add_update_salaries
            // 
            this.gbx_add_update_salaries.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_add_update_salaries.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlAlternate;
            this.gbx_add_update_salaries.Location = new System.Drawing.Point(172, 25);
            this.gbx_add_update_salaries.Name = "gbx_add_update_salaries";
            // 
            // gbx_add_update_salaries.Panel
            // 
            this.gbx_add_update_salaries.Panel.Controls.Add(this.lbl_Employee);
            this.gbx_add_update_salaries.Panel.Controls.Add(this.cmbEmployee);
            this.gbx_add_update_salaries.Panel.Controls.Add(this.lbl_bonus);
            this.gbx_add_update_salaries.Panel.Controls.Add(this.txtBonus);
            this.gbx_add_update_salaries.Panel.Controls.Add(this.btn_cancel);
            this.gbx_add_update_salaries.Panel.Controls.Add(this.btn_add_update_salary);
            this.gbx_add_update_salaries.Panel.Controls.Add(this.lbl_last_name);
            this.gbx_add_update_salaries.Panel.Controls.Add(this.lbl_Amount);
            this.gbx_add_update_salaries.Panel.Controls.Add(this.txt_amount);
            this.gbx_add_update_salaries.Size = new System.Drawing.Size(554, 420);
            this.gbx_add_update_salaries.TabIndex = 1;
            this.gbx_add_update_salaries.Values.Heading = "Add Salaries";
            this.gbx_add_update_salaries.Visible = false;
            // 
            // lbl_Employee
            // 
            this.lbl_Employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Employee.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_Employee.Location = new System.Drawing.Point(30, 12);
            this.lbl_Employee.Name = "lbl_Employee";
            this.lbl_Employee.Size = new System.Drawing.Size(97, 29);
            this.lbl_Employee.TabIndex = 27;
            this.lbl_Employee.Values.Text = "Employee";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEmployee.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList;
            this.cmbEmployee.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cmbEmployee.DropDownWidth = 188;
            this.cmbEmployee.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cmbEmployee.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "item 6"});
            this.cmbEmployee.Location = new System.Drawing.Point(30, 32);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(303, 37);
            this.cmbEmployee.TabIndex = 26;
            this.cmbEmployee.Text = "Employee";
            // 
            // lbl_bonus
            // 
            this.lbl_bonus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_bonus.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_bonus.Location = new System.Drawing.Point(30, 163);
            this.lbl_bonus.Name = "lbl_bonus";
            this.lbl_bonus.Size = new System.Drawing.Size(66, 29);
            this.lbl_bonus.TabIndex = 15;
            this.lbl_bonus.Values.Text = "Bonus";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(26, 262);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 50);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Values.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add_update_salary
            // 
            this.btn_add_update_salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_update_salary.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_add_update_salary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_update_salary.Location = new System.Drawing.Point(182, 262);
            this.btn_add_update_salary.Name = "btn_add_update_salary";
            this.btn_add_update_salary.Size = new System.Drawing.Size(150, 50);
            this.btn_add_update_salary.TabIndex = 2;
            this.btn_add_update_salary.Values.Text = "Add Salary";
            this.btn_add_update_salary.Click += new System.EventHandler(this.btn_add_update_salary_Click);
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_last_name.Location = new System.Drawing.Point(6, 72);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(6, 2);
            this.lbl_last_name.TabIndex = 9;
            this.lbl_last_name.Values.Text = "";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Amount.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_Amount.Location = new System.Drawing.Point(30, 82);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(83, 29);
            this.lbl_Amount.TabIndex = 8;
            this.lbl_Amount.Values.Text = "Amount";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.updateToolStripMenuItem.Image = global::SoftwareFirmManagement.Properties.Resources.Available_Updates;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.deleteToolStripMenuItem.Image = global::SoftwareFirmManagement.Properties.Resources.Trash;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // txtBonus
            // 
            this.txtBonus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBonus.BackColor = System.Drawing.Color.Transparent;
            this.txtBonus.Location = new System.Drawing.Point(26, 180);
            this.txtBonus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBonus.MultiLine = false;
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.PlaceHolder = "Bonus Amount";
            this.txtBonus.Size = new System.Drawing.Size(306, 42);
            this.txtBonus.Style = "Standalone";
            this.txtBonus.TabIndex = 14;
            this.txtBonus.TextBoxText = "Bonus Amount";
            // 
            // txt_amount
            // 
            this.txt_amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_amount.BackColor = System.Drawing.Color.Transparent;
            this.txt_amount.Location = new System.Drawing.Point(26, 99);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_amount.MultiLine = false;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.PlaceHolder = "Amount";
            this.txt_amount.Size = new System.Drawing.Size(306, 42);
            this.txt_amount.Style = "Standalone";
            this.txt_amount.TabIndex = 3;
            this.txt_amount.TextBoxText = "Amount";
            // 
            // Employee
            // 
            this.Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Employee.DataPropertyName = "Employee";
            this.Employee.HeaderText = "Employee";
            this.Employee.Name = "Employee";
            // 
            // salaryIdDataGridViewTextBoxColumn
            // 
            this.salaryIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salaryIdDataGridViewTextBoxColumn.DataPropertyName = "SalaryId";
            this.salaryIdDataGridViewTextBoxColumn.HeaderText = "SalaryId";
            this.salaryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryIdDataGridViewTextBoxColumn.Name = "salaryIdDataGridViewTextBoxColumn";
            this.salaryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bonusDataGridViewTextBoxColumn
            // 
            this.bonusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bonusDataGridViewTextBoxColumn.DataPropertyName = "Bonus";
            this.bonusDataGridViewTextBoxColumn.HeaderText = "Bonus";
            this.bonusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bonusDataGridViewTextBoxColumn.Name = "bonusDataGridViewTextBoxColumn";
            this.bonusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataSource = typeof(SoftwareFirmManagement.BL.Salary);
            // 
            // SalaryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(807, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip_filters;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalaryManagement";
            this.Text = "SalaryManagement";
            this.Load += new System.EventHandler(this.SalaryManagement_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel_filters.ResumeLayout(false);
            this.tableLayoutPanel_filters.PerformLayout();
            this.menuStrip_filters.ResumeLayout(false);
            this.menuStrip_filters.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip_grd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salaries)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_salaries.Panel)).EndInit();
            this.gbox_grd_salaries.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_salaries)).EndInit();
            this.gbox_grd_salaries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_salaries.Panel)).EndInit();
            this.gbx_add_update_salaries.Panel.ResumeLayout(false);
            this.gbx_add_update_salaries.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_salaries)).EndInit();
            this.gbx_add_update_salaries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_filters;
        private System.Windows.Forms.MenuStrip menuStrip_filters;
        private System.Windows.Forms.ToolStripMenuItem filter_item_sort_by;
        private System.Windows.Forms.ToolStripMenuItem MonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filter_item_direction;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_filter;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_add_salary;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_grd;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_salaries;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbox_grd_salaries;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_add_update_salaries;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_add_update_salary;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_last_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Amount;
        private TextBoxWithPlaceHolder txt_amount;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_bonus;
        private TextBoxWithPlaceHolder txtBonus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_Employee;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDataGridViewTextBoxColumn;
    }
}