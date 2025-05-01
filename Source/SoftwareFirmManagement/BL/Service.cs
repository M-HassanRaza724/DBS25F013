using SoftwareFirmManagement.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement.BL
{
    public class Service
    {
        private int serviceId;
        private string name;
        private int categoryId;
        private string description;
        private SubService subservice;
        private Technology technology;

        public int ServiceId
        {
            get { return serviceId; }
            set { serviceId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
        public SubService Subservice
        {
            get { return subservice; }
            set { subservice = value; }
        }
        public Technology Technology
        {
            get { return technology; }
            set { technology = value; }
        }



        public Service(int serviceId, string name, int categoryId, string description)
        {
            this.serviceId = serviceId;
            this.name = name;
            this.categoryId = categoryId;
            this.description = description;
            technology = new Technology(); // composition
            subservice = new SubService(); // composition
        }


        public void AddSubservice(string description)
        {
            subservice = new SubService(serviceId, description);
            ServiceDL.LoadAllServices();
        }


        public void AddTechnology(string description)
        {
            technology = new Technology(serviceId, description);
            ServiceDL.LoadAllServices();
        }


        public bool Add()
        {
            try
            {
                bool status = ServiceDL.AddServiceToDatabase(this);
                ServiceDL.LoadAllServices();
                return status;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public bool Update()
        {
            try
            {
                bool status = ServiceDL.UpdateServiceToDatabase(this);
                ServiceDL.LoadAllServices();
                return status;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public bool Delete()
        {
            try
            {
                bool status = ServiceDL.DeleteServiceFromDatabase(this);
                ServiceDL.LoadAllServices();
                return status;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

    }
}
