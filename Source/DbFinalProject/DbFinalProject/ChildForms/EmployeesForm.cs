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
using DbFinalProject.DialogBoxForms;

namespace DbFinalProject.ChildForms
{
    public partial class EmployeesForm : Form
    {
        private MainForm mainForm;

        public EmployeesForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            dgvEmployees.DataSource = EmployeeDGV.GetAllEmployees();
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeAddDialog dlg = new EmployeeAddDialog();
            dlg.Show();
        }



        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            EmployeeDeleteDialog dlg = new EmployeeDeleteDialog();
            dlg.Show();
        }


        private void btnEditEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
