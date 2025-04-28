using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement.BL
{
    public class SubService
    {
        private int serviceId;
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public SubService() { }


        public SubService(int serviceId, string description)
        {
            this.serviceId = serviceId;
            this.description = description;
        }
    }
}
