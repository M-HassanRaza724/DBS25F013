using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.UI
{
    public partial class OrderPlacementForm: Form
    {
        private Customer currentCustomer;
        public OrderPlacementForm()
        {
            InitializeComponent();
            currentCustomer = (Customer)Program.CurrentUser;
        }
        private void OrderPlacementForm_Load(object sender, EventArgs e)
        {
            try
            {
                LookupDL.LoadAllLookups();
                ServiceDL.LoadAllServices();

                cmb_platform.Items.Clear();
                var platforms = LookupDL.GetLookupsByKeyGroup("platform");
                foreach (var platform in platforms)
                {
                    cmb_platform.Items.Add(platform);
                }
                cmb_platform.DisplayMember = "Value";
                cmb_platform.ValueMember = "LookupId";

                cmb_budget.Items.Clear();
                var budgets = LookupDL.GetLookupsByKeyGroup("budget_type");
                foreach (var budget in budgets)
                {
                    cmb_budget.Items.Add(budget);
                }
                cmb_budget.DisplayMember = "Value";
                cmb_budget.ValueMember = "LookupId";

                cmb_service.Items.Clear();
                foreach (var service in ServiceDL.allServices)
                {
                    cmb_service.Items.Add(service);
                }
                cmb_service.DisplayMember = "Name";
                cmb_service.ValueMember = "ServiceId";

                if (cmb_platform.Items.Count > 0) cmb_platform.SelectedIndex = 0;
                if (cmb_budget.Items.Count > 0) cmb_budget.SelectedIndex = 0;
                if (cmb_service.Items.Count > 0) cmb_service.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading form data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_placeorder_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_platform.SelectedItem == null || cmb_budget.SelectedItem == null || cmb_service.SelectedItem == null)
                {
                    MessageBox.Show("Please select all required options", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedPlatform = (Lookup)cmb_platform.SelectedItem;
                var selectedBudget = (Lookup)cmb_budget.SelectedItem;
                var selectedService = (ServiceDTO)cmb_service.SelectedItem;
                string description = txt_description.TextBoxText;

                int statusId = LookupDL.GetLookupId("status", "Pending");

                OrderDTO newOrder = new OrderDTO(
                    null,
                    currentCustomer,
                    statusId,
                    selectedService,
                    selectedBudget.LookupId,
                    selectedPlatform.LookupId,
                    description
                );
                if (OrderDTO.AddOrder(newOrder))
                {
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to place order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
