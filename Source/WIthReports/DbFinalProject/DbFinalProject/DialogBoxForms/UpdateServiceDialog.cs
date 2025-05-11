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

namespace DbFinalProject.DialogBoxForms
{
    public partial class UpdateServiceDialog : Form
    {
        public UpdateServiceDialog()
        {
            InitializeComponent();
            foreach (var name in Service.GetServiceNames())
            {
                cbServiceToUpdate.Items.Add(name);
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            if (cbServiceToUpdate.SelectedItem == null)
            {
                MessageBox.Show("Please select a service to update.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string toUpdateName = cbServiceToUpdate.SelectedItem.ToString();
            Service toUpdate = Service.GetServiceFromName(toUpdateName);
            string updatedName = tbServiceName.Text;
            string updatedDescription = tbDescription.Text;
            string updatedSubservice = tbSubservice.Text;
            string updatedTechnology = tbTechnology.Text;
            // service name cannot be empty
            if (updatedName == "")
            {
                MessageBox.Show("Service name cannot be blank.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // not all update fields can be empty
            if (updatedName == "" &&  updatedDescription == "" && updatedSubservice == "" && updatedTechnology == "")
            {
                MessageBox.Show("No new data provided. No updates made.", "Update Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            toUpdate.Name = updatedName;
            toUpdate.Description = updatedDescription;
            toUpdate.Technology.Description = updatedTechnology;
            toUpdate.Subservice.Description = updatedSubservice;
            try
            {
                toUpdate.Update();
                MessageBox.Show("Service updated.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
