using DbFinalProject.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFinalProject.ReportForms
{
    public partial class AdminsReportForm: Form
    {
        public AdminsReportForm()
        {
            InitializeComponent();
        }


        private void AdminsReportForm_Load(object sender, EventArgs e)
        {
            AdminDGV_DL.LoadAdmins();
            this.adminDGVBindingSource.DataSource = AdminDGV_DL.allAdmins;
            this.reportViewer1.RefreshReport();
        }
    }
}
