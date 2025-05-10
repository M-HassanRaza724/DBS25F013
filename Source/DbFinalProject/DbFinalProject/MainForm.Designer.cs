namespace DbFinalProject
{
    partial class MainForm
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
            this.lblAppHeader = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.tlpMenuStrip = new System.Windows.Forms.TableLayoutPanel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblAppHeader, 0, 0);
            this.tlpMain.Controls.Add(this.pMain, 0, 2);
            this.tlpMain.Controls.Add(this.btnExit, 0, 3);
            this.tlpMain.Controls.Add(this.tlpMenuStrip, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.Size = new System.Drawing.Size(1047, 655);
            this.tlpMain.TabIndex = 0;
            // 
            // lblAppHeader
            // 
            this.lblAppHeader.AutoSize = true;
            this.lblAppHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAppHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppHeader.Location = new System.Drawing.Point(3, 0);
            this.lblAppHeader.Name = "lblAppHeader";
            this.lblAppHeader.Size = new System.Drawing.Size(1041, 131);
            this.lblAppHeader.TabIndex = 1;
            this.lblAppHeader.Text = "Software Firm Management System";
            this.lblAppHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(3, 199);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1041, 419);
            this.pMain.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Location = new System.Drawing.Point(3, 624);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tlpMenuStrip
            // 
            this.tlpMenuStrip.ColumnCount = 7;
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMenuStrip.Controls.Add(this.btnReports, 6, 0);
            this.tlpMenuStrip.Controls.Add(this.btnProfile, 0, 0);
            this.tlpMenuStrip.Controls.Add(this.btnServices, 1, 0);
            this.tlpMenuStrip.Controls.Add(this.btnOrders, 2, 0);
            this.tlpMenuStrip.Controls.Add(this.btnEmployees, 3, 0);
            this.tlpMenuStrip.Controls.Add(this.btnCustomers, 4, 0);
            this.tlpMenuStrip.Controls.Add(this.btnAdmins, 5, 0);
            this.tlpMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenuStrip.Location = new System.Drawing.Point(3, 134);
            this.tlpMenuStrip.Name = "tlpMenuStrip";
            this.tlpMenuStrip.RowCount = 1;
            this.tlpMenuStrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenuStrip.Size = new System.Drawing.Size(1041, 59);
            this.tlpMenuStrip.TabIndex = 4;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.Info;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReports.Location = new System.Drawing.Point(891, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(147, 53);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.Info;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProfile.Location = new System.Drawing.Point(3, 3);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(142, 53);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.SystemColors.Info;
            this.btnServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServices.Location = new System.Drawing.Point(151, 3);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(142, 53);
            this.btnServices.TabIndex = 1;
            this.btnServices.Text = "Services";
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.SystemColors.Info;
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrders.Location = new System.Drawing.Point(299, 3);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(142, 53);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.SystemColors.Info;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployees.Location = new System.Drawing.Point(447, 3);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(142, 53);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.SystemColors.Info;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomers.Location = new System.Drawing.Point(595, 3);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(142, 53);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnAdmins
            // 
            this.btnAdmins.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmins.Location = new System.Drawing.Point(743, 3);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(142, 53);
            this.btnAdmins.TabIndex = 6;
            this.btnAdmins.Text = "Admins";
            this.btnAdmins.UseVisualStyleBackColor = false;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 655);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblAppHeader;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tlpMenuStrip;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAdmins;
    }
}