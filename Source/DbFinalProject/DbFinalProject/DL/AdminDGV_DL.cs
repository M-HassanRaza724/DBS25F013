using DbFinalProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DbFinalProject.DL
{
    public class AdminDGV_DL
    {
        public static List<AdminDGV> allAdmins = new List<AdminDGV>();

        public static void LoadAdmins()
        {
            try
            {
                allAdmins.Clear();
                string query = "SELECT * FROM get_admins_info;";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    string username = data[0].ToString();
                    string email = data[1].ToString();
                    string name = data[2].ToString();
                    string phone = data[3].ToString();
                    string role = data[4].ToString();
                    allAdmins.Add(new AdminDGV(username, email, name, phone, role));
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

    }
}
