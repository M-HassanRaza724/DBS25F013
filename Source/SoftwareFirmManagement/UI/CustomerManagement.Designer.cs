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
            this.gbx_roles = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.clbx_roles = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.gbx_sort_by = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rdo_role = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdo_username = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdo_user_id = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.gbox_grd_users = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.grd_users = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbx_direction = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.rdo_sort_descending = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdo_sort_ascending = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_filters = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_sort = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.cbtn_roles = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.cbtn_direction = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.Delete = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_roles.Panel)).BeginInit();
            this.gbx_roles.Panel.SuspendLayout();
            this.gbx_roles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_sort_by)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_sort_by.Panel)).BeginInit();
            this.gbx_sort_by.Panel.SuspendLayout();
            this.gbx_sort_by.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_users.Panel)).BeginInit();
            this.gbox_grd_users.Panel.SuspendLayout();
            this.gbox_grd_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_direction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_direction.Panel)).BeginInit();
            this.gbx_direction.Panel.SuspendLayout();
            this.gbx_direction.SuspendLayout();
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
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbx_roles);
            this.panel1.Controls.Add(this.gbx_sort_by);
            this.panel1.Controls.Add(this.gbox_grd_users);
            this.panel1.Controls.Add(this.gbx_direction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 446);
            this.panel1.TabIndex = 2;
            // 
            // gbx_roles
            // 
            this.gbx_roles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbx_roles.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone;
            this.gbx_roles.Location = new System.Drawing.Point(660, 1);
            this.gbx_roles.Name = "gbx_roles";
            // 
            // gbx_roles.Panel
            // 
            this.gbx_roles.Panel.Controls.Add(this.clbx_roles);
            this.gbx_roles.Size = new System.Drawing.Size(122, 112);
            this.gbx_roles.TabIndex = 2;
            this.gbx_roles.Values.Heading = "";
            this.gbx_roles.Visible = false;
            // 
            // clbx_roles
            // 
            this.clbx_roles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbx_roles.Items.AddRange(new object[] {
            "Admin",
            "Customer",
            "Employee",
            "DepartmentHead"});
            this.clbx_roles.Location = new System.Drawing.Point(0, 0);
            this.clbx_roles.Name = "clbx_roles";
            this.clbx_roles.Padding = new System.Windows.Forms.Padding(0);
            this.clbx_roles.Size = new System.Drawing.Size(104, 94);
            this.clbx_roles.TabIndex = 0;
            // 
            // gbx_sort_by
            // 
            this.gbx_sort_by.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbx_sort_by.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone;
            this.gbx_sort_by.Location = new System.Drawing.Point(312, -2);
            this.gbx_sort_by.Name = "gbx_sort_by";
            // 
            // gbx_sort_by.Panel
            // 
            this.gbx_sort_by.Panel.Controls.Add(this.rdo_role);
            this.gbx_sort_by.Panel.Controls.Add(this.rdo_username);
            this.gbx_sort_by.Panel.Controls.Add(this.rdo_user_id);
            this.gbx_sort_by.Size = new System.Drawing.Size(133, 113);
            this.gbx_sort_by.TabIndex = 1;
            this.gbx_sort_by.Values.Heading = "";
            this.gbx_sort_by.Visible = false;
            // 
            // rdo_role
            // 
            this.rdo_role.Images.CheckedNormal = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_role.Images.CheckedPressed = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_role.Images.CheckedTracking = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_role.Images.Common = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_role.Images.UncheckedNormal = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_role.Images.UncheckedPressed = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_role.Images.UncheckedTracking = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_role.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.rdo_role.Location = new System.Drawing.Point(13, 65);
            this.rdo_role.Name = "rdo_role";
            this.rdo_role.Size = new System.Drawing.Size(58, 23);
            this.rdo_role.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_role.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_role.TabIndex = 27;
            this.rdo_role.Values.Text = "Role";
            // 
            // rdo_username
            // 
            this.rdo_username.AutoCheck = false;
            this.rdo_username.Images.CheckedNormal = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_username.Images.CheckedPressed = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_username.Images.CheckedTracking = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_username.Images.Common = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_username.Images.UncheckedNormal = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_username.Images.UncheckedPressed = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_username.Images.UncheckedTracking = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_username.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.rdo_username.Location = new System.Drawing.Point(13, 36);
            this.rdo_username.Name = "rdo_username";
            this.rdo_username.Size = new System.Drawing.Size(91, 23);
            this.rdo_username.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_username.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_username.TabIndex = 26;
            this.rdo_username.Values.Text = "Username";
            // 
            // rdo_user_id
            // 
            this.rdo_user_id.Images.CheckedNormal = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_user_id.Images.CheckedPressed = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_user_id.Images.CheckedTracking = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_user_id.Images.Common = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_user_id.Images.UncheckedNormal = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_user_id.Images.UncheckedPressed = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_user_id.Images.UncheckedTracking = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_user_id.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.rdo_user_id.Location = new System.Drawing.Point(13, 7);
            this.rdo_user_id.Name = "rdo_user_id";
            this.rdo_user_id.Size = new System.Drawing.Size(70, 23);
            this.rdo_user_id.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_user_id.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_user_id.TabIndex = 25;
            this.rdo_user_id.Values.Text = "UserId";
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
            this.gbox_grd_users.Panel.Controls.Add(this.grd_users);
            this.gbox_grd_users.Size = new System.Drawing.Size(783, 434);
            this.gbox_grd_users.TabIndex = 1;
            this.gbox_grd_users.Values.Heading = "Users";
            // 
            // grd_users
            // 
            this.grd_users.AutoGenerateColumns = false;
            this.grd_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.Details,
            this.Delete});
            this.grd_users.DataSource = this.userBindingSource;
            this.grd_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_users.Location = new System.Drawing.Point(0, 0);
            this.grd_users.Name = "grd_users";
            this.grd_users.Size = new System.Drawing.Size(769, 401);
            this.grd_users.TabIndex = 0;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(SoftwareFirmManagement.BL.User);
            // 
            // gbx_direction
            // 
            this.gbx_direction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbx_direction.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone;
            this.gbx_direction.Location = new System.Drawing.Point(476, 0);
            this.gbx_direction.Name = "gbx_direction";
            // 
            // gbx_direction.Panel
            // 
            this.gbx_direction.Panel.Controls.Add(this.rdo_sort_descending);
            this.gbx_direction.Panel.Controls.Add(this.rdo_sort_ascending);
            this.gbx_direction.Size = new System.Drawing.Size(149, 87);
            this.gbx_direction.TabIndex = 1;
            this.gbx_direction.Visible = false;
            // 
            // rdo_sort_descending
            // 
            this.rdo_sort_descending.AutoCheck = false;
            this.rdo_sort_descending.Images.CheckedNormal = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_descending.Images.CheckedPressed = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_descending.Images.CheckedTracking = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_descending.Images.Common = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_descending.Images.UncheckedNormal = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_descending.Images.UncheckedPressed = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_descending.Images.UncheckedTracking = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_descending.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.rdo_sort_descending.Location = new System.Drawing.Point(17, 37);
            this.rdo_sort_descending.Name = "rdo_sort_descending";
            this.rdo_sort_descending.Size = new System.Drawing.Size(101, 23);
            this.rdo_sort_descending.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_sort_descending.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_sort_descending.TabIndex = 28;
            this.rdo_sort_descending.Values.Text = "Descending";
            // 
            // rdo_sort_ascending
            // 
            this.rdo_sort_ascending.Checked = true;
            this.rdo_sort_ascending.Images.CheckedNormal = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_ascending.Images.CheckedPressed = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_ascending.Images.CheckedTracking = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_ascending.Images.Common = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_ascending.Images.UncheckedNormal = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_ascending.Images.UncheckedPressed = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_ascending.Images.UncheckedTracking = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_ascending.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.rdo_sort_ascending.Location = new System.Drawing.Point(17, 8);
            this.rdo_sort_ascending.Name = "rdo_sort_ascending";
            this.rdo_sort_ascending.Size = new System.Drawing.Size(94, 23);
            this.rdo_sort_ascending.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_sort_ascending.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_sort_ascending.TabIndex = 27;
            this.rdo_sort_ascending.Values.Text = "Ascending";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel_filters, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(807, 50);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel_filters
            // 
            this.tableLayoutPanel_filters.ColumnCount = 4;
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_filters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_filters.Controls.Add(this.cbx_sort, 1, 0);
            this.tableLayoutPanel_filters.Controls.Add(this.cbtn_roles, 3, 0);
            this.tableLayoutPanel_filters.Controls.Add(this.cbtn_direction, 2, 0);
            this.tableLayoutPanel_filters.Controls.Add(this.kryptonLabel1, 0, 0);
            this.tableLayoutPanel_filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_filters.Location = new System.Drawing.Point(242, 0);
            this.tableLayoutPanel_filters.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_filters.Name = "tableLayoutPanel_filters";
            this.tableLayoutPanel_filters.RowCount = 1;
            this.tableLayoutPanel_filters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_filters.Size = new System.Drawing.Size(565, 50);
            this.tableLayoutPanel_filters.TabIndex = 3;
            // 
            // cbx_sort
            // 
            this.cbx_sort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_sort.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cbx_sort.Enabled = false;
            this.cbx_sort.Location = new System.Drawing.Point(72, 6);
            this.cbx_sort.Name = "cbx_sort";
            this.cbx_sort.Size = new System.Drawing.Size(136, 38);
            this.cbx_sort.TabIndex = 36;
            this.cbx_sort.Values.ExtraText = "▲";
            this.cbx_sort.Values.Text = "Sort By";
            this.cbx_sort.Visible = false;
            // 
            // cbtn_roles
            // 
            this.cbtn_roles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtn_roles.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cbtn_roles.Location = new System.Drawing.Point(417, 6);
            this.cbtn_roles.Name = "cbtn_roles";
            this.cbtn_roles.Size = new System.Drawing.Size(125, 38);
            this.cbtn_roles.TabIndex = 37;
            this.cbtn_roles.Values.ExtraText = "▲";
            this.cbtn_roles.Values.Text = "Roles";
            // 
            // cbtn_direction
            // 
            this.cbtn_direction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtn_direction.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cbtn_direction.Location = new System.Drawing.Point(233, 6);
            this.cbtn_direction.Name = "cbtn_direction";
            this.cbtn_direction.Size = new System.Drawing.Size(152, 38);
            this.cbtn_direction.TabIndex = 35;
            this.cbtn_direction.Values.ExtraText = "▲";
            this.cbtn_direction.Values.Text = "Direction";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(50, 26);
            this.kryptonLabel1.TabIndex = 38;
            this.kryptonLabel1.Values.Text = "Filters";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kryptonButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 50);
            this.panel2.TabIndex = 4;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.kryptonButton1.Location = new System.Drawing.Point(46, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(142, 44);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "Create Users";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Details.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.Details.HeaderText = "Update";
            this.Details.MinimumWidth = 100;
            this.Details.Name = "Details";
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delete.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 100;
            this.Delete.Name = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(807, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_roles.Panel)).EndInit();
            this.gbx_roles.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_roles)).EndInit();
            this.gbx_roles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_sort_by.Panel)).EndInit();
            this.gbx_sort_by.Panel.ResumeLayout(false);
            this.gbx_sort_by.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_sort_by)).EndInit();
            this.gbx_sort_by.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_users.Panel)).EndInit();
            this.gbox_grd_users.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbox_grd_users)).EndInit();
            this.gbox_grd_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_direction.Panel)).EndInit();
            this.gbx_direction.Panel.ResumeLayout(false);
            this.gbx_direction.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_direction)).EndInit();
            this.gbx_direction.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel_filters.ResumeLayout(false);
            this.tableLayoutPanel_filters.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grd_users;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbox_grd_users;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton cbtn_direction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_filters;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton cbx_sort;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton cbtn_roles;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_sort_by;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_roles;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup gbx_direction;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_role;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_username;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_user_id;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox clbx_roles;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_sort_descending;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_sort_ascending;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn Details;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn Delete;
    }
}