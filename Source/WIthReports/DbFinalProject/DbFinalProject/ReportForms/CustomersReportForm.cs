using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFinalProject.DL;

namespace DbFinalProject.ReportForms
{
    public partial class CustomersReportForm: Form
    {
        public CustomersReportForm()
        {
            InitializeComponent();
        }


        private void CustomersReportForm_Load(object sender, EventArgs e)
        {
            CustomerDGV_DL.LoadCustomers();
            this.customerDGVBindingSource.DataSource = CustomerDGV_DL.customersForDGV;
            this.reportViewer1.RefreshReport();
        }
    }
}
