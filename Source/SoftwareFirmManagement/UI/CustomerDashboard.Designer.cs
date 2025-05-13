namespace SoftwareFirmManagement.UI
{
    partial class CustomerDashboard
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
            this.tlpnl_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_order_placement = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbx_pending_orders = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgv_pending_orders = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.picbox_placeOrder = new System.Windows.Forms.PictureBox();
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_email_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_name_text = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox4 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_title = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlpnl_main.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_pending_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_pending_orders.Panel)).BeginInit();
            this.gbx_pending_orders.Panel.SuspendLayout();
            this.gbx_pending_orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pending_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_placeOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).BeginInit();
            this.kryptonGroupBox4.Panel.SuspendLayout();
            this.kryptonGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tlpnl_main.Size = new System.Drawing.Size(737, 450);
            this.tlpnl_main.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.kryptonGroupBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(294, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 225);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.kryptonGroupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 225);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 225);
            this.panel3.TabIndex = 3;
            // 
            // lbl_order_placement
            // 
            this.lbl_order_placement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_order_placement.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_order_placement.Location = new System.Drawing.Point(72, 118);
            this.lbl_order_placement.Name = "lbl_order_placement";
            this.lbl_order_placement.Size = new System.Drawing.Size(92, 24);
            this.lbl_order_placement.TabIndex = 2;
            this.lbl_order_placement.Values.Text = "Place Order";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.kryptonGroupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 225);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbx_pending_orders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(294, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 225);
            this.panel1.TabIndex = 1;
            // 
            // gbx_pending_orders
            // 
            this.gbx_pending_orders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_pending_orders.Location = new System.Drawing.Point(19, 12);
            this.gbx_pending_orders.Name = "gbx_pending_orders";
            // 
            // gbx_pending_orders.Panel
            // 
            this.gbx_pending_orders.Panel.Controls.Add(this.dgv_pending_orders);
            this.gbx_pending_orders.Size = new System.Drawing.Size(371, 190);
            this.gbx_pending_orders.TabIndex = 0;
            this.gbx_pending_orders.Values.Heading = "Pending Orders";
            // 
            // dgv_pending_orders
            // 
            this.dgv_pending_orders.AllowUserToAddRows = false;
            this.dgv_pending_orders.AllowUserToDeleteRows = false;
            this.dgv_pending_orders.AutoGenerateColumns = false;
            this.dgv_pending_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pending_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.platformIdDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn});
            this.dgv_pending_orders.DataSource = this.orderDTOBindingSource;
            this.dgv_pending_orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pending_orders.Location = new System.Drawing.Point(0, 0);
            this.dgv_pending_orders.Name = "dgv_pending_orders";
            this.dgv_pending_orders.ReadOnly = true;
            this.dgv_pending_orders.Size = new System.Drawing.Size(357, 157);
            this.dgv_pending_orders.TabIndex = 0;
            // 
            // picbox_placeOrder
            // 
            this.picbox_placeOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbox_placeOrder.Image = global::SoftwareFirmManagement.Properties.Resources.Add_Shopping_Cart;
            this.picbox_placeOrder.Location = new System.Drawing.Point(41, 21);
            this.picbox_placeOrder.Margin = new System.Windows.Forms.Padding(0);
            this.picbox_placeOrder.Name = "picbox_placeOrder";
            this.picbox_placeOrder.Size = new System.Drawing.Size(149, 94);
            this.picbox_placeOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_placeOrder.TabIndex = 1;
            this.picbox_placeOrder.TabStop = false;
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonGroupBox3.Location = new System.Drawing.Point(19, 21);
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
            // kryptonGroupBox4
            // 
            this.kryptonGroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonGroupBox4.Location = new System.Drawing.Point(19, 19);
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
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(19, 27);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.picbox_placeOrder);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lbl_order_placement);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(257, 175);
            this.kryptonGroupBox1.TabIndex = 3;
            this.kryptonGroupBox1.Values.Heading = "";
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
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.tlpnl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.tlpnl_main.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_pending_orders.Panel)).EndInit();
            this.gbx_pending_orders.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_pending_orders)).EndInit();
            this.gbx_pending_orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pending_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_placeOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).EndInit();
            this.kryptonGroupBox4.Panel.ResumeLayout(false);
            this.kryptonGroupBox4.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).EndInit();
            this.kryptonGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpnl_main;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picbox_placeOrder;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_order_placement;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_pending_orders;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_pending_orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDTOBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_email_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_name_text;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_name;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_title;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
    }
}