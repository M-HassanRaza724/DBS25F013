namespace SoftwareFirmManagement.UI
{
    partial class Header
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
            this.pnl_main = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btn_clear = new System.Windows.Forms.PictureBox();
            this.btn_search2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_search = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_main)).BeginInit();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.kryptonGroupBox1);
            this.pnl_main.Controls.Add(this.btn_search);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(301, 56);
            this.pnl_main.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pnl_main.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.pnl_main.TabIndex = 0;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btn_clear);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btn_search2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txt_search);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(240, 56);
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonGroupBox1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonGroupBox1.StateCommon.Border.Width = 2;
            this.kryptonGroupBox1.TabIndex = 2;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Image = global::SoftwareFirmManagement.Properties.Resources.Close;
            this.btn_clear.Location = new System.Drawing.Point(182, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(35, 28);
            this.btn_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_clear.TabIndex = 3;
            this.btn_clear.TabStop = false;
            this.btn_clear.Visible = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search2
            // 
            this.btn_search2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.btn_search2.Location = new System.Drawing.Point(265, 58);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(120, 43);
            this.btn_search2.TabIndex = 0;
            this.btn_search2.Values.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.txt_search.Location = new System.Drawing.Point(3, -2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(174, 44);
            this.txt_search.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_search.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, 5);
            this.txt_search.TabIndex = 1;
            this.txt_search.Text = "Search";
            this.txt_search.WordWrap = false;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Image = global::SoftwareFirmManagement.Properties.Resources.Search;
            this.btn_search.Location = new System.Drawing.Point(245, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(44, 35);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 2;
            this.btn_search.TabStop = false;
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.pnl_main);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(301, 56);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_main)).EndInit();
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnl_main;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_search;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_search2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.PictureBox btn_search;
        private System.Windows.Forms.PictureBox btn_clear;
    }
}
