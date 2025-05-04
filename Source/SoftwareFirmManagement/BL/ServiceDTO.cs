using SoftwareFirmManagement.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement.BL
{
    public class ServiceDTO
    {
        private int serviceId;
        private string name;
        private int categoryId;
        private string description;
        private SubServiceDAO subservice;
        private TechnologyDAO technology;

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
        public SubServiceDAO Subservice
        {
            get { return subservice; }
            set { subservice = value; }
        }
        public TechnologyDAO Technology
        {
            get { return technology; }
            set { technology = value; }
        }


        public ServiceDTO() { }


        public ServiceDTO(int serviceId, string name, int categoryId, string description)
        {
            this.serviceId = serviceId;
            this.name = name;
            this.categoryId = categoryId;
            this.description = description;
            technology = new TechnologyDAO(); // composition
            subservice = new SubServiceDAO(); // composition
        }


        public void AddSubservice(string description)
        {
            subservice = new SubServiceDAO(serviceId, description);
        }


        public void AddTechnology(string description)
        {
            technology = new TechnologyDAO(serviceId, description);
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
