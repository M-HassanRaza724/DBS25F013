using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using DbFinalProject.DL;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;

namespace DbFinalProject.BL
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


        public Service(string name, int categoryId, string description)
        {
            this.name = name;
            this.categoryId = categoryId;
            this.description = description;
            technology = new Technology(); // composition
            subservice = new SubService(); // composition
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


        public static List<string> GetServiceNames()
        {
            List<string> names = ServiceDL.allServices
                                 .Select(x => x.Name)
                                 .ToList();
            return names;
        }


        public static bool DeleteServiceByName(string name)
        {
            Service service = ServiceDL.allServices
                              .Where(s => s.Name == name)
                              .FirstOrDefault();
            try
            {
                return service.Delete();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool NameIsUnique(string name)
        {
            foreach (var service in ServiceDL.allServices)
            {
                if (service.Name == name)
                {
                    return false;
                }
            }
            return true;
        }


        public static Service GetServiceFromName(string name)
        {
            return ServiceDL.allServices
                   .Where(s => s.Name == name)
                   .FirstOrDefault();
        }

    }
}
