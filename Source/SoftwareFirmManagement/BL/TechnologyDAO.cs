using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement.BL
{
    public class TechnologyDAO
    {
        private int serviceID;
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public TechnologyDAO() { }


        public TechnologyDAO(int serviceID, string description)
        {
            this.serviceID = serviceID;
            this.description = description;
        }
    }
}
