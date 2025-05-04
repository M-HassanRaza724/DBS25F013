using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareFirmManagement.UI
{
    public partial class ServiceDisplay: UserControl
    {

        private string serviceName;
        public string ServiceName
        {
            get { return serviceName; }
            set
            {
                serviceName = value;
                lbl_name_text.Text = serviceName;
            }
        }
        private string serviceDescription;
        public string ServiceDescription
        {
            get { return serviceDescription; }
            set
            {
                serviceDescription = value;
                lbl_description_text.Text = serviceDescription;
            }
        }
        private List<string> serviceTechnologies;
        public List<string> ServiceTechnologies
        {
            get { return serviceTechnologies; }
            set
            {
                serviceTechnologies = value;
                lbl_technologies_text.Text = String.Join(", ", serviceTechnologies);
            }
        }
        private List<string> subServices;
        public List<string> SubServices
        {
            get { return subServices; }
            set
            {
                subServices = value;
                lbl_sub_services_text.Text = String.Join(", ", subServices);
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
