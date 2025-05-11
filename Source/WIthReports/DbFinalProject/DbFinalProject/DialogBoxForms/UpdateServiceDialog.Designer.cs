namespace DbFinalProject.DialogBoxForms
{
    partial class UpdateServiceDialog
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
            this.lblTechnology = new System.Windows.Forms.Label();
            this.lblSubservice = new System.Windows.Forms.Label();
            this.tbServiceName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTechnology = new System.Windows.Forms.TextBox();
            this.tbSubservice = new System.Windows.Forms.TextBox();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.lblServiceToUpdate = new System.Windows.Forms.Label();
            this.cbServiceToUpdate = new System.Windows.Forms.ComboBox();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.btnUpdateService, 0, 5);
            this.tlpMain.Controls.Add(this.lblSubservice, 0, 4);
            this.tlpMain.Controls.Add(this.tbSubservice, 1, 4);
            this.tlpMain.Controls.Add(this.tbTechnology, 1, 3);
            this.tlpMain.Controls.Add(this.tbDescription, 1, 2);
            this.tlpMain.Controls.Add(this.tbServiceName, 1, 1);
            this.tlpMain.Controls.Add(this.lblTechnology, 0, 3);
            this.tlpMain.Controls.Add(this.lblDescription, 0, 2);
            this.tlpMain.Controls.Add(this.lblServiceName, 0, 1);
            this.tlpMain.Controls.Add(this.lblServiceToUpdate, 0, 0);
            this.tlpMain.Controls.Add(this.cbServiceToUpdate, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.43723F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.43723F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.43723F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.43723F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.12554F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.12554F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // lblServiceName
            // 
            this.lblServiceName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblServiceName.Location = new System.Drawing.Point(147, 126);
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
            this.lblDescription.Location = new System.Drawing.Point(155, 199);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblTechnology
            // 
            this.lblTechnology.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTechnology.AutoSize = true;
            this.lblTechnology.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTechnology.Location = new System.Drawing.Point(124, 272);
            this.lblTechnology.Name = "lblTechnology";
            this.lblTechnology.Size = new System.Drawing.Size(151, 20);
            this.lblTechnology.TabIndex = 2;
            this.lblTechnology.Text = "Included technology";
            // 
            // lblSubservice
            // 
            this.lblSubservice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSubservice.AutoSize = true;
            this.lblSubservice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSubservice.Location = new System.Drawing.Point(156, 349);
            this.lblSubservice.Name = "lblSubservice";
            this.lblSubservice.Size = new System.Drawing.Size(87, 20);
            this.lblSubservice.TabIndex = 3;
            this.lblSubservice.Text = "Subservice";
            // 
            // tbServiceName
            // 
            this.tbServiceName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbServiceName.Location = new System.Drawing.Point(508, 117);
            this.tbServiceName.Name = "tbServiceName";
            this.tbServiceName.Size = new System.Drawing.Size(183, 26);
            this.tbServiceName.TabIndex = 4;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbDescription.Location = new System.Drawing.Point(508, 190);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(183, 26);
            this.tbDescription.TabIndex = 5;
            // 
            // tbTechnology
            // 
            this.tbTechnology.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbTechnology.Location = new System.Drawing.Point(508, 263);
            this.tbTechnology.Name = "tbTechnology";
            this.tbTechnology.Size = new System.Drawing.Size(183, 26);
            this.tbTechnology.TabIndex = 6;
            // 
            // tbSubservice
            // 
            this.tbSubservice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbSubservice.Location = new System.Drawing.Point(508, 340);
            this.tbSubservice.Name = "tbSubservice";
            this.tbSubservice.Size = new System.Drawing.Size(183, 26);
            this.tbSubservice.TabIndex = 7;
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpMain.SetColumnSpan(this.btnUpdateService, 2);
            this.btnUpdateService.Location = new System.Drawing.Point(324, 372);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(151, 42);
            this.btnUpdateService.TabIndex = 8;
            this.btnUpdateService.Text = "Update service";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // lblServiceToUpdate
            // 
            this.lblServiceToUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblServiceToUpdate.AutoSize = true;
            this.lblServiceToUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblServiceToUpdate.Location = new System.Drawing.Point(133, 53);
            this.lblServiceToUpdate.Name = "lblServiceToUpdate";
            this.lblServiceToUpdate.Size = new System.Drawing.Size(133, 20);
            this.lblServiceToUpdate.TabIndex = 9;
            this.lblServiceToUpdate.Text = "Service to update";
            // 
            // cbServiceToUpdate
            // 
            this.cbServiceToUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbServiceToUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServiceToUpdate.FormattingEnabled = true;
            this.cbServiceToUpdate.Location = new System.Drawing.Point(508, 42);
            this.cbServiceToUpdate.Name = "cbServiceToUpdate";
            this.cbServiceToUpdate.Size = new System.Drawing.Size(183, 28);
            this.cbServiceToUpdate.TabIndex = 10;
            // 
            // UpdateServiceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateServiceDialog";
            this.Text = "UpdateServiceDialog";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTechnology;
        private System.Windows.Forms.Label lblSubservice;
        private System.Windows.Forms.TextBox tbServiceName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbTechnology;
        private System.Windows.Forms.TextBox tbSubservice;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Label lblServiceToUpdate;
        private System.Windows.Forms.ComboBox cbServiceToUpdate;
    }
}