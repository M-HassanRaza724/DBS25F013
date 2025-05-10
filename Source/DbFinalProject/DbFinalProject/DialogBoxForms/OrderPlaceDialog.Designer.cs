namespace DbFinalProject.DialogBoxForms
{
    partial class OrderPlaceDialog
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
            this.lblService = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.dtmDueDate = new System.Windows.Forms.DateTimePicker();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.lblService, 0, 0);
            this.tlpMain.Controls.Add(this.lblDueDate, 0, 1);
            this.tlpMain.Controls.Add(this.btnPlaceOrder, 0, 2);
            this.tlpMain.Controls.Add(this.cbService, 1, 0);
            this.tlpMain.Controls.Add(this.dtmDueDate, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // lblService
            // 
            this.lblService.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblService.Location = new System.Drawing.Point(169, 130);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(61, 20);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDueDate.Location = new System.Drawing.Point(162, 280);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(75, 20);
            this.lblDueDate.TabIndex = 1;
            this.lblDueDate.Text = "Due date";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpMain.SetColumnSpan(this.btnPlaceOrder, 2);
            this.btnPlaceOrder.Location = new System.Drawing.Point(346, 303);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(107, 38);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // cbService
            // 
            this.cbService.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(499, 119);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(201, 28);
            this.cbService.TabIndex = 3;
            // 
            // dtmDueDate
            // 
            this.dtmDueDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtmDueDate.Location = new System.Drawing.Point(500, 271);
            this.dtmDueDate.Name = "dtmDueDate";
            this.dtmDueDate.Size = new System.Drawing.Size(200, 26);
            this.dtmDueDate.TabIndex = 4;
            // 
            // OrderPlaceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderPlaceDialog";
            this.Text = "OrderPlaceDialog";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.DateTimePicker dtmDueDate;
    }
}