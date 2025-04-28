namespace SoftwareFirmManagement.UI
{
    partial class CustomerManagement
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbx_direction = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.rdo_sort_desc = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdo_sort_asc = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.gbx_sort_by = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rdo_sort_username = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdo_sort_customer_name = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdo_sort_customer_id = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.gbox_grd_users = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgv_customers = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.Delete = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_filters = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_sort = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.cbtn_direction = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.lbl_filter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_direction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_direction.Panel)).BeginInit();
            this.gbx_direction.Panel.SuspendLayout();
            this.gbx_direction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_sort_by)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_sort_by.Panel)).BeginInit();
            this.gbx_sort_by.Panel.SuspendLayout();
            this.gbx_sort_by.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_users.Panel)).BeginInit();
            this.gbox_grd_users.Panel.SuspendLayout();
            this.gbox_grd_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel_filters.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbx_direction);
            this.panel1.Controls.Add(this.gbx_sort_by);
            this.panel1.Controls.Add(this.gbox_grd_users);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 446);
            this.panel1.TabIndex = 2;
            // 
            // gbx_direction
            // 
            this.gbx_direction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbx_direction.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone;
            this.gbx_direction.Location = new System.Drawing.Point(609, 0);
            this.gbx_direction.Name = "gbx_direction";
            // 
            // gbx_direction.Panel
            // 
            this.gbx_direction.Panel.Controls.Add(this.rdo_sort_desc);
            this.gbx_direction.Panel.Controls.Add(this.rdo_sort_asc);
            this.gbx_direction.Size = new System.Drawing.Size(149, 87);
            this.gbx_direction.TabIndex = 1;
            this.gbx_direction.Visible = false;
            // 
            // rdo_sort_desc
            // 
            this.rdo_sort_desc.AutoCheck = false;
            this.rdo_sort_desc.Images.CheckedNormal = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_desc.Images.CheckedPressed = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_desc.Images.CheckedTracking = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_desc.Images.Common = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_desc.Images.UncheckedNormal = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_desc.Images.UncheckedPressed = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_desc.Images.UncheckedTracking = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_desc.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.rdo_sort_desc.Location = new System.Drawing.Point(8, 37);
            this.rdo_sort_desc.Name = "rdo_sort_desc";
            this.rdo_sort_desc.Size = new System.Drawing.Size(101, 23);
            this.rdo_sort_desc.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_sort_desc.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_sort_desc.TabIndex = 28;
            this.rdo_sort_desc.Values.Text = "Descending";
            // 
            // rdo_sort_asc
            // 
            this.rdo_sort_asc.Images.CheckedNormal = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_asc.Images.CheckedPressed = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_asc.Images.CheckedTracking = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_asc.Images.Common = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_asc.Images.UncheckedNormal = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_asc.Images.UncheckedPressed = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_asc.Images.UncheckedTracking = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_asc.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.rdo_sort_asc.Location = new System.Drawing.Point(8, 8);
            this.rdo_sort_asc.Name = "rdo_sort_asc";
            this.rdo_sort_asc.Size = new System.Drawing.Size(94, 23);
            this.rdo_sort_asc.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_sort_asc.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_sort_asc.TabIndex = 27;
            this.rdo_sort_asc.Values.Text = "Ascending";
            // 
            // gbx_sort_by
            // 
            this.gbx_sort_by.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbx_sort_by.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone;
            this.gbx_sort_by.Location = new System.Drawing.Point(375, 0);
            this.gbx_sort_by.Name = "gbx_sort_by";
            // 
            // gbx_sort_by.Panel
            // 
            this.gbx_sort_by.Panel.Controls.Add(this.rdo_sort_username);
            this.gbx_sort_by.Panel.Controls.Add(this.rdo_sort_customer_name);
            this.gbx_sort_by.Panel.Controls.Add(this.rdo_sort_customer_id);
            this.gbx_sort_by.Size = new System.Drawing.Size(133, 103);
            this.gbx_sort_by.TabIndex = 1;
            this.gbx_sort_by.Values.Heading = "";
            this.gbx_sort_by.Visible = false;
            // 
            // rdo_sort_username
            // 
            this.rdo_sort_username.AutoCheck = false;
            this.rdo_sort_username.Images.CheckedNormal = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_username.Images.CheckedPressed = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_username.Images.CheckedTracking = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_username.Images.Common = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_username.Images.UncheckedNormal = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_username.Images.UncheckedPressed = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_username.Images.UncheckedTracking = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_username.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.rdo_sort_username.Location = new System.Drawing.Point(-3, 54);
            this.rdo_sort_username.Name = "rdo_sort_username";
            this.rdo_sort_username.Size = new System.Drawing.Size(91, 23);
            this.rdo_sort_username.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_sort_username.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_sort_username.TabIndex = 27;
            this.rdo_sort_username.Values.Text = "Username";
            // 
            // rdo_sort_customer_name
            // 
            this.rdo_sort_customer_name.AutoCheck = false;
            this.rdo_sort_customer_name.Images.CheckedNormal = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_customer_name.Images.CheckedPressed = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_customer_name.Images.CheckedTracking = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_customer_name.Images.Common = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_customer_name.Images.UncheckedNormal = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_customer_name.Images.UncheckedPressed = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_customer_name.Images.UncheckedTracking = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_customer_name.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.rdo_sort_customer_name.Location = new System.Drawing.Point(-3, 31);
            this.rdo_sort_customer_name.Name = "rdo_sort_customer_name";
            this.rdo_sort_customer_name.Size = new System.Drawing.Size(124, 23);
            this.rdo_sort_customer_name.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_sort_customer_name.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_sort_customer_name.TabIndex = 26;
            this.rdo_sort_customer_name.Values.Text = "CustomerName";
            // 
            // rdo_sort_customer_id
            // 
            this.rdo_sort_customer_id.Images.CheckedNormal = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_customer_id.Images.CheckedPressed = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_customer_id.Images.CheckedTracking = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_customer_id.Images.Common = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_customer_id.Images.UncheckedNormal = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_customer_id.Images.UncheckedPressed = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_customer_id.Images.UncheckedTracking = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_customer_id.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.rdo_sort_customer_id.Location = new System.Drawing.Point(-3, 7);
            this.rdo_sort_customer_id.Name = "rdo_sort_customer_id";
            this.rdo_sort_customer_id.Size = new System.Drawing.Size(100, 23);
            this.rdo_sort_customer_id.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_sort_customer_id.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_sort_customer_id.TabIndex = 25;
            this.rdo_sort_customer_id.Values.Text = "CustomerId";
            // 
            // gbox_grd_users
            // 
            this.gbox_grd_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_grd_users.Location = new System.Drawing.Point(9, 3);
            this.gbox_grd_users.Name = "gbox_grd_users";
            // 
            // gbox_grd_users.Panel
            // 
            this.gbox_grd_users.Panel.Controls.Add(this.dgv_customers);
            this.gbox_grd_users.Size = new System.Drawing.Size(783, 434);
            this.gbox_grd_users.TabIndex = 1;
            this.gbox_grd_users.Values.Heading = "Users";
            // 
            // dgv_customers
            // 
            this.dgv_customers.AutoGenerateColumns = false;
            this.dgv_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.FullName,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Details,
            this.Delete});
            this.dgv_customers.DataSource = this.customerBindingSource;
            this.dgv_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_customers.Location = new System.Drawing.Point(0, 0);
            this.dgv_customers.Name = "dgv_customers";
            this.dgv_customers.Size = new System.Drawing.Size(769, 401);
            this.dgv_customers.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "Name";
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn3.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn4.HeaderText = "Username";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn6.HeaderText = "Password";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RoleId";
            this.dataGridViewTextBoxColumn7.HeaderText = "RoleId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn8.HeaderText = "Role";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Details.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.Details.HeaderText = "Update";
            this.Details.MinimumWidth = 100;
            this.Details.Name = "Details";
            this.Details.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 100;
            this.Delete.Name = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SoftwareFirmManagement.BL.Customer);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
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
            this.tableLayoutPanel_filters.ColumnCount = 3;
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel_filters.Controls.Add(this.cbx_sort, 1, 0);
            this.tableLayoutPanel_filters.Controls.Add(this.cbtn_direction, 2, 0);
            this.tableLayoutPanel_filters.Controls.Add(this.lbl_filter, 0, 0);
            this.tableLayoutPanel_filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_filters.Location = new System.Drawing.Point(161, 0);
            this.tableLayoutPanel_filters.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_filters.Name = "tableLayoutPanel_filters";
            this.tableLayoutPanel_filters.RowCount = 1;
            this.tableLayoutPanel_filters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_filters.Size = new System.Drawing.Size(646, 50);
            this.tableLayoutPanel_filters.TabIndex = 3;
            // 
            // cbx_sort
            // 
            this.cbx_sort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_sort.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cbx_sort.Location = new System.Drawing.Point(214, 6);
            this.cbx_sort.Name = "cbx_sort";
            this.cbx_sort.Size = new System.Drawing.Size(136, 38);
            this.cbx_sort.TabIndex = 36;
            this.cbx_sort.Values.ExtraText = "▲";
            this.cbx_sort.Values.Text = "Sort By";
            this.cbx_sort.CheckedChanged += new System.EventHandler(this.cbx_sort_CheckedChanged);
            // 
            // cbtn_direction
            // 
            this.cbtn_direction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtn_direction.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cbtn_direction.Location = new System.Drawing.Point(448, 6);
            this.cbtn_direction.Name = "cbtn_direction";
            this.cbtn_direction.Size = new System.Drawing.Size(152, 38);
            this.cbtn_direction.TabIndex = 35;
            this.cbtn_direction.Values.ExtraText = "▲";
            this.cbtn_direction.Values.Text = "Direction";
            this.cbtn_direction.CheckedChanged += new System.EventHandler(this.cbtn_direction_CheckedChanged);
            // 
            // lbl_filter
            // 
            this.lbl_filter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_filter.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_filter.Location = new System.Drawing.Point(104, 12);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(54, 26);
            this.lbl_filter.TabIndex = 38;
            this.lbl_filter.Values.Text = "Filters";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kryptonButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 50);
            this.panel2.TabIndex = 4;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.kryptonButton1.Location = new System.Drawing.Point(12, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(142, 44);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "Add Customers";
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(807, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerManagement";
            this.Text = "UserManagement";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_direction.Panel)).EndInit();
            this.gbx_direction.Panel.ResumeLayout(false);
            this.gbx_direction.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_direction)).EndInit();
            this.gbx_direction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_sort_by.Panel)).EndInit();
            this.gbx_sort_by.Panel.ResumeLayout(false);
            this.gbx_sort_by.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_sort_by)).EndInit();
            this.gbx_sort_by.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_users.Panel)).EndInit();
            this.gbox_grd_users.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_users)).EndInit();
            this.gbox_grd_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel_filters.ResumeLayout(false);
            this.tableLayoutPanel_filters.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_customers;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbox_grd_users;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton cbtn_direction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_filters;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton cbx_sort;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_filter;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_sort_by;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup gbx_direction;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_sort_customer_name;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_sort_customer_id;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_sort_desc;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_sort_asc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_sort_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn Details;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}