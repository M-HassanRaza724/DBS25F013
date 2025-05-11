using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFinalProject.BL;

namespace DbFinalProject.ReportForms
{
    public partial class ServicesReportForm: Form
    {
        public ServicesReportForm()
        {
            InitializeComponent();
        }


        private void ServicesReportForm_Load(object sender, EventArgs e)
        {
            this.serviceDGVBindingSource.DataSource = ServiceDGV.GetServiceDGVList();
            this.reportViewer1.RefreshReport();
        }
    }
}
