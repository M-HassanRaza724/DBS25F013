using DbFinalProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.DL
{
    public class ServiceDL
    {
        public static List<Service> allServices = new List<Service>();

        public static void LoadAllServices()
        {
            try
            {
                allServices.Clear();
                //string query = "SELECT s.service_id, s.name, s.category_id, s.description, si.service_involved, st.technology FROM services s LEFT JOIN serviceinvolved si ON si.service_id = s.service_id LEFT JOIN servicetechnologies st ON st.service_id = s.service_id;"; // get_services is a view
                string query = "SELECT * FROM get_services;";
                using (var data = DatabaseHelper.Instance.GetData(query))
                {
                    while (data.Read())
                    {
                        int serviceId = data.IsDBNull(0) ? 0 : data.GetInt32(0);
                        string name = data[1].ToString();
                        int categoryId = data.IsDBNull(2) ? 0 : data.GetInt32(2);
                        string description = data[3].ToString();
                        string subserviceDescription = data.IsDBNull(4) ? "null" : data[4].ToString();
                        string techDescription = data.IsDBNull(5) ? "null" : data[5].ToString();
                        Service service = new Service(serviceId, name, categoryId, description);
                        service.Subservice = new SubService(serviceId, subserviceDescription);
                        service.Technology = new Technology(serviceId, techDescription);
                        allServices.Add(service);
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool AddServiceToDatabase(Service service) // service name must be unique
        {
            try
            {
                string query1 = $"CALL sp_manage_service('add', {service.ServiceId}, '{service.Name}', {service.CategoryId}, '{service.Description}');";
                DatabaseHelper.Instance.Update(query1);
                LoadAllServices();
                int serviceId = allServices
                                .Where(s => s.Name == service.Name)
                                .Select(s => s.ServiceId)
                                .FirstOrDefault();
                string query2 = $"CALL sp_manage_subservice('add', {serviceId}, '{service.Subservice.Description}');";
                DatabaseHelper.Instance.Update(query2);
                string query3 = $"CALL sp_manage_technology('add', {serviceId}, '{service.Technology.Description}')";
                DatabaseHelper.Instance.Update(query3);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool UpdateServiceToDatabase(Service service)
        {
            try
            {
                string query = $"CALL sp_manage_service('update', {service.ServiceId}, '{service.Name}', {service.CategoryId}, '{service.Description}');";
                DatabaseHelper.Instance.Update(query);
                if (service.Technology != null)
                {
                    string query2 = $"CALL sp_manage_technology('update', {service.ServiceId}, '{service.Technology.Description}')";
                    DatabaseHelper.Instance.Update(query2);
                }
                if (service.Subservice != null)
                {
                    string query3 = $"CALL sp_manage_subservice('update', {service.ServiceId}, '{service.Subservice.Description}');";
                    DatabaseHelper.Instance.Update(query3);
                }
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool DeleteServiceFromDatabase(Service service)
        {
            try
            {
                string query1 = $"CALL sp_manage_technology('delete', {service.ServiceId}, '{service.Technology.Description}')";
                DatabaseHelper.Instance.Update(query1);
                string query2 = $"CALL sp_manage_subservice('delete', {service.ServiceId}, '{service.Subservice.Description}');";
                DatabaseHelper.Instance.Update(query2);
                string query = $"CALL sp_manage_service('delete', {service.ServiceId}, '{service.Name}', {service.CategoryId}, '{service.Description}');";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }

        }


        public static bool UpdateTechnology(Technology technology)
        {
            try
            {
                string query = $"CALL sp_manage_technology('update', {technology.ServiceID}, '{technology.Description}');";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool UpdateSubservice(SubService subservice)
        {
            try
            {
                string query = $"CALL sp_manage_subservice('update', {subservice.ServiceId}, '{subservice.Description}');";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


    }
}
