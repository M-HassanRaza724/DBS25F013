namespace SoftwareFirmManagement.UI
{
    partial class OrderPlacementForm
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
            this.cmb_platform = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmb_budget = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmb_service = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbl_title = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_description = new SoftwareFirmManagement.UI.TextBoxWithPlaceHolder();
            this.btn_cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_placeorder = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_budget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_service)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_platform
            // 
            this.cmb_platform.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_platform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_platform.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList;
            this.cmb_platform.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cmb_platform.DropDownWidth = 188;
            this.cmb_platform.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cmb_platform.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "item 6"});
            this.cmb_platform.Location = new System.Drawing.Point(145, 107);
            this.cmb_platform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_platform.Name = "cmb_platform";
            this.cmb_platform.Size = new System.Drawing.Size(333, 42);
            this.cmb_platform.TabIndex = 26;
            this.cmb_platform.Text = "Select Platform";
            // 
            // cmb_budget
            // 
            this.cmb_budget.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_budget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_budget.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList;
            this.cmb_budget.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cmb_budget.DropDownWidth = 188;
            this.cmb_budget.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cmb_budget.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "item 6"});
            this.cmb_budget.Location = new System.Drawing.Point(548, 107);
            this.cmb_budget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_budget.Name = "cmb_budget";
            this.cmb_budget.Size = new System.Drawing.Size(333, 42);
            this.cmb_budget.TabIndex = 27;
            this.cmb_budget.Text = "Select Initial budget";
            // 
            // cmb_service
            // 
            this.cmb_service.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_service.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_service.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridDataCellList;
            this.cmb_service.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.cmb_service.DropDownWidth = 188;
            this.cmb_service.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cmb_service.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3",
            "item 4",
            "item 5",
            "item 6"});
            this.cmb_service.Location = new System.Drawing.Point(343, 228);
            this.cmb_service.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_service.Name = "cmb_service";
            this.cmb_service.Size = new System.Drawing.Size(333, 42);
            this.cmb_service.TabIndex = 28;
            this.cmb_service.Text = "Select Service";
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_title.Location = new System.Drawing.Point(397, 15);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(220, 56);
            this.lbl_title.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.TabIndex = 45;
            this.lbl_title.Values.Text = "Place Order";
            // 
            // txt_description
            // 
            this.txt_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_description.BackColor = System.Drawing.Color.Transparent;
            this.txt_description.Location = new System.Drawing.Point(183, 337);
            this.txt_description.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_description.MultiLine = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.PlaceHolder = "Description about your order";
            this.txt_description.Size = new System.Drawing.Size(653, 97);
            this.txt_description.Style = "Ribbon";
            this.txt_description.TabIndex = 46;
            this.txt_description.TextBoxText = "";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(185, 465);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(293, 60);
            this.btn_cancel.TabIndex = 48;
            this.btn_cancel.Values.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_placeorder
            // 
            this.btn_placeorder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_placeorder.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_placeorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_placeorder.Location = new System.Drawing.Point(543, 465);
            this.btn_placeorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_placeorder.Name = "btn_placeorder";
            this.btn_placeorder.Size = new System.Drawing.Size(293, 60);
            this.btn_placeorder.TabIndex = 47;
            this.btn_placeorder.Values.Text = "Place Order";
            this.btn_placeorder.Click += new System.EventHandler(this.btn_placeorder_Click);
            // 
            // OrderPlacementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_placeorder);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.cmb_service);
            this.Controls.Add(this.cmb_budget);
            this.Controls.Add(this.cmb_platform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderPlacementForm";
            this.Text = "OrderPlacementForm";
            this.Load += new System.EventHandler(this.OrderPlacementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_budget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_service)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmb_platform;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmb_budget;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmb_service;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_title;
        private TextBoxWithPlaceHolder txt_description;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_placeorder;
    }
}