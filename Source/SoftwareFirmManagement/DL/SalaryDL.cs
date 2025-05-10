using SoftwareFirmManagement.BL;
using System;
using System.Collections.Generic;

namespace SoftwareFirmManagement.DL
{
    public class SalaryDL
    {
        public static List<Salary> allSalaries = new List<Salary>(); 
        public static bool LoadAllSalaries()
        {
            try
            {
                allSalaries.Clear();    
                string query = "SELECT * FROM all_salaries;";
                var reader = DatabaseHelper.Instance.GetData(query);
                while (reader.Read())
                {
                    int salaryId = reader.GetInt32(0);
                    int employeeId = reader.GetInt32(1);
                    string employeeName = reader.GetString(2);
                    DateTime date = reader.GetDateTime(3);
                    int amount = reader.GetInt32(4);
                    int bonus = reader.GetInt32(5);
                    Employee employee = new Employee()
                    {
                        Name = employeeName,
                        EmployeeId = employeeId,
                    };

                    allSalaries.Add(
                        new Salary()
                        {
                            SalaryId = salaryId,
                            Employee = employee,
                            Date = date,
                            Amount = amount,
                            Bonus = bonus
                        });
    }
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }


        }
        public static bool AddSalaryToDatabase(Salary salary)
        {
            try
            {
                string formattedDate = salary.Date.ToString("yyyy-MM-dd");
                string query = $"CALL sp_manage_salary('add', {salary.SalaryId}, {salary.Employee.EmployeeId}, '{formattedDate}', {salary.Amount}, {salary.Bonus});";
                DatabaseHelper.Instance.Update(query);
                AddSalaryInList(salary);
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
                string query = $"CALL sp_manage_salary('update', {salary.SalaryId}, {salary.Employee.EmployeeId}, '{formattedDate}', {salary.Amount}, {salary.Bonus}) ;";
                DatabaseHelper.Instance.Update(query);
                UpdateSalaryInList(salary);
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
                string query = $"CALL sp_manage_salary('delete', {salary.SalaryId}, {salary.Employee.EmployeeId}, '{formattedDate}', {salary.Amount}, {salary.Bonus}) ;";
                DatabaseHelper.Instance.Update(query);
                DeleteSalaryInList(salary);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

        public static bool UpdateSalaryInList(Salary salary)
        {
            for (int i = 0; i < allSalaries.Count; i++)
            {
                if (allSalaries[i].SalaryId == salary.SalaryId)
                {
                    allSalaries[i] = salary;
                    return true;
                }

            }
            return false;
        }
        public static bool AddSalaryInList(Salary salary)
        {
            allSalaries.Add(salary);
            return true;
        }
        public static bool DeleteSalaryInList(Salary salary)
        {
            for (int i = 0; i < allSalaries.Count; i++)
            {
                if (allSalaries[i].SalaryId == salary.SalaryId)
                {
                    allSalaries.RemoveAt(i);
                    return true;
                }

            }
            return false;
        }

    }
}
