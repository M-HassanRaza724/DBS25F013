namespace DbFinalProject
{
    partial class LoginSingUpForm
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
            this.tlpMainLogin = new System.Windows.Forms.TableLayoutPanel();
            this.lblAppHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tlpLoginMenuStrip = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pLoginSignUp = new System.Windows.Forms.Panel();
            this.tlpMainLogin.SuspendLayout();
            this.tlpLoginMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainLogin
            // 
            this.tlpMainLogin.ColumnCount = 1;
            this.tlpMainLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainLogin.Controls.Add(this.lblAppHeader, 0, 0);
            this.tlpMainLogin.Controls.Add(this.btnExit, 0, 3);
            this.tlpMainLogin.Controls.Add(this.tlpLoginMenuStrip, 0, 1);
            this.tlpMainLogin.Controls.Add(this.pLoginSignUp, 0, 2);
            this.tlpMainLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainLogin.Location = new System.Drawing.Point(0, 0);
            this.tlpMainLogin.Name = "tlpMainLogin";
            this.tlpMainLogin.RowCount = 4;
            this.tlpMainLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMainLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMainLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMainLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMainLogin.Size = new System.Drawing.Size(1058, 618);
            this.tlpMainLogin.TabIndex = 0;
            // 
            // lblAppHeader
            // 
            this.lblAppHeader.AutoSize = true;
            this.lblAppHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAppHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppHeader.Location = new System.Drawing.Point(3, 0);
            this.lblAppHeader.Name = "lblAppHeader";
            this.lblAppHeader.Size = new System.Drawing.Size(1052, 123);
            this.lblAppHeader.TabIndex = 0;
            this.lblAppHeader.Text = "Software Firm Management System";
            this.lblAppHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Location = new System.Drawing.Point(3, 557);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 58);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tlpLoginMenuStrip
            // 
            this.tlpLoginMenuStrip.ColumnCount = 4;
            this.tlpLoginMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLoginMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLoginMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLoginMenuStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpLoginMenuStrip.Controls.Add(this.btnLogin, 1, 0);
            this.tlpLoginMenuStrip.Controls.Add(this.btnSignUp, 2, 0);
            this.tlpLoginMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLoginMenuStrip.Location = new System.Drawing.Point(3, 126);
            this.tlpLoginMenuStrip.Name = "tlpLoginMenuStrip";
            this.tlpLoginMenuStrip.RowCount = 1;
            this.tlpLoginMenuStrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLoginMenuStrip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpLoginMenuStrip.Size = new System.Drawing.Size(1052, 55);
            this.tlpLoginMenuStrip.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Location = new System.Drawing.Point(266, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(257, 49);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.Info;
            this.btnSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignUp.Location = new System.Drawing.Point(529, 3);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(257, 49);
            this.btnSignUp.TabIndex = 1;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pLoginSignUp
            // 
            this.pLoginSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoginSignUp.Location = new System.Drawing.Point(3, 187);
            this.pLoginSignUp.Name = "pLoginSignUp";
            this.pLoginSignUp.Size = new System.Drawing.Size(1052, 364);
            this.pLoginSignUp.TabIndex = 3;
            // 
            // LoginSingUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 618);
            this.Controls.Add(this.tlpMainLogin);
            this.Name = "LoginSingUpForm";
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpMainLogin.ResumeLayout(false);
            this.tlpMainLogin.PerformLayout();
            this.tlpLoginMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainLogin;
        private System.Windows.Forms.Label lblAppHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tlpLoginMenuStrip;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Panel pLoginSignUp;
    }
}