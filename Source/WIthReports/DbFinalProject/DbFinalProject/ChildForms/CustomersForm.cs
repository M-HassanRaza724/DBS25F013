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
    public partial class CustomersForm : Form
    {
        private MainForm parent;

        public CustomersForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            dgvCustomers.DataSource = CustomerDGV.GetAllCustomers();
        }


        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            CustomerDeleteDialog dlg = new CustomerDeleteDialog();
            dlg.Show();
        }
    }
}
