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
using DbFinalProject.ChildForms;
using DbFinalProject.ReportForms;

namespace DbFinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (Program.currentUser is Customer || Program.currentUser is Employee)
            {
                btnEmployees.Enabled = false;
                btnCustomers.Enabled = false;
                btnAdmins.Enabled = false;
                btnReports.Enabled = false;
            }
        }


        public void LoadChildForm(Form childForm)
        {
            pMain.Controls.Clear();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pMain.Controls.Add(childForm);
            childForm.Show();
        }


        private void btnServices_Click(object sender, EventArgs e)
        {
            LoadChildForm(new ServicesForm(this));
        }


        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoadChildForm(new ProfileForm(this));
        }


        private void btnCustomers_Click(object sender, EventArgs e)
        {
            LoadChildForm(new CustomersForm(this));
        }


        private void btnEmployees_Click(object sender, EventArgs e)
        {
            LoadChildForm(new EmployeesForm(this));
        }


        private void btnAdmins_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AdminsForm());
        }


        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (Program.currentUser is Customer)
            {
                LoadChildForm(new OrdersFormForCustomer(this));
            }
            else
            {
                LoadChildForm(new OrdersForm());
            }
        }


        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadChildForm(new ReportsForms());
             
        }
    }
}