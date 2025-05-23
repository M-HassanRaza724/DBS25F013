﻿using SoftwareFirmManagement.DL;
using SoftwareFirmManagement.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SoftwareFirmManagement.BL
{
    public class Employee : User
    {
        private int employeeId;
        private string name;
        private string phone;
        private DateTime joinedDate;
        private int designationId;
        private Salary salary;
        private string designation;

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
            salary = new Salary();
        }

        public static Employee defaultEmployee = new Employee()
        {
            employeeId = -1,
            name = "null",
            phone = "null",
            joinedDate = DateTime.MinValue,
            designationId = -1,
            designation = "null",
        };

        public override string ToString()
        {
            return Name;
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
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }


        public Salary GetSalary()
        {
            return salary;
        }


        public bool SetSalary(int salaryId, DateTime date, double amount, double bonus) // overload when salaryId is passed, like when reading from db
        {
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
                    int userId = UserDL.GetUserId(user);
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
