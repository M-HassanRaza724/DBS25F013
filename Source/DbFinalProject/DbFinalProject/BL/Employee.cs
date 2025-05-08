using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbFinalProject.DL;
using System.Runtime.CompilerServices;

namespace DbFinalProject.BL
{
    public class Employee : User
    {
        private int employeeId;
        private string name;
        private string phone;
        private DateTime joinedDate;
        private int designationId;
        private Salary salary;

        public Employee(int userId, string username, string email, string password, int role, int employeeId, string name, string phone, DateTime joinedDate, int designationId) : base(userId, username, email, password, role)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.phone = phone;
            this.joinedDate = joinedDate;
            this.designationId = designationId;
            salary = new Salary(); // composition
        }


        public Employee(string username, string email, string password, int role, string name, string phone, DateTime joinedDate, int designationId) : base(username, email, password, role)
        {
            this.name = name;
            this.phone = phone;
            this.joinedDate = joinedDate;
            this.designationId = designationId;
        }


        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public DateTime JoinedDate
        {
            get { return joinedDate; }
            set { joinedDate = value; }
        }
        public int DesignationId
        {
            get { return designationId; }
            set { designationId = value; }
        }


        public Salary GetSalary()
        {
            return salary;
        }


        public bool SetSalary(int salaryId, DateTime date, double amount, double bonus) // overload when salaryId is passed, like when reading from db
        {
            // when reading from db, SalaryDL.AddSalaryToDatabase(salary) isn't required
            try
            {
                salary = new Salary(salaryId, employeeId, date, amount, bonus);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool SetSalary(DateTime date, double amount, double bonus) // overload when salaryId is not passed, like when setting salary from UI
        {
            try
            {
                salary = new Salary(employeeId, date, amount, bonus);
                bool status = SalaryDL.AddSalaryToDatabase(salary);
                UserDL.LoadAllUsers();
                return status;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool UpdateSalary(DateTime payDate, double amount, double bonus)
        {
            try
            {
                salary = new Salary(EmployeeId, payDate, amount, bonus);
                bool status = SalaryDL.UpdateSalaryToDatabase(salary);
                UserDL.LoadAllUsers();
                return status;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool DeleteSalary()
        {
            try
            {
                bool status = SalaryDL.DeleteSalaryFromDatabase(salary);
                salary = new Salary();
                UserDL.LoadAllUsers();
                return status;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public override bool Add(User user)
        {
            try
            {
                if (user is Employee emp)
                {
                    bool userAdded = UserDL.AddUserToDatabase(user);
                    if (!userAdded)
                    {
                        return false;
                    }
                    List<Employee> onlyUsers = EmployeeDL.GetOnlyUsersFromDatabase();
                    int userId = onlyUsers
                                 .Where(e => e.Username == user.Username)
                                 .Select(e => e.UserId)
                                 .FirstOrDefault();
                    emp.UserId = userId;
                    bool status = EmployeeDL.AddEmployeeToDatabase(emp);
                    UserDL.LoadAllUsers();
                    return status;
                }
                return false;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public override bool Update(User user)
        {
            try
            {
                if (user is Employee emp)
                {
                    bool userUpdated = UserDL.UpdateUserToDatabse(user);
                    if (userUpdated == false)
                    {
                        return false;
                    }
                    bool status = EmployeeDL.UpdateEmployeeToDatabase(emp);
                    UserDL.LoadAllUsers();
                    return status;
                }
                return false;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public override bool Delete(User user)
        {
            try
            {
                if (user is Employee emp)
                {
                    bool empDeleted = EmployeeDL.DeleteEmployeeFromDatabase(emp); // first, delete employee
                    if (!empDeleted)
                    {
                        return false;
                    }
                    bool status = UserDL.DeleteUserFromDatabase(user); // then delete user
                    UserDL.LoadAllUsers();
                    return status;
                }
                return false;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }


        public static int GetLookupIdFromDesignation(string designation)
        {
            return LookupDL.allLookups
                   .Where(l => l.Value == designation)
                   .Select(l => l.LookupId)
                   .FirstOrDefault();
        }


        public static List<string> GetEmployeeDesignations()
        {
            return LookupDL.allLookups
                   .Where(l => l.KeyGroup == "employee_designation")
                   .Select(l => l.Value)
                   .ToList();
        }


        public static List<string> GetEmployeeUsernames()
        {
            return UserDL.allUsers
                   .OfType<Employee>()
                   .Select(e => e.Username)
                   .ToList();
        }


        public static bool DeleteEmployeeFromUsername(string username)
        {
            try
            {
                Employee emp = UserDL.allUsers
                               .OfType<Employee>()
                               .Where(u => u.Username == username)
                               .FirstOrDefault();
                emp.Delete(emp);
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                throw;
            }
        }

    }
}
