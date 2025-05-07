using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
            LoadServices();
            
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
                serviceDisplay.Location = new System.Drawing.Point(12, 250 + (i * 260));
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
                pnl_main.Location = new Point(pnl_main.Location.X , pnl_main.Location.Y - e.NewValue);
            }
            else
            {
                pnl_main.Location = new Point(pnl_main.Location.X, pnl_main.Location.Y + e.NewValue);
            }
            if(e.NewValue == 0)
            {
                this.pnl_main.Location = new System.Drawing.Point(0, 0);

            }
            if (e.NewValue == 100)
            {
                this.pnl_main.Location = new System.Drawing.Point(0, -pnl_main.Height);

            }
        }

        private void customerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
