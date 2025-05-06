using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;

namespace SoftwareFirmManagement.UI
{
    public partial class ServiceDisplay: UserControl
    {
        private ServiceDTO service;

        public ServiceDTO Service
        {
            get { return service; }
            set
            {
                service = value;
                lbl_name_text.Text = value.Name;
                lbl_description_text.Text = value.Description;
                lbl_technologies_text.Text = value.Technology.Description;
                lbl_sub_services_text.Text = value.Subservice.Description;
            }
        }
        public string ServiceName
        {
            get { return service.Name; }
            set
            {
                service.Name = value;
                lbl_name_text.Text = service.Name;
            }
        }
        //private string service.Description;
        public string ServiceDescription
        {
            get { return service.Description; }
            set
            {
                service.Description = value;
                lbl_description_text.Text = service.Description;
            }
        }
        //private TechnologyDAO service.Technology;
        public TechnologyDAO ServiceTechnology
        {
            get { return service.Technology; }
            set
            {
                service.Technology = value;
                lbl_technologies_text.Text = service.Technology.Description;
            }
        }
        //private SubServiceDAO service.Subservice;
        public SubServiceDAO SubService
        {
            get { return service.Subservice; }
            set
            {
                service.Subservice = value;
                lbl_sub_services_text.Text = service.Subservice.Description;
            }
        }
        public ServiceDisplay()
        {
            InitializeComponent();
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
