using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFinalProject.ChildForms;

namespace DbFinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void LoadChildForm(Form childForm)
        {
            pMain.Controls.Clear();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pMain.Controls.Add(childForm);
            childForm.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

    }
}