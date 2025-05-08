using DbFinalProject.BL;
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
    public partial class DeleteServiceDialog : Form
    {
        public DeleteServiceDialog()
        {
            InitializeComponent();
            foreach (var name in Service.GetServiceNames())
            {
                cbServiceName.Items.Add(name);
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbServiceName.SelectedItem == null)
                {
                    MessageBox.Show("Please select a service name.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string name = cbServiceName.SelectedItem.ToString();
                Service.DeleteServiceByName(name);
                MessageBox.Show("Service deleted successfully.", "Deletion successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
