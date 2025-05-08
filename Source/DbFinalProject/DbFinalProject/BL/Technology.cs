using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.BL
{
    public class Technology
    {
        private int serviceID;
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }



        public Technology() { }


        public Technology(int serviceID, string description)
        {
            this.serviceID = serviceID;
            this.description = description;
        }


        public Technology(string description)
        {
            this.description = description;
        }

    }
}
