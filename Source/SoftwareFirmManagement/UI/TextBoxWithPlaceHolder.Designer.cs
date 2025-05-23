﻿namespace SoftwareFirmManagement.UI
{
    partial class TextBoxWithPlaceHolder
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
            this.TextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Location = new System.Drawing.Point(0, 0);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(237, 39);
            this.TextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.TextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3, 3, -1, 3);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "Place holder";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // TextBoxWithPlaceHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TextBox);
            this.Name = "TextBoxWithPlaceHolder";
            this.Size = new System.Drawing.Size(237, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox;
    }
}
