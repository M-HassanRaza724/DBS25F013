using DbFinalProject.BL;
using DbFinalProject.DialogBoxForms;
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

namespace DbFinalProject.ChildForms
{
    public partial class ServicesForm : Form
    {
        private MainForm parent;


        public ServicesForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            if (Program.currentUser is Employee || Program.currentUser is Customer)
            {
                btnAdd.Enabled = false;
                if (Program.currentUser is Customer)
                {
                    btnEdit.Enabled = false;
                }
                btnDelete.Enabled = false;
            }
            dgvServices.DataSource = ServiceDGV.GetServiceDGVList();
        }


        public ServicesForm()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddServiceDialog addServiceDialog = new AddServiceDialog();
            addServiceDialog.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteServiceDialog deleteServiceDialog = new DeleteServiceDialog();
            deleteServiceDialog.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateServiceDialog updateServiceDialog = new UpdateServiceDialog();
            updateServiceDialog.Show();
        }
    }
}
