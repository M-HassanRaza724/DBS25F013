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
        public static List<Service> allServices = new List<Service>();

        public static void LoadAllServices()
        {
            try
            {
                string query = "SELECT * FROM services s LEFT JOIN serviceinvolved si ON si.service_id=s.service_id LEFT JOIN servicetechnologies st ON si.service_id=s.service_id";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    int serviceId = data.IsDBNull(0) ? 0 : data.GetInt32(0);
                    string name = data[1].ToString();
                    int categoryId = data.IsDBNull(2) ? 0 : data.GetInt32(2);
                    string description = data[3].ToString();
                    string subserviceDescription = data.IsDBNull(4) ? "null" : data[5].ToString();
                    string techDescription = data.IsDBNull(5) ? "null" : data[7].ToString();
                    Service service = new Service(serviceId, name, categoryId, description);
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
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static bool AddServiceToDatabase(Service service)
        {
            try
            {
                string query1 = $"INSERT INTO services VALUES ({service.ServiceId}, '{service.Name}', {service.CategoryId}, '{service.Description}');";
                DatabaseHelper.Instance.Update(query1);
                if (service.Subservice != null)
                {
                    string query = $"INSERT INTO serviceinvolved VALUES ({service.ServiceId}, '{service.Subservice.Description}');";
                    DatabaseHelper.Instance.Update(query);
                }
                if (service.Technology != null)
                {
                    string query = $"INSERT INTO servicetechnologies VALUES ({service.ServiceId}, '{service.Technology.Description}');";
                    DatabaseHelper.Instance.Update (query);
                }
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static bool UpdateServiceToDatabase(Service service)
        {
            try
            {
                string query = $"UPDATE services SET name = '{service.Name}', description = '{service.Description}' WHERE service_id = {service.ServiceId};";
                DatabaseHelper.Instance.Update(query);
                if (service.Technology != null)
                {
                    string query2 = $"UPDATE servicetechnologies SET technology = '{service.Technology.Description}' WHERE service_id = {service.ServiceId};";
                    DatabaseHelper.Instance.Update(query2);
                }
                if (service.Subservice != null)
                {
                    string query3 = $"UPDATE serviceinvolved SET service_involved = '{service.Subservice.Description}' WHERE service_id = {service.ServiceId};";
                    DatabaseHelper.Instance.Update(query3);
                }
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static bool DeleteServiceFromDatabase(Service service)
        {
            try
            {
                string query = $"DELETE FROM services WHERE service_id = {service.ServiceId};";
                DatabaseHelper.Instance.Update(query);
                if (service.Technology != null)
                {
                    string query1 = $"DELETE FROM servicetechnologies WHERE service_id = {service.ServiceId};";
                    DatabaseHelper.Instance.Update(query1);
                }
                if (service.Technology != null)
                {
                    string query2 = $"DELETE FROM serviceinvolved WHERE service_id = {service.ServiceId};";
                    DatabaseHelper.Instance.Update(query2);
                }
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

    }
}
