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
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_budget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_service)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_platform
            // 
            this.cmb_platform.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.cmb_platform.Location = new System.Drawing.Point(109, 87);
            this.cmb_platform.Name = "cmb_platform";
            this.cmb_platform.Size = new System.Drawing.Size(250, 37);
            this.cmb_platform.TabIndex = 26;
            this.cmb_platform.Text = "Select Platform";
            // 
            // cmb_budget
            // 
            this.cmb_budget.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.cmb_budget.Location = new System.Drawing.Point(411, 87);
            this.cmb_budget.Name = "cmb_budget";
            this.cmb_budget.Size = new System.Drawing.Size(250, 37);
            this.cmb_budget.TabIndex = 27;
            this.cmb_budget.Text = "Select Initial budget";
            // 
            // cmb_service
            // 
            this.cmb_service.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.cmb_service.Location = new System.Drawing.Point(257, 185);
            this.cmb_service.Name = "cmb_service";
            this.cmb_service.Size = new System.Drawing.Size(250, 37);
            this.cmb_service.TabIndex = 28;
            this.cmb_service.Text = "Select Service";
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_title.Location = new System.Drawing.Point(298, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(177, 48);
            this.lbl_title.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.TabIndex = 45;
            this.lbl_title.Values.Text = "Place Order";
            this.lbl_title.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_title_Paint);
            // 
            // txt_description
            // 
            this.txt_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_description.BackColor = System.Drawing.Color.Transparent;
            this.txt_description.Location = new System.Drawing.Point(137, 274);
            this.txt_description.MultiLine = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.PlaceHolder = "Description about your order";
            this.txt_description.Size = new System.Drawing.Size(490, 79);
            this.txt_description.Style = "Ribbon";
            this.txt_description.TabIndex = 46;
            this.txt_description.TextBoxText = "";
            this.txt_description.Load += new System.EventHandler(this.txt_description_Load);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancel.Location = new System.Drawing.Point(139, 378);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(220, 49);
            this.btn_cancel.TabIndex = 48;
            this.btn_cancel.Values.Text = "Cancel";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kryptonButton3.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.kryptonButton3.Location = new System.Drawing.Point(407, 378);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(220, 49);
            this.kryptonButton3.TabIndex = 47;
            this.kryptonButton3.Values.Text = "Place Order";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // OrderPlacementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.cmb_service);
            this.Controls.Add(this.cmb_budget);
            this.Controls.Add(this.cmb_platform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
    }
}