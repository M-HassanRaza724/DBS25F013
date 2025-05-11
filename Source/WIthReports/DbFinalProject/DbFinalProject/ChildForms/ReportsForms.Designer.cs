namespace DbFinalProject.ChildForms
{
    partial class ReportsForms
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
            this.tlpMenuStrip1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnServicesReport = new System.Windows.Forms.Button();
            this.pReports = new System.Windows.Forms.Panel();
            this.btnOrdersReport = new System.Windows.Forms.Button();
            this.btnCustomersReport = new System.Windows.Forms.Button();
            this.btnEmployeesReport = new System.Windows.Forms.Button();
            this.btnAdminsReport = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpMenuStrip1, 0, 0);
            this.tlpMain.Controls.Add(this.pReports, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpMenuStrip1
            // 
            this.tlpMenuStrip1.ColumnCount = 5;
            this.tlpMenuStrip1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenuStrip1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenuStrip1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenuStrip1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenuStrip1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenuStrip1.Controls.Add(this.btnServicesReport, 0, 0);
            this.tlpMenuStrip1.Controls.Add(this.btnOrdersReport, 1, 0);
            this.tlpMenuStrip1.Controls.Add(this.btnCustomersReport, 2, 0);
            this.tlpMenuStrip1.Controls.Add(this.btnEmployeesReport, 3, 0);
            this.tlpMenuStrip1.Controls.Add(this.btnAdminsReport, 4, 0);
            this.tlpMenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenuStrip1.Location = new System.Drawing.Point(3, 3);
            this.tlpMenuStrip1.Name = "tlpMenuStrip1";
            this.tlpMenuStrip1.RowCount = 1;
            this.tlpMenuStrip1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenuStrip1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpMenuStrip1.Size = new System.Drawing.Size(794, 61);
            this.tlpMenuStrip1.TabIndex = 0;
            // 
            // btnServicesReport
            // 
            this.btnServicesReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnServicesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServicesReport.Location = new System.Drawing.Point(3, 3);
            this.btnServicesReport.Name = "btnServicesReport";
            this.btnServicesReport.Size = new System.Drawing.Size(152, 55);
            this.btnServicesReport.TabIndex = 0;
            this.btnServicesReport.Text = "Services report";
            this.btnServicesReport.UseVisualStyleBackColor = false;
            this.btnServicesReport.Click += new System.EventHandler(this.btnServicesReport_Click);
            // 
            // pReports
            // 
            this.pReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pReports.Location = new System.Drawing.Point(3, 70);
            this.pReports.Name = "pReports";
            this.pReports.Size = new System.Drawing.Size(794, 377);
            this.pReports.TabIndex = 1;
            // 
            // btnOrdersReport
            // 
            this.btnOrdersReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOrdersReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrdersReport.Location = new System.Drawing.Point(161, 3);
            this.btnOrdersReport.Name = "btnOrdersReport";
            this.btnOrdersReport.Size = new System.Drawing.Size(152, 55);
            this.btnOrdersReport.TabIndex = 1;
            this.btnOrdersReport.Text = "Orders report";
            this.btnOrdersReport.UseVisualStyleBackColor = false;
            this.btnOrdersReport.Click += new System.EventHandler(this.btnOrdersReport_Click);
            // 
            // btnCustomersReport
            // 
            this.btnCustomersReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCustomersReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomersReport.Location = new System.Drawing.Point(319, 3);
            this.btnCustomersReport.Name = "btnCustomersReport";
            this.btnCustomersReport.Size = new System.Drawing.Size(152, 55);
            this.btnCustomersReport.TabIndex = 2;
            this.btnCustomersReport.Text = "Customers report";
            this.btnCustomersReport.UseVisualStyleBackColor = false;
            this.btnCustomersReport.Click += new System.EventHandler(this.btnCustomersReport_Click);
            // 
            // btnEmployeesReport
            // 
            this.btnEmployeesReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEmployeesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployeesReport.Location = new System.Drawing.Point(477, 3);
            this.btnEmployeesReport.Name = "btnEmployeesReport";
            this.btnEmployeesReport.Size = new System.Drawing.Size(152, 55);
            this.btnEmployeesReport.TabIndex = 3;
            this.btnEmployeesReport.Text = "Employees report";
            this.btnEmployeesReport.UseVisualStyleBackColor = false;
            this.btnEmployeesReport.Click += new System.EventHandler(this.btnEmployeesReport_Click);
            // 
            // btnAdminsReport
            // 
            this.btnAdminsReport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdminsReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminsReport.Location = new System.Drawing.Point(635, 3);
            this.btnAdminsReport.Name = "btnAdminsReport";
            this.btnAdminsReport.Size = new System.Drawing.Size(156, 55);
            this.btnAdminsReport.TabIndex = 4;
            this.btnAdminsReport.Text = "Admins report";
            this.btnAdminsReport.UseVisualStyleBackColor = false;
            this.btnAdminsReport.Click += new System.EventHandler(this.btnAdminsReport_Click);
            // 
            // ReportsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForms";
            this.Text = "ReportsForms";
            this.tlpMain.ResumeLayout(false);
            this.tlpMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpMenuStrip1;
        private System.Windows.Forms.Button btnServicesReport;
        private System.Windows.Forms.Panel pReports;
        private System.Windows.Forms.Button btnOrdersReport;
        private System.Windows.Forms.Button btnCustomersReport;
        private System.Windows.Forms.Button btnEmployeesReport;
        private System.Windows.Forms.Button btnAdminsReport;
    }
}