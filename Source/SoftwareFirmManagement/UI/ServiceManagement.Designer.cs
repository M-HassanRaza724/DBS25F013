namespace SoftwareFirmManagement.UI
{
    partial class ServiceManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceManagement));
            this.lbl_header = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_title = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_footer = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.menuStrip_filters = new System.Windows.Forms.MenuStrip();
            this.filter_item_sort_by = new System.Windows.Forms.ToolStripMenuItem();
            this.customerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_add_update_service = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_subservice = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_subservice = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.lbl_description = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_description = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.lbl_technology = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_technology = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.btn_cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_add_update_services = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_last_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_name = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_name = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.pnl_main.SuspendLayout();
            this.menuStrip_filters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_service.Panel)).BeginInit();
            this.gbx_add_update_service.Panel.SuspendLayout();
            this.gbx_add_update_service.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_header.Location = new System.Drawing.Point(11, 84);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(842, 83);
            this.lbl_header.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.TabIndex = 1;
            this.lbl_header.Values.Text = resources.GetString("lbl_header.Values.Text");
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_title.Location = new System.Drawing.Point(341, 30);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(187, 48);
            this.lbl_title.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Values.Text = "Our Services";
            // 
            // lbl_footer
            // 
            this.lbl_footer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_footer.Location = new System.Drawing.Point(6, 338);
            this.lbl_footer.Name = "lbl_footer";
            this.lbl_footer.Size = new System.Drawing.Size(853, 83);
            this.lbl_footer.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_footer.TabIndex = 3;
            this.lbl_footer.Values.Text = resources.GetString("lbl_footer.Values.Text");
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.Controls.Add(this.menuStrip_filters);
            this.pnl_main.Controls.Add(this.gbx_add_update_service);
            this.pnl_main.Controls.Add(this.lbl_footer);
            this.pnl_main.Controls.Add(this.lbl_title);
            this.pnl_main.Controls.Add(this.lbl_header);
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(861, 450);
            this.pnl_main.TabIndex = 1;
            // 
            // menuStrip_filters
            // 
            this.menuStrip_filters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip_filters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.menuStrip_filters.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_filters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.menuStrip_filters.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip_filters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filter_item_sort_by});
            this.menuStrip_filters.Location = new System.Drawing.Point(788, 9);
            this.menuStrip_filters.Name = "menuStrip_filters";
            this.menuStrip_filters.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip_filters.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip_filters.Size = new System.Drawing.Size(65, 24);
            this.menuStrip_filters.TabIndex = 39;
            this.menuStrip_filters.Text = "Filters";
            // 
            // filter_item_sort_by
            // 
            this.filter_item_sort_by.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerNameToolStripMenuItem,
            this.userNameToolStripMenuItem,
            this.deleteServiceToolStripMenuItem});
            this.filter_item_sort_by.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.filter_item_sort_by.Name = "filter_item_sort_by";
            this.filter_item_sort_by.Size = new System.Drawing.Size(59, 22);
            this.filter_item_sort_by.Text = "Actions";
            // 
            // customerNameToolStripMenuItem
            // 
            this.customerNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.customerNameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.customerNameToolStripMenuItem.Image = global::SoftwareFirmManagement.Properties.Resources.Add;
            this.customerNameToolStripMenuItem.Name = "customerNameToolStripMenuItem";
            this.customerNameToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.customerNameToolStripMenuItem.Text = "Add Service";
            this.customerNameToolStripMenuItem.Click += new System.EventHandler(this.customerNameToolStripMenuItem_Click);
            // 
            // userNameToolStripMenuItem
            // 
            this.userNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.userNameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.userNameToolStripMenuItem.Image = global::SoftwareFirmManagement.Properties.Resources.Edit;
            this.userNameToolStripMenuItem.Name = "userNameToolStripMenuItem";
            this.userNameToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.userNameToolStripMenuItem.Text = "Edit Service";
            // 
            // deleteServiceToolStripMenuItem
            // 
            this.deleteServiceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.deleteServiceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.deleteServiceToolStripMenuItem.Image = global::SoftwareFirmManagement.Properties.Resources.Trash;
            this.deleteServiceToolStripMenuItem.Name = "deleteServiceToolStripMenuItem";
            this.deleteServiceToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.deleteServiceToolStripMenuItem.Text = "Delete Service";
            this.deleteServiceToolStripMenuItem.Click += new System.EventHandler(this.deleteServiceToolStripMenuItem_Click);
            // 
            // gbx_add_update_service
            // 
            this.gbx_add_update_service.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbx_add_update_service.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlAlternate;
            this.gbx_add_update_service.Location = new System.Drawing.Point(236, 73);
            this.gbx_add_update_service.Name = "gbx_add_update_service";
            // 
            // gbx_add_update_service.Panel
            // 
            this.gbx_add_update_service.Panel.Controls.Add(this.lbl_subservice);
            this.gbx_add_update_service.Panel.Controls.Add(this.txt_subservice);
            this.gbx_add_update_service.Panel.Controls.Add(this.lbl_description);
            this.gbx_add_update_service.Panel.Controls.Add(this.txt_description);
            this.gbx_add_update_service.Panel.Controls.Add(this.lbl_technology);
            this.gbx_add_update_service.Panel.Controls.Add(this.txt_technology);
            this.gbx_add_update_service.Panel.Controls.Add(this.btn_cancel);
            this.gbx_add_update_service.Panel.Controls.Add(this.btn_add_update_services);
            this.gbx_add_update_service.Panel.Controls.Add(this.lbl_last_name);
            this.gbx_add_update_service.Panel.Controls.Add(this.lbl_name);
            this.gbx_add_update_service.Panel.Controls.Add(this.txt_name);
            this.gbx_add_update_service.Size = new System.Drawing.Size(389, 398);
            this.gbx_add_update_service.TabIndex = 4;
            this.gbx_add_update_service.Values.Heading = "Add Service";
            this.gbx_add_update_service.Visible = false;
            // 
            // lbl_subservice
            // 
            this.lbl_subservice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_subservice.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_subservice.Location = new System.Drawing.Point(16, 208);
            this.lbl_subservice.Name = "lbl_subservice";
            this.lbl_subservice.Size = new System.Drawing.Size(93, 26);
            this.lbl_subservice.TabIndex = 19;
            this.lbl_subservice.Values.Text = "SubServices";
            // 
            // txt_subservice
            // 
            this.txt_subservice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_subservice.BackColor = System.Drawing.Color.Transparent;
            this.txt_subservice.Location = new System.Drawing.Point(13, 225);
            this.txt_subservice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_subservice.MultiLine = true;
            this.txt_subservice.Name = "txt_subservice";
            this.txt_subservice.PlaceHolder = "SubServices";
            this.txt_subservice.Size = new System.Drawing.Size(327, 42);
            this.txt_subservice.Style = "Standalone";
            this.txt_subservice.TabIndex = 18;
            this.txt_subservice.TextBoxText = "SubServices";
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_description.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_description.Location = new System.Drawing.Point(13, 68);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(90, 26);
            this.lbl_description.TabIndex = 17;
            this.lbl_description.Values.Text = "Description";
            // 
            // txt_description
            // 
            this.txt_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_description.BackColor = System.Drawing.Color.Transparent;
            this.txt_description.Location = new System.Drawing.Point(10, 85);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_description.MultiLine = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.PlaceHolder = "Description";
            this.txt_description.Size = new System.Drawing.Size(327, 42);
            this.txt_description.Style = "Standalone";
            this.txt_description.TabIndex = 16;
            this.txt_description.TextBoxText = "Description";
            // 
            // lbl_technology
            // 
            this.lbl_technology.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_technology.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_technology.Location = new System.Drawing.Point(13, 138);
            this.lbl_technology.Name = "lbl_technology";
            this.lbl_technology.Size = new System.Drawing.Size(90, 26);
            this.lbl_technology.TabIndex = 15;
            this.lbl_technology.Values.Text = "Technology";
            // 
            // txt_technology
            // 
            this.txt_technology.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_technology.BackColor = System.Drawing.Color.Transparent;
            this.txt_technology.Location = new System.Drawing.Point(10, 155);
            this.txt_technology.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_technology.MultiLine = true;
            this.txt_technology.Name = "txt_technology";
            this.txt_technology.PlaceHolder = "Technology";
            this.txt_technology.Size = new System.Drawing.Size(327, 42);
            this.txt_technology.Style = "Standalone";
            this.txt_technology.TabIndex = 14;
            this.txt_technology.TextBoxText = "Technology";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(34, 289);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 50);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Values.Text = "Cancel";
            // 
            // btn_add_update_services
            // 
            this.btn_add_update_services.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_update_services.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_add_update_services.Location = new System.Drawing.Point(190, 289);
            this.btn_add_update_services.Name = "btn_add_update_services";
            this.btn_add_update_services.Size = new System.Drawing.Size(150, 50);
            this.btn_add_update_services.TabIndex = 2;
            this.btn_add_update_services.Values.Text = "Add Service";
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
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_name.Location = new System.Drawing.Point(13, 1);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(53, 26);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Values.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_name.Location = new System.Drawing.Point(10, 18);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.MultiLine = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.PlaceHolder = "Name";
            this.txt_name.Size = new System.Drawing.Size(327, 42);
            this.txt_name.Style = "Standalone";
            this.txt_name.TabIndex = 3;
            this.txt_name.TextBoxText = "Name";
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar.LargeChange = 1;
            this.vScrollBar.Location = new System.Drawing.Point(863, 0);
            this.vScrollBar.Maximum = 0;
            this.vScrollBar.MaximumSize = new System.Drawing.Size(15, 0);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(10, 450);
            this.vScrollBar.TabIndex = 0;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // ServiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.vScrollBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(630, 0);
            this.Name = "ServiceManagement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ServiceManagement";
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.menuStrip_filters.ResumeLayout(false);
            this.menuStrip_filters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_service.Panel)).EndInit();
            this.gbx_add_update_service.Panel.ResumeLayout(false);
            this.gbx_add_update_service.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_add_update_service)).EndInit();
            this.gbx_add_update_service.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_header;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_title;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_footer;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_add_update_service;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_subservice;
        private TextBoxWithPlaceHolder txt_subservice;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_description;
        private TextBoxWithPlaceHolder txt_description;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_technology;
        private TextBoxWithPlaceHolder txt_technology;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_add_update_services;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_last_name;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_name;
        private TextBoxWithPlaceHolder txt_name;
        private System.Windows.Forms.MenuStrip menuStrip_filters;
        private System.Windows.Forms.ToolStripMenuItem filter_item_sort_by;
        private System.Windows.Forms.ToolStripMenuItem customerNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteServiceToolStripMenuItem;
    }
}