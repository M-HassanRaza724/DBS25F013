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
            this.rdo_sort_descending = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdo_sort_ascending = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.gbx_sort_by = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rdo_sort_username = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdo_username = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdo_customer_id = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.gbox_grd_users = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.grd_users = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.Delete = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.grd_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            this.rdo_sort_descending.Location = new System.Drawing.Point(8, 37);
            this.rdo_sort_descending.Name = "rdo_sort_descending";
            this.rdo_sort_descending.Size = new System.Drawing.Size(96, 20);
            this.rdo_sort_descending.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_sort_descending.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_sort_descending.TabIndex = 28;
            this.rdo_sort_descending.Values.Text = "Descending";
            // 
            // rdo_sort_ascending
            // 
            this.rdo_sort_ascending.Images.CheckedNormal = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_ascending.Images.CheckedPressed = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_ascending.Images.CheckedTracking = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_ascending.Images.Common = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_ascending.Images.UncheckedNormal = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_sort_ascending.Images.UncheckedPressed = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_sort_ascending.Images.UncheckedTracking = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_sort_ascending.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.rdo_sort_ascending.Location = new System.Drawing.Point(8, 8);
            this.rdo_sort_ascending.Name = "rdo_sort_ascending";
            this.rdo_sort_ascending.Size = new System.Drawing.Size(88, 20);
            this.rdo_sort_ascending.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_sort_ascending.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_sort_ascending.TabIndex = 27;
            this.rdo_sort_ascending.Values.Text = "Ascending";
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
            this.gbx_sort_by.Panel.Controls.Add(this.rdo_username);
            this.gbx_sort_by.Panel.Controls.Add(this.rdo_customer_id);
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
            this.rdo_sort_username.Size = new System.Drawing.Size(86, 20);
            this.rdo_sort_username.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_sort_username.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_sort_username.TabIndex = 27;
            this.rdo_sort_username.Values.Text = "Username";
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
            this.rdo_username.Location = new System.Drawing.Point(-3, 31);
            this.rdo_username.Name = "rdo_username";
            this.rdo_username.Size = new System.Drawing.Size(117, 20);
            this.rdo_username.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_username.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_username.TabIndex = 26;
            this.rdo_username.Values.Text = "CustomerName";
            // 
            // rdo_customer_id
            // 
            this.rdo_customer_id.Images.CheckedNormal = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_customer_id.Images.CheckedPressed = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_customer_id.Images.CheckedTracking = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_customer_id.Images.Common = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_customer_id.Images.UncheckedNormal = global::SoftwareFirmManagement.Properties.Resources.unchecked_normal_small;
            this.rdo_customer_id.Images.UncheckedPressed = global::SoftwareFirmManagement.Properties.Resources.checked_hover_small;
            this.rdo_customer_id.Images.UncheckedTracking = global::SoftwareFirmManagement.Properties.Resources.unchecked_hover_small;
            this.rdo_customer_id.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.Custom1;
            this.rdo_customer_id.Location = new System.Drawing.Point(-3, 7);
            this.rdo_customer_id.Name = "rdo_customer_id";
            this.rdo_customer_id.Size = new System.Drawing.Size(95, 20);
            this.rdo_customer_id.StateCommon.Image.ImageColorMap = System.Drawing.Color.White;
            this.rdo_customer_id.StateCommon.Image.ImageColorTo = System.Drawing.Color.White;
            this.rdo_customer_id.TabIndex = 25;
            this.rdo_customer_id.Values.Text = "CustomerId";
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
            this.grd_users.Size = new System.Drawing.Size(779, 410);
            this.grd_users.TabIndex = 0;
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
            this.passwordDataGridViewTextBoxColumn.Visible = false;
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
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(SoftwareFirmManagement.BL.User);
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
            this.cbx_sort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbx_sort_MouseClick);
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
            this.cbtn_direction.Click += new System.EventHandler(this.cbtn_direction_Click);
            // 
            // lbl_filter
            // 
            this.lbl_filter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_filter.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_filter.Location = new System.Drawing.Point(93, 10);
            this.lbl_filter.Name = "lbl_filter";
            this.lbl_filter.Size = new System.Drawing.Size(65, 29);
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
            ((System.ComponentModel.ISupportInitialize)(this.grd_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
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
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_filter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_sort_by;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup gbx_direction;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_username;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_customer_id;
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
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdo_sort_username;
    }
}