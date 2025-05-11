using DbFinalProject.BL;
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
    public partial class OrdersReportForm: Form
    {
        public OrdersReportForm()
        {
            InitializeComponent();
        }


        private void OrdersReportForm_Load(object sender, EventArgs e)
        {
            this.orderDGVBindingSource.DataSource = OrderDGV.GetOrders();
            this.reportViewer1.RefreshReport();
        }
    }
}
