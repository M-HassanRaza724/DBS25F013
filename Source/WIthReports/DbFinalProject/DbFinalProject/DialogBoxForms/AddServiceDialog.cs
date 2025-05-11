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

namespace DbFinalProject.ChildForms
{
    public partial class AddServiceDialog : Form
    {
        public AddServiceDialog()
        {
            InitializeComponent();
            List<string> values = Lookup.GetValuesFromKeyGroup("service");
            foreach (var value in values)
            {
                cbCategory.Items.Add(value);
            }
        }


        private void btnAddService_Click(object sender, EventArgs e)
        {
            string name = tbServiceName.Text;
            string description = tbDescription.Text;
            string value = cbCategory.SelectedItem?.ToString();
            string subserviceDescription = tbSubservice.Text;
            string techDescription = tbTechnology.Text;
            if (name == null || description == null || value == null || techDescription == null)
            {
                MessageBox.Show("Please provide service name, description and category.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int categoryId = Lookup.GetLookupIdFromValue(value);
            if (!Service.NameIsUnique(name))
            {
                MessageBox.Show("Another service with the same name exists. Please enter a unique service name.", "Name Not Unique", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Service newService = new Service(name, categoryId, description);
                newService.Technology = new Technology(techDescription);
                newService.Subservice = new SubService(subserviceDescription);
                newService.Add();
                MessageBox.Show("Service added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
