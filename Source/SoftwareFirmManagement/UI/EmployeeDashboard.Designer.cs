namespace SoftwareFirmManagement.UI
{
    partial class EmployeeDashboard
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
            this.dgv_pending_orders = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbx_pending_orders = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tlpnl_main = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_email_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_name_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonGroupBox4 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_title = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbx_completed_orders = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgv_completed_orders = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonDataGridView3 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.orderDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pending_orders)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_pending_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_pending_orders.Panel)).BeginInit();
            this.gbx_pending_orders.Panel.SuspendLayout();
            this.gbx_pending_orders.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tlpnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).BeginInit();
            this.kryptonGroupBox4.Panel.SuspendLayout();
            this.kryptonGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_completed_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_completed_orders.Panel)).BeginInit();
            this.gbx_completed_orders.Panel.SuspendLayout();
            this.gbx_completed_orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_completed_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pending_orders
            // 
            this.dgv_pending_orders.AllowUserToAddRows = false;
            this.dgv_pending_orders.AllowUserToDeleteRows = false;
            this.dgv_pending_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pending_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pending_orders.Location = new System.Drawing.Point(0, 0);
            this.dgv_pending_orders.Name = "dgv_pending_orders";
            this.dgv_pending_orders.ReadOnly = true;
            this.dgv_pending_orders.Size = new System.Drawing.Size(357, 162);
            this.dgv_pending_orders.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kryptonGroupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 225);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbx_pending_orders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(320, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 225);
            this.panel1.TabIndex = 1;
            // 
            // gbx_pending_orders
            // 
            this.gbx_pending_orders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_pending_orders.Location = new System.Drawing.Point(26, 18);
            this.gbx_pending_orders.Name = "gbx_pending_orders";
            // 
            // gbx_pending_orders.Panel
            // 
            this.gbx_pending_orders.Panel.Controls.Add(this.kryptonDataGridView1);
            this.gbx_pending_orders.Panel.Controls.Add(this.dgv_pending_orders);
            this.gbx_pending_orders.Size = new System.Drawing.Size(371, 195);
            this.gbx_pending_orders.TabIndex = 0;
            this.gbx_pending_orders.Values.Heading = "Pending Orders";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbx_completed_orders);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 225);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 225);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.kryptonGroupBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(320, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 225);
            this.panel4.TabIndex = 4;
            // 
            // tlpnl_main
            // 
            this.tlpnl_main.ColumnCount = 2;
            this.tlpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpnl_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpnl_main.Controls.Add(this.panel4, 1, 0);
            this.tlpnl_main.Controls.Add(this.panel3, 0, 1);
            this.tlpnl_main.Controls.Add(this.panel2, 0, 0);
            this.tlpnl_main.Controls.Add(this.panel1, 1, 1);
            this.tlpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnl_main.Location = new System.Drawing.Point(0, 0);
            this.tlpnl_main.Margin = new System.Windows.Forms.Padding(0);
            this.tlpnl_main.Name = "tlpnl_main";
            this.tlpnl_main.RowCount = 2;
            this.tlpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnl_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpnl_main.Size = new System.Drawing.Size(800, 450);
            this.tlpnl_main.TabIndex = 2;
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonGroupBox3.Location = new System.Drawing.Point(26, 12);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.lbl_email_text);
            this.kryptonGroupBox3.Panel.Controls.Add(this.pictureBox1);
            this.kryptonGroupBox3.Panel.Controls.Add(this.lbl_name_text);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox3.Panel.Controls.Add(this.lbl_name);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(371, 186);
            this.kryptonGroupBox3.TabIndex = 6;
            this.kryptonGroupBox3.Values.Heading = "";
            // 
            // lbl_email_text
            // 
            this.lbl_email_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_email_text.Location = new System.Drawing.Point(202, 111);
            this.lbl_email_text.Name = "lbl_email_text";
            this.lbl_email_text.Size = new System.Drawing.Size(105, 21);
            this.lbl_email_text.TabIndex = 4;
            this.lbl_email_text.Values.Text = ".......@gmail.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SoftwareFirmManagement.Properties.Resources.User_Default;
            this.pictureBox1.Location = new System.Drawing.Point(6, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_name_text
            // 
            this.lbl_name_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name_text.Location = new System.Drawing.Point(202, 59);
            this.lbl_name_text.Name = "lbl_name_text";
            this.lbl_name_text.Size = new System.Drawing.Size(142, 21);
            this.lbl_name_text.TabIndex = 2;
            this.lbl_name_text.Values.Text = "Honourable Customer";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(160, 90);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(54, 24);
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "Email:";
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_name.Location = new System.Drawing.Point(160, 36);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(57, 24);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Values.Text = "Name:";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.platformIdDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn});
            this.kryptonDataGridView1.DataSource = this.orderDTOBindingSource;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(357, 162);
            this.kryptonDataGridView1.TabIndex = 1;
            // 
            // kryptonGroupBox4
            // 
            this.kryptonGroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonGroupBox4.Location = new System.Drawing.Point(32, 19);
            this.kryptonGroupBox4.Name = "kryptonGroupBox4";
            // 
            // kryptonGroupBox4.Panel
            // 
            this.kryptonGroupBox4.Panel.Controls.Add(this.lbl_title);
            this.kryptonGroupBox4.Size = new System.Drawing.Size(257, 186);
            this.kryptonGroupBox4.TabIndex = 1;
            this.kryptonGroupBox4.Values.Heading = "";
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_title.Location = new System.Drawing.Point(18, 17);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(200, 124);
            this.lbl_title.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.TabIndex = 45;
            this.lbl_title.Values.Text = "Software\r\nManagement\r\nFirm";
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionColumn.DataPropertyName = "Description";
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // platformIdDataGridViewTextBoxColumn
            // 
            this.platformIdDataGridViewTextBoxColumn.DataPropertyName = "PlatformId";
            this.platformIdDataGridViewTextBoxColumn.HeaderText = "PlatformId";
            this.platformIdDataGridViewTextBoxColumn.Name = "platformIdDataGridViewTextBoxColumn";
            this.platformIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "Platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            this.platformDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderDTOBindingSource
            // 
            this.orderDTOBindingSource.DataSource = typeof(SoftwareFirmManagement.BL.OrderDTO);
            // 
            // gbx_completed_orders
            // 
            this.gbx_completed_orders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_completed_orders.Location = new System.Drawing.Point(12, 18);
            this.gbx_completed_orders.Name = "gbx_completed_orders";
            // 
            // gbx_completed_orders.Panel
            // 
            this.gbx_completed_orders.Panel.Controls.Add(this.dgv_completed_orders);
            this.gbx_completed_orders.Panel.Controls.Add(this.kryptonDataGridView3);
            this.gbx_completed_orders.Size = new System.Drawing.Size(298, 195);
            this.gbx_completed_orders.TabIndex = 1;
            this.gbx_completed_orders.Values.Heading = "Completed Orders";
            // 
            // dgv_completed_orders
            // 
            this.dgv_completed_orders.AllowUserToAddRows = false;
            this.dgv_completed_orders.AllowUserToDeleteRows = false;
            this.dgv_completed_orders.AllowUserToOrderColumns = true;
            this.dgv_completed_orders.AutoGenerateColumns = false;
            this.dgv_completed_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_completed_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_completed_orders.DataSource = this.orderDTOBindingSource1;
            this.dgv_completed_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_completed_orders.Location = new System.Drawing.Point(0, 0);
            this.dgv_completed_orders.Name = "dgv_completed_orders";
            this.dgv_completed_orders.ReadOnly = true;
            this.dgv_completed_orders.Size = new System.Drawing.Size(284, 162);
            this.dgv_completed_orders.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreatedAt";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreatedAt";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PlatformId";
            this.dataGridViewTextBoxColumn3.HeaderText = "PlatformId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Platform";
            this.dataGridViewTextBoxColumn4.HeaderText = "Platform";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // kryptonDataGridView3
            // 
            this.kryptonDataGridView3.AllowUserToAddRows = false;
            this.kryptonDataGridView3.AllowUserToDeleteRows = false;
            this.kryptonDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView3.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView3.Name = "kryptonDataGridView3";
            this.kryptonDataGridView3.ReadOnly = true;
            this.kryptonDataGridView3.Size = new System.Drawing.Size(284, 162);
            this.kryptonDataGridView3.TabIndex = 0;
            // 
            // orderDTOBindingSource1
            // 
            this.orderDTOBindingSource1.DataSource = typeof(SoftwareFirmManagement.BL.OrderDTO);
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpnl_main);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDashboard";
            this.Text = "EmployeeDashboard";
            this.Load += new System.EventHandler(this.EmployeeDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pending_orders)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_pending_orders.Panel)).EndInit();
            this.gbx_pending_orders.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_pending_orders)).EndInit();
            this.gbx_pending_orders.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tlpnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).EndInit();
            this.kryptonGroupBox4.Panel.ResumeLayout(false);
            this.kryptonGroupBox4.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).EndInit();
            this.kryptonGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_completed_orders.Panel)).EndInit();
            this.gbx_completed_orders.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_completed_orders)).EndInit();
            this.gbx_completed_orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_completed_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_pending_orders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_pending_orders;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tlpnl_main;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_email_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_name_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_name;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_title;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_completed_orders;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_completed_orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView3;
        private System.Windows.Forms.BindingSource orderDTOBindingSource1;
    }
}