using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbFinalProject.DL;

namespace DbFinalProject.BL
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
        public int ServiceId
        {
            get { return serviceId; }
            set { serviceId = value; }
        }


        public SubService() { }


        public SubService(int serviceId, string description)
        {
            this.serviceId = serviceId;
            this.description = description;
        }


        public SubService(string description)
        {
            this.description = description;
        }

    }
}
