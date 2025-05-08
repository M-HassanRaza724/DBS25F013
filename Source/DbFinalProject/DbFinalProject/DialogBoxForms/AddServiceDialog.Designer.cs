namespace DbFinalProject.ChildForms
{
    partial class AddServiceDialog
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
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSubservice = new System.Windows.Forms.Label();
            this.lblTechnology = new System.Windows.Forms.Label();
            this.tbServiceName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbSubservice = new System.Windows.Forms.TextBox();
            this.tbTechnology = new System.Windows.Forms.TextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.lblServiceName, 0, 0);
            this.tlpMain.Controls.Add(this.lblDescription, 0, 1);
            this.tlpMain.Controls.Add(this.lblCategory, 0, 2);
            this.tlpMain.Controls.Add(this.lblSubservice, 0, 3);
            this.tlpMain.Controls.Add(this.lblTechnology, 0, 4);
            this.tlpMain.Controls.Add(this.tbServiceName, 1, 0);
            this.tlpMain.Controls.Add(this.tbDescription, 1, 1);
            this.tlpMain.Controls.Add(this.tbSubservice, 1, 3);
            this.tlpMain.Controls.Add(this.tbTechnology, 1, 4);
            this.tlpMain.Controls.Add(this.btnAddService, 0, 5);
            this.tlpMain.Controls.Add(this.cbCategory, 1, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // lblServiceName
            // 
            this.lblServiceName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblServiceName.Location = new System.Drawing.Point(147, 54);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(105, 20);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Service name";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDescription.Location = new System.Drawing.Point(155, 128);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCategory.Location = new System.Drawing.Point(163, 202);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 20);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // lblSubservice
            // 
            this.lblSubservice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSubservice.AutoSize = true;
            this.lblSubservice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSubservice.Location = new System.Drawing.Point(156, 276);
            this.lblSubservice.Name = "lblSubservice";
            this.lblSubservice.Size = new System.Drawing.Size(87, 20);
            this.lblSubservice.TabIndex = 3;
            this.lblSubservice.Text = "Subservice";
            // 
            // lblTechnology
            // 
            this.lblTechnology.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTechnology.AutoSize = true;
            this.lblTechnology.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTechnology.Location = new System.Drawing.Point(155, 350);
            this.lblTechnology.Name = "lblTechnology";
            this.lblTechnology.Size = new System.Drawing.Size(90, 20);
            this.lblTechnology.TabIndex = 4;
            this.lblTechnology.Text = "Technology";
            // 
            // tbServiceName
            // 
            this.tbServiceName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbServiceName.Location = new System.Drawing.Point(477, 45);
            this.tbServiceName.Name = "tbServiceName";
            this.tbServiceName.Size = new System.Drawing.Size(246, 26);
            this.tbServiceName.TabIndex = 5;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbDescription.Location = new System.Drawing.Point(476, 119);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(247, 26);
            this.tbDescription.TabIndex = 6;
            // 
            // tbSubservice
            // 
            this.tbSubservice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbSubservice.Location = new System.Drawing.Point(477, 267);
            this.tbSubservice.Name = "tbSubservice";
            this.tbSubservice.Size = new System.Drawing.Size(246, 26);
            this.tbSubservice.TabIndex = 8;
            // 
            // tbTechnology
            // 
            this.tbTechnology.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbTechnology.Location = new System.Drawing.Point(477, 341);
            this.tbTechnology.Name = "tbTechnology";
            this.tbTechnology.Size = new System.Drawing.Size(246, 26);
            this.tbTechnology.TabIndex = 9;
            // 
            // btnAddService
            // 
            this.btnAddService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpMain.SetColumnSpan(this.btnAddService, 2);
            this.btnAddService.Location = new System.Drawing.Point(357, 373);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(85, 36);
            this.btnAddService.TabIndex = 10;
            this.btnAddService.Text = "Add service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(479, 191);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(242, 28);
            this.cbCategory.TabIndex = 11;
            // 
            // AddServiceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddServiceDialog";
            this.Text = "AddServiceDialog";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSubservice;
        private System.Windows.Forms.Label lblTechnology;
        private System.Windows.Forms.TextBox tbServiceName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbSubservice;
        private System.Windows.Forms.TextBox tbTechnology;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}