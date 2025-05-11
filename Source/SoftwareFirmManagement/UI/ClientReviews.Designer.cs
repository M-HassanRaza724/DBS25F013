namespace SoftwareFirmManagement.UI
{
    partial class ClientReviews
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
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_title = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl_sub_title = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar
            // 
            this.vScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar.LargeChange = 1;
            this.vScrollBar.Location = new System.Drawing.Point(840, 0);
            this.vScrollBar.Maximum = 0;
            this.vScrollBar.MaximumSize = new System.Drawing.Size(15, 0);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(10, 450);
            this.vScrollBar.TabIndex = 1;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.Controls.Add(this.lbl_title);
            this.pnl_main.Controls.Add(this.lbl_sub_title);
            this.pnl_main.Location = new System.Drawing.Point(9, 0);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(831, 450);
            this.pnl_main.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_title.Location = new System.Drawing.Point(316, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(217, 48);
            this.lbl_title.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.TabIndex = 12;
            this.lbl_title.Values.Text = "Client Reviews";
            // 
            // lbl_sub_title
            // 
            this.lbl_sub_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sub_title.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lbl_sub_title.Location = new System.Drawing.Point(248, 62);
            this.lbl_sub_title.Name = "lbl_sub_title";
            this.lbl_sub_title.Size = new System.Drawing.Size(352, 37);
            this.lbl_sub_title.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sub_title.TabIndex = 11;
            this.lbl_sub_title.Values.Text = "See what our clients have to say!";
            // 
            // ClientReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.vScrollBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientReviews";
            this.Text = "ClientReviews";
            this.Load += new System.EventHandler(this.ClientReviews_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.Panel pnl_main;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_sub_title;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_title;
    }
}