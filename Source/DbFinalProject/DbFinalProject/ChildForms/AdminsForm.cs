using DbFinalProject.BL;
using DbFinalProject.DialogBoxForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFinalProject.ChildForms
{
    public partial class AdminsForm : Form
    {
        public AdminsForm()
        {
            InitializeComponent();
            dgvAdmins.DataSource = AdminDGV.GetAdmins();
            //if (Program.currentUser is Admin admin)
            //{
            //    if (admin.GetAdminRole() == "Primary admin")
            //    {
            //        btnDeleteAdmin.Enabled = true;
            //        btnAddAdmin.Enabled = true;
            //    }
            //}
            //else
            //{
            //    btnDeleteAdmin.Enabled = false;
            //    btnAddAdmin.Enabled = false;
            //}
        }


        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            AdminAddDialog dialog = new AdminAddDialog();
            dialog.Show();
        }


        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            AdminDeleteDialog dialog = new AdminDeleteDialog();
            dialog.Show();
        }
    }
}
