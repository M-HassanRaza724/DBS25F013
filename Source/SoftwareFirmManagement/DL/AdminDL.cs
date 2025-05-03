using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;

namespace SoftwareFirmManagement.DL
{
    public class AdminDL
    {
        public static List<Admin> GetOnlyUsersFromDatabase()
        {
            try
            {
                List<Admin> onlyUsers = new List<Admin>();
                string query = $"SELECT * FROM users;";
                var data = DatabaseHelper.Instance.GetData(query);
                while (data.Read())
                {
                    int userId = data.IsDBNull(0) ? 0 : data.GetInt32(0);
                    string username = data[1].ToString();
                    string email = data[2].ToString();
                    string password = data[3].ToString();
                    int roleId = data.IsDBNull(4) ? 0 : data.GetInt32(4);
                    Admin user = new Admin(userId, username, email, password, roleId, 0, "no_name", "no_phone", 0);
                    user.Role = LookupDL.allLookups
                                .Where(l => l.LookupId == roleId)
                                .Select(l => l.Value)
                                .FirstOrDefault();
                    onlyUsers.Add(user);
                }
                return onlyUsers;

            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

        public static bool AddAdminToDatabase(Admin admin)
        {
            try
            {
                string query = $"CALL sp_manage_admin('add', {admin.AdminId}, {admin.UserId}, '{admin.Name}', '{admin.Phone}', {admin.AdminRole});";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool UpdateAdminToDatabase(Admin updatedAdmin) // only name and phone are updatable
        {
            try
            {
                string query = $"CALL sp_manage_admin('update', {updatedAdmin.AdminId}, {updatedAdmin.UserId}, '{updatedAdmin.Name}', '{updatedAdmin.Phone}', {updatedAdmin.AdminRole});";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool DeleteAdminFromDatabase(Admin admin)
        {
            try
            {
                string query = $"CALL sp_manage_admin('delete', {admin.AdminId}, {admin.UserId}, '{admin.Name}', '{admin.Phone}', {admin.AdminRole});";
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
