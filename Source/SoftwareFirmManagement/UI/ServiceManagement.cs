using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.UI
{
    public partial class ServiceManagement: KryptonForm
    {
        private List<ServiceDisplay> services = new List<ServiceDisplay>();
        public ServiceManagement()
        {
            InitializeComponent();

            foreach(ServiceDTO s in ServiceDL.allServices)
            {
                ServiceDisplay serviceDisplay = new ServiceDisplay();
                serviceDisplay.ServiceName = s.Name;
                serviceDisplay.ServiceDescription = s.Description;
                serviceDisplay.ServiceTechnologies = s.Technology;
                serviceDisplay.SubServices = s.Subservice;
                services.Add(serviceDisplay);
            }
        }
    }
}
