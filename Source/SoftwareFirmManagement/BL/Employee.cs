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

        public Employee(int userId, string username, string email, string password, int role, int employeeId, string name, string phone, DateTime joinedDate, int designationId) : base(userId, username, email, password, role)
        {
            this.employeeId = employeeId;
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
            if (user is Employee emp)
            {
                bool userAdded = base.Add(user);
                if (!userAdded)
                {
                    return false;
                }
                return EmployeeDL.AddEmployeeToDatabase(emp);
            }
            return false;
        }


        public override bool Update(User user)
        {
            if (user is Employee emp)
            {
                bool userUpdated = base.Update(user);
                if (userUpdated == false)
                {
                    return false;
                }
                return EmployeeDL.UpdateEmployeeToDatabase(emp);
            }
            return false;
        }


        public override bool Delete(User user)
        {
            if (user is Employee emp)
            {
                bool empDeleted = EmployeeDL.DeleteEmployeeFromDatabase(emp); // first, delete employee
                if (!empDeleted)
                {
                    return false;
                }
                return base.Delete(user); // then delete user
            }
            return false;
        }

    }
}
