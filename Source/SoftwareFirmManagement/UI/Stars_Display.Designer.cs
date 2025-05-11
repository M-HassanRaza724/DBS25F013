using System.Collections.Generic;

namespace SoftwareFirmManagement.UI
{
    partial class Stars_Display
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
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.star4 = new System.Windows.Forms.PictureBox();
            this.star5 = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star_list = new List<System.Windows.Forms.PictureBox>();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.star_list)).BeginInit();
            this.SuspendLayout();
            // 
            // star2
            // 
            this.star2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.star2.Image = global::SoftwareFirmManagement.Properties.Resources.Star_filled_;
            this.star2.Location = new System.Drawing.Point(33, 0);
            this.star2.Margin = new System.Windows.Forms.Padding(0);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(30, 30);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star2.TabIndex = 11;
            this.star2.TabStop = false;
            this.star2.Click += new System.EventHandler(this.star2_Click);
            // 
            // star3
            // 
            this.star3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.star3.Image = global::SoftwareFirmManagement.Properties.Resources.Star_filled_;
            this.star3.Location = new System.Drawing.Point(63, 0);
            this.star3.Margin = new System.Windows.Forms.Padding(0);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(30, 30);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star3.TabIndex = 10;
            this.star3.TabStop = false;
            this.star3.Click += new System.EventHandler(this.star3_Click);
            // 
            // star4
            // 
            this.star4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.star4.Image = global::SoftwareFirmManagement.Properties.Resources.Star_filled_;
            this.star4.Location = new System.Drawing.Point(93, 0);
            this.star4.Margin = new System.Windows.Forms.Padding(0);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(30, 30);
            this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star4.TabIndex = 9;
            this.star4.TabStop = false;
            this.star4.Click += new System.EventHandler(this.star4_Click);
            // 
            // star5
            // 
            this.star5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.star5.Image = global::SoftwareFirmManagement.Properties.Resources.Star_filled_;
            this.star5.Location = new System.Drawing.Point(123, 0);
            this.star5.Margin = new System.Windows.Forms.Padding(0);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(30, 30);
            this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star5.TabIndex = 8;
            this.star5.TabStop = false;
            this.star5.Click += new System.EventHandler(this.star5_Click);
            // 
            // star1
            // 
            this.star1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.star1.Image = global::SoftwareFirmManagement.Properties.Resources.Star_filled_;
            this.star1.Location = new System.Drawing.Point(3, 0);
            this.star1.Margin = new System.Windows.Forms.Padding(0);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(30, 30);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star1.TabIndex = 7;
            this.star1.TabStop = false;
            this.star1.Click += new System.EventHandler(this.star1_Click);
            // 
            // Stars_List
            //    
            star_list.Add(this.star1);
            star_list.Add(this.star2);
            star_list.Add(this.star3);
            star_list.Add(this.star4);
            star_list.Add(this.star5);

            // 
            // Stars_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star1);
            this.Name = "Stars_Display";
            this.Size = new System.Drawing.Size(156, 33);
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.PictureBox star4;
        private System.Windows.Forms.PictureBox star5;
        private System.Windows.Forms.PictureBox star1;
        private List<System.Windows.Forms.PictureBox> star_list;

    }
}
