using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFinalProject.ReportForms;

namespace DbFinalProject.ChildForms
{
    public partial class ReportsForms: Form
    {
        public ReportsForms()
        {
            InitializeComponent();
        }


        public void LoadChildForm(Form childForm)
        {
            pReports.Controls.Clear();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pReports.Controls.Add(childForm);
            childForm.Show();
        }


        private void btnServicesReport_Click(object sender, EventArgs e)
        {
            LoadChildForm(new ServicesReportForm());
        }


        private void btnOrdersReport_Click(object sender, EventArgs e)
        {
            LoadChildForm(new OrdersReportForm());
        }


        private void btnCustomersReport_Click(object sender, EventArgs e)
        {
            LoadChildForm(new CustomersReportForm());
        }


        private void btnEmployeesReport_Click(object sender, EventArgs e)
        {
            LoadChildForm(new EmployeesReportForm());
        }


        private void btnAdminsReport_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AdminsReportForm());
        }
    }
}
