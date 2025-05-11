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
    public partial class EmployeesReportForm: Form
    {
        public EmployeesReportForm()
        {
            InitializeComponent();
        }

        private void EmployeesReportForm_Load(object sender, EventArgs e)
        {
            EmployeeDGV_DL.LoadEmployees();
            this.employeeDGVBindingSource.DataSource = EmployeeDGV_DL.allEmployees;
            this.reportViewer1.RefreshReport();
        }
    }
}
