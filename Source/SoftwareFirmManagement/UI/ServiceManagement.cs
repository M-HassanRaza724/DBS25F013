using ComponentFactory.Krypton.Toolkit;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SoftwareFirmManagement.UI
{
    public partial class ServiceManagement : KryptonForm
    {
        MainForm parentForm;
        public MainForm ParentForm { get { return parentForm; } set { parentForm = value; } }
        private List<ServiceDisplay> services = new List<ServiceDisplay>();
        private ServiceDTO currentSelectedService = null;

        public ServiceManagement()
        {
            InitializeComponent();
            LoadServices();
            disableGroupBoxes();

        }

        private void LoadServices()
        {
            services.Clear();
            int i = 0;
            foreach (ServiceDTO s in ServiceDL.allServices)
            {
                ServiceDisplay serviceDisplay = new ServiceDisplay();
                serviceDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top)));
                serviceDisplay.BackColor = System.Drawing.Color.Transparent;
                serviceDisplay.Location = new System.Drawing.Point(((pnl_main.Width/2)-(420)), 250 + (i * 260));
                serviceDisplay.Name = $"service{i + 1}";
                serviceDisplay.Service = s;
                serviceDisplay.Size = new System.Drawing.Size(840, 225);
                serviceDisplay.TabIndex = 0;
                services.Add(serviceDisplay);
                this.pnl_main.Controls.Add(services[i]);
                pnl_main.Height += 235;
                i++;
            }

            lbl_footer.Location = new System.Drawing.Point(6, 300 + (i * 260));
            vScrollBar.Maximum = (8 * i) + 5;
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int change = e.NewValue - e.OldValue;
            if (change > 0)
            {
                pnl_main.Location = new Point(pnl_main.Location.X, pnl_main.Location.Y - e.NewValue);
            }
            else
            {
                pnl_main.Location = new Point(pnl_main.Location.X, pnl_main.Location.Y + e.NewValue);
            }
            if (e.NewValue == 0)
            {
                this.pnl_main.Location = new System.Drawing.Point(0, 0);

            }
            if (e.NewValue == 100)
            {
                this.pnl_main.Location = new System.Drawing.Point(0, -pnl_main.Height);

            }
        }
        void disableGroupBoxes()
        {
            gbx_add_service.Enabled = false;
            gbx_add_service.Visible = false;
            gbx_update_service.Enabled = false;
            gbx_update_service.Visible = false;
            gbx_delete_service.Enabled = false;
            gbx_delete_service.Visible = false;

            txt_name.PlaceHolder = "Name";
            txt_description.PlaceHolder = "Description";
            txt_technology.PlaceHolder = "Technology";
            txt_subservice.PlaceHolder = "SubServices";
        }
        void enableAddGroupBox()
        {
            disableGroupBoxes();
            gbx_add_service.Enabled = true;
            gbx_add_service.Visible = true;
            btn_add_update_services.Text = "Add Service";
            gbx_add_service.Text = "Add Service";
        }

        void enableUpdateGroupBox()
        {
            disableGroupBoxes();
            gbx_update_service.Enabled = true;
            gbx_update_service.Visible = true;
            btn_update_service.Visible = false;

            // Load services into combo box
            cmb_select_service_gbx_update_service.Items.Clear();
            foreach (ServiceDTO service in ServiceDL.allServices)
            {
                cmb_select_service_gbx_update_service.Items.Add(service.Name);
            }
        }

        void enableDeleteGroupBox()
        {
            disableGroupBoxes();
            gbx_delete_service.Enabled = true;
            gbx_delete_service.Visible = true;

            // Load services into combo box
            cmb_select_service_gbx_delete_service.Items.Clear();
            foreach (ServiceDTO service in ServiceDL.allServices)
            {
                cmb_select_service_gbx_delete_service.Items.Add(service.Name);
            }
        }

        private void AddServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableAddGroupBox();
        }

        private void UpdateServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableUpdateGroupBox();
        }

        private void deleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableDeleteGroupBox();
        }

        private void btn_delete_service_Click(object sender, EventArgs e)
        {
            if (currentSelectedService != null)
            {
                if (DialogResult.Yes == MessageBox.Show(
                    $"Are you sure you want to delete {currentSelectedService.Name}?",
                    "Warning",
                    MessageBoxButtons.YesNo))
                {
                    try
                    {
                        if (currentSelectedService.Delete())
                        {
                            MessageBox.Show("Service deleted successfully");
                            //LoadServices();
                            RefreshServices();
                            disableGroupBoxes();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_cancel_delete_service_Click(object sender, EventArgs e)
        {
            disableGroupBoxes();
        }

        private void btn_canel_update_service_Click(object sender, EventArgs e)
        {
            disableGroupBoxes();
        }

        private void btn_update_service_Click(object sender, EventArgs e)
        {
            if (currentSelectedService != null)
            {
                try
                {
                    currentSelectedService.Name = textBoxWithPlaceHolder4.TextBoxText;
                    currentSelectedService.Description = textBoxWithPlaceHolder2.TextBoxText;

                    if (!string.IsNullOrEmpty(textBoxWithPlaceHolder3.TextBoxText))
                    {
                        currentSelectedService.AddTechnology(textBoxWithPlaceHolder3.TextBoxText);
                    }

                    if (!string.IsNullOrEmpty(textBoxWithPlaceHolder1.TextBoxText))
                    {
                        currentSelectedService.AddSubservice(textBoxWithPlaceHolder1.TextBoxText);
                    }

                    if (currentSelectedService.Update())
                    {
                        MessageBox.Show("Service updated successfully");
                        //LoadServices();
                        RefreshServices();
                        disableGroupBoxes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_cancel_add_service_Click(object sender, EventArgs e)
        {
            disableGroupBoxes();
        }

        private void btn_add_update_services_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceDTO service = new ServiceDTO(0, txt_name.TextBoxText, 0, txt_description.TextBoxText);

                if (!string.IsNullOrEmpty(txt_technology.TextBoxText))
                {
                    service.AddTechnology(txt_technology.TextBoxText);
                }

                if (!string.IsNullOrEmpty(txt_subservice.TextBoxText))
                {
                    service.AddSubservice(txt_subservice.TextBoxText);
                }

                if (service.Add())
                {
                    MessageBox.Show("Service added successfully");
                    //LoadServices();
                    RefreshServices();
                    disableGroupBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_select_service_gbx_delete_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_select_service_gbx_delete_service.SelectedIndex >= 0)
            {
                currentSelectedService = ServiceDL.allServices[cmb_select_service_gbx_delete_service.SelectedIndex];

                textBoxWithPlaceHolder8.TextBoxText = currentSelectedService.Name;
                textBoxWithPlaceHolder6.TextBoxText = currentSelectedService.Description;

                if (currentSelectedService.Technology != null)
                {
                    textBoxWithPlaceHolder7.TextBoxText = currentSelectedService.Technology.Description;
                }

                if (currentSelectedService.Subservice != null)
                {
                    textBoxWithPlaceHolder5.TextBoxText = currentSelectedService.Subservice.Description;
                }
            }
        }

        private void cmb_select_service_gbx_update_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_select_service_gbx_update_service.SelectedIndex >= 0)
            {
                currentSelectedService = ServiceDL.allServices[cmb_select_service_gbx_update_service.SelectedIndex];

                textBoxWithPlaceHolder4.TextBoxText = currentSelectedService.Name;
                textBoxWithPlaceHolder2.TextBoxText = currentSelectedService.Description;

                if (currentSelectedService.Technology != null)
                {
                    textBoxWithPlaceHolder3.TextBoxText = currentSelectedService.Technology.Description;
                }

                if (currentSelectedService.Subservice != null)
                {
                    textBoxWithPlaceHolder1.TextBoxText = currentSelectedService.Subservice.Description;
                }

                btn_update_service.Visible = true;
            }
        }

        public void RefreshServices()
        {

            for (int i = 0; i < services.Count; i++)
            {
                pnl_main.Controls.Remove(services[i]);
                services[i] = null;
            }
            LoadServices();
        }
    }
}
