namespace DbFinalProject.ChildForms
{
    partial class OrdersFormForCustomer
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
            this.tlpMenuStrip = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnPayForOrder = new System.Windows.Forms.Button();
            this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
            this.tlpMain.SuspendLayout();
            this.tlpMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpMenuStrip, 0, 0);
            this.tlpMain.Controls.Add(this.dgvCustomerOrders, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpMenuStrip
            // 
            this.tlpMenuStrip.ColumnCount = 3;
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMenuStrip.Controls.Add(this.btnPlaceOrder, 0, 0);
            this.tlpMenuStrip.Controls.Add(this.btnCancelOrder, 1, 0);
            this.tlpMenuStrip.Controls.Add(this.btnPayForOrder, 2, 0);
            this.tlpMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.tlpMenuStrip.Name = "tlpMenuStrip";
            this.tlpMenuStrip.RowCount = 1;
            this.tlpMenuStrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenuStrip.Size = new System.Drawing.Size(794, 61);
            this.tlpMenuStrip.TabIndex = 0;
            this.tlpMenuStrip.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpMenuStrip_Paint);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlaceOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlaceOrder.Location = new System.Drawing.Point(3, 3);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(258, 55);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place an order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelOrder.Location = new System.Drawing.Point(267, 3);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(258, 55);
            this.btnCancelOrder.TabIndex = 2;
            this.btnCancelOrder.Text = "Cancel an order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnPayForOrder
            // 
            this.btnPayForOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPayForOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPayForOrder.Location = new System.Drawing.Point(531, 3);
            this.btnPayForOrder.Name = "btnPayForOrder";
            this.btnPayForOrder.Size = new System.Drawing.Size(260, 55);
            this.btnPayForOrder.TabIndex = 3;
            this.btnPayForOrder.Text = "Pay for an order";
            this.btnPayForOrder.UseVisualStyleBackColor = false;
            // 
            // dgvCustomerOrders
            // 
            this.dgvCustomerOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerOrders.Location = new System.Drawing.Point(3, 70);
            this.dgvCustomerOrders.Name = "dgvCustomerOrders";
            this.dgvCustomerOrders.RowHeadersWidth = 62;
            this.dgvCustomerOrders.RowTemplate.Height = 28;
            this.dgvCustomerOrders.Size = new System.Drawing.Size(794, 377);
            this.dgvCustomerOrders.TabIndex = 1;
            // 
            // OrdersFormForCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrdersFormForCustomer";
            this.Text = "OrdersFormForCustomer";
            this.tlpMain.ResumeLayout(false);
            this.tlpMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpMenuStrip;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnPayForOrder;
        private System.Windows.Forms.DataGridView dgvCustomerOrders;
    }
}