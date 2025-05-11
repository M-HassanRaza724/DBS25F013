namespace DbFinalProject.DialogBoxForms
{
    partial class OrderReviewDialog
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblStars = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnUpdateReview = new System.Windows.Forms.Button();
            this.cbOrderId = new System.Windows.Forms.ComboBox();
            this.cbStars = new System.Windows.Forms.ComboBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.lblOrderId, 0, 0);
            this.tlpMain.Controls.Add(this.lblStars, 0, 1);
            this.tlpMain.Controls.Add(this.lblDescription, 0, 2);
            this.tlpMain.Controls.Add(this.btnUpdateReview, 0, 3);
            this.tlpMain.Controls.Add(this.cbOrderId, 1, 0);
            this.tlpMain.Controls.Add(this.cbStars, 1, 1);
            this.tlpMain.Controls.Add(this.tbDescription, 1, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // lblOrderId
            // 
            this.lblOrderId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblOrderId.Location = new System.Drawing.Point(165, 92);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(70, 20);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Order ID";
            // 
            // lblStars
            // 
            this.lblStars.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblStars.AutoSize = true;
            this.lblStars.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblStars.Location = new System.Drawing.Point(176, 204);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(47, 20);
            this.lblStars.TabIndex = 1;
            this.lblStars.Text = "Stars";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDescription.Location = new System.Drawing.Point(155, 316);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // btnUpdateReview
            // 
            this.btnUpdateReview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpMain.SetColumnSpan(this.btnUpdateReview, 2);
            this.btnUpdateReview.Location = new System.Drawing.Point(329, 339);
            this.btnUpdateReview.Name = "btnUpdateReview";
            this.btnUpdateReview.Size = new System.Drawing.Size(142, 36);
            this.btnUpdateReview.TabIndex = 3;
            this.btnUpdateReview.Text = "Update review";
            this.btnUpdateReview.UseVisualStyleBackColor = true;
            this.btnUpdateReview.Click += new System.EventHandler(this.btnUpdateReview_Click);
            // 
            // cbOrderId
            // 
            this.cbOrderId.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderId.FormattingEnabled = true;
            this.cbOrderId.Location = new System.Drawing.Point(510, 81);
            this.cbOrderId.Name = "cbOrderId";
            this.cbOrderId.Size = new System.Drawing.Size(179, 28);
            this.cbOrderId.TabIndex = 4;
            // 
            // cbStars
            // 
            this.cbStars.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbStars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStars.FormattingEnabled = true;
            this.cbStars.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbStars.Location = new System.Drawing.Point(510, 193);
            this.cbStars.Name = "cbStars";
            this.cbStars.Size = new System.Drawing.Size(179, 28);
            this.cbStars.TabIndex = 5;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbDescription.Location = new System.Drawing.Point(508, 307);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(183, 26);
            this.tbDescription.TabIndex = 6;
            // 
            // OrderReviewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderReviewDialog";
            this.Text = "OrderReviewDialog";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnUpdateReview;
        private System.Windows.Forms.ComboBox cbOrderId;
        private System.Windows.Forms.ComboBox cbStars;
        private System.Windows.Forms.TextBox tbDescription;
    }
}