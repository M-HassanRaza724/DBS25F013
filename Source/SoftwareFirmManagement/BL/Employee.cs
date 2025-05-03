using SoftwareFirmManagement.DL;
using SoftwareFirmManagement.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement.BL
{
    public class Employee : User
    {
        private int employeeId;
        private string name;
        private string phone;
        private DateTime joinedDate;
        private int designationId;

        //public Employee(int userId, string username, string email, string password, int role, int employeeId, string name, string phone, DateTime joinedDate, int designationId) : base(userId, username, email, password, role)
        //{
        //    this.employeeId = employeeId;
        //    this.name = name;
        //    this.phone = phone;
        //    this.joinedDate = joinedDate;
        //    this.designationId = designationId;
        //}
        public Employee(string username, string email, string password, int role,string name, string phone, DateTime joinedDate, int designationId) : base(username, email, password, role)
        {
            this.employeeId = 0;
            this.name = name;
            this.phone = phone;
            this.joinedDate = joinedDate;
            this.designationId = designationId;
        }
        public Employee(int userId, string username, string email, string password, int role,int employeeId, string name, string phone, DateTime joinedDate, int designationId): base(userId, username, email, password, role)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.phone = phone;
            this.joinedDate = joinedDate;
            this.designationId = designationId;
        }
        public Employee()
        { } 

        public Employee(int userId, string username, string email, string password, int role, string name, string phone, DateTime joinedDate, int designationId) : base(userId, username, email, password, role)
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
                    List<Employee> onlyUsers = new List<Employee>();
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

    }
}
