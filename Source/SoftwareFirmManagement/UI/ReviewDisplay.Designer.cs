namespace SoftwareFirmManagement.UI
{
    partial class ReviewDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbx_review_input = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_description = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_reviewer = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_date = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.stars_Display1 = new SoftwareFirmManagement.UI.Stars_Display();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_review_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_review_input.Panel)).BeginInit();
            this.gbx_review_input.Panel.SuspendLayout();
            this.gbx_review_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_review_input
            // 
            this.gbx_review_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_review_input.Location = new System.Drawing.Point(0, 0);
            this.gbx_review_input.Name = "gbx_review_input";
            // 
            // gbx_review_input.Panel
            // 
            this.gbx_review_input.Panel.Controls.Add(this.lbl_description);
            this.gbx_review_input.Panel.Controls.Add(this.lbl_reviewer);
            this.gbx_review_input.Panel.Controls.Add(this.lbl_date);
            this.gbx_review_input.Panel.Controls.Add(this.stars_Display1);
            this.gbx_review_input.Size = new System.Drawing.Size(750, 130);
            this.gbx_review_input.TabIndex = 73;
            this.gbx_review_input.Values.Heading = "";
            // 
            // lbl_description
            // 
            this.lbl_description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_description.Location = new System.Drawing.Point(61, 57);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(509, 28);
            this.lbl_description.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.TabIndex = 17;
            this.lbl_description.Values.Text = "\'Textile website is coming along, but communication could improve.\'";
            // 
            // lbl_reviewer
            // 
            this.lbl_reviewer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_reviewer.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_reviewer.Location = new System.Drawing.Point(61, 12);
            this.lbl_reviewer.Name = "lbl_reviewer";
            this.lbl_reviewer.Size = new System.Drawing.Size(111, 37);
            this.lbl_reviewer.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reviewer.TabIndex = 10;
            this.lbl_reviewer.Values.Text = "Reviewer";
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_date.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_date.Location = new System.Drawing.Point(372, 17);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(98, 26);
            this.lbl_date.TabIndex = 9;
            this.lbl_date.Values.Text = "yyyy-mm-dd";
            // 
            // stars_Display1
            // 
            this.stars_Display1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stars_Display1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.stars_Display1.InputMode = false;
            this.stars_Display1.Location = new System.Drawing.Point(486, 12);
            this.stars_Display1.Name = "stars_Display1";
            this.stars_Display1.Size = new System.Drawing.Size(156, 33);
            this.stars_Display1.Stars = 5;
            this.stars_Display1.TabIndex = 7;
            // 
            // ReviewDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gbx_review_input);
            this.MinimumSize = new System.Drawing.Size(580, 0);
            this.Name = "ReviewDisplay";
            this.Size = new System.Drawing.Size(750, 130);
            ((System.ComponentModel.ISupportInitialize)(this.gbx_review_input.Panel)).EndInit();
            this.gbx_review_input.Panel.ResumeLayout(false);
            this.gbx_review_input.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbx_review_input)).EndInit();
            this.gbx_review_input.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbx_review_input;
        private Stars_Display stars_Display1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_date;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_reviewer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_description;
    }
}
