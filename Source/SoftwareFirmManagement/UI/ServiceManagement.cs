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
    public partial class ServiceManagement : KryptonForm
    {
        private List<ServiceDisplay> services = new List<ServiceDisplay>();
        public ServiceManagement()
        {
            InitializeComponent();
            int i = 0;
            foreach (ServiceDTO s in ServiceDL.allServices)
            {
                ServiceDisplay serviceDisplay = new ServiceDisplay();
                serviceDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
                serviceDisplay.BackColor = System.Drawing.Color.Transparent;
                serviceDisplay.Location = new System.Drawing.Point(40, 133 + (i*260));
                serviceDisplay.Name = $"service{i+1}";
                serviceDisplay.Service = s;
                serviceDisplay.Size = new System.Drawing.Size(578, 225);
                serviceDisplay.TabIndex = 0;
                services.Add(serviceDisplay);
                this.pnl_main.Controls.Add(services[i]);
                i++;    
            }
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue > 0)
            {
                foreach (ServiceDisplay service in services)
                {
                    service.Location = new Point(service.Location.X, service.Location.Y - e.NewValue);
                }
            }
            else
            {
                foreach (ServiceDisplay service in services)
                {
                    service.Location = new Point(service.Location.X, service.Location.Y + e.NewValue);
                }
            }
        }
    }
}
