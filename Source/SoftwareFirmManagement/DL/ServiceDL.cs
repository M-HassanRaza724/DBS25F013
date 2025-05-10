using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;

namespace SoftwareFirmManagement.DL
{
    public class ServiceDL
    {
        public static List<ServiceDTO> allServices = new List<ServiceDTO>();

        public static void LoadAllServices()
        {
            try
            {
                allServices.Clear();
                string query = "SELECT * FROM get_services;"; // get_services is a view
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    int serviceId = data.IsDBNull(0) ? 0 : data.GetInt32(0);
                    string name = data.GetString(1);
                    int categoryId = data.IsDBNull(2) ? 0 : data.GetInt32(2);
                    string description = data.GetString(3);
                    string subserviceDescription = data.IsDBNull(4) ? "null" : data.GetString(4);
                    string techDescription = data.IsDBNull(5) ? "null" : data.GetString(5);
                    ServiceDTO service = new ServiceDTO(serviceId, name, categoryId, description);
                    if (subserviceDescription != "null")
                    {
                        service.AddSubservice(subserviceDescription);
                    }
                    if (techDescription != "null")
                    {
                        service.AddTechnology(techDescription);
                    }
                    allServices.Add(service);
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool AddServiceToDatabase(ServiceDTO service)
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
                if (service.Subservice != null)
                {
                    string query = $"CALL sp_manage_subservice('add', {serviceId}, '{service.Subservice.Description}');";
                    DatabaseHelper.Instance.Update(query);
                }
                if (service.Technology != null)
                {
                    string query = $"CALL sp_manage_technology('add', {serviceId}, '{service.Technology.Description}')";
                    DatabaseHelper.Instance.Update (query);
                }
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool UpdateServiceToDatabase(ServiceDTO service)
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


        public static bool DeleteServiceFromDatabase(ServiceDTO service)
        {
            try
            {
                string query = $"CALL sp_manage_service('delete', {service.ServiceId}, '{service.Name}', {service.CategoryId}, '{service.Description}');";
                DatabaseHelper.Instance.Update(query);
                //if (service.Technology != null)
                //{
                //    string query1 = $"CALL sp_manage_technology('delete', {service.ServiceId}, '{service.Technology.Description}')";
                //    DatabaseHelper.Instance.Update(query1);
                //}
                //if (service.Subservice != null)
                //{
                //    string query2 = $"CALL sp_manage_subservice('add', {service.ServiceId}, '{service.Subservice.Description}');";
                //    DatabaseHelper.Instance.Update(query2);
                //}
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }

        }


    }
}
