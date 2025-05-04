using SoftwareFirmManagement.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement.DL
{
    public class SalaryDL
    {
        public static bool AddSalaryToDatabase(Salary salary)
        {
            try
            {
                string formattedDate = salary.Date.ToString("yyyy-MM-dd");
                string query = $"CALL sp_manage_salary('add', {salary.SalaryId}, {salary.EmployeeId}, '{formattedDate}', {salary.Amount}, {salary.Bonus});";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool UpdateSalaryToDatabase(Salary salary) // payDate, amount and bonus can be updated
        {
            try
            {
                string formattedDate = salary.Date.ToString("yyyy-MM-dd");
                string query = $"CALL sp_manage_salary('update', {salary.SalaryId}, {salary.EmployeeId}, '{formattedDate}', {salary.Amount}, {salary.Bonus}) ;";
                DatabaseHelper.Instance.Update(query);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static bool DeleteSalaryFromDatabase(Salary salary)
        {
            try
            {
                string formattedDate = salary.Date.ToString("yyyy-MM-dd");
                string query = $"CALL sp_manage_salary('delete', {salary.SalaryId}, {salary.EmployeeId}, '{formattedDate}', {salary.Amount}, {salary.Bonus}) ;";
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
