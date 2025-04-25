using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;

namespace SoftwareFirmManagement.BL
{
    public class AdminDL
    {
        public static bool AddAdminToDatabase(Admin admin)
        {
            try
            {
                string query = $"INSERT INTO admins VALUES ({admin.AdminId}, {admin.UserId}, '{admin.Name}', '{admin.Phone}', {admin.AdminRole});";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static bool UpdateAdminToDatabase(Admin updatedAdmin) // only name and phone are updatable
        {
            try
            {
                string query = $"UPDATE admins SET name = '{updatedAdmin.Name}', phone = '{updatedAdmin.Phone}') WHERE admin_id = {updatedAdmin.AdminId};";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static bool DeleteAdminFromDatabase(Admin admin)
        {
            try
            {
                string query = $"DELETE FROM admins WHERE admin_id = {admin.AdminId};";
                DatabaseHelper.Instance.Update(query);
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
