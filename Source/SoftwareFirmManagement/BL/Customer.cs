using SoftwareFirmManagement.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareFirmManagement.BL
{
    public class Customer : User
    {
        private int customerId;
        private string name;

        public Customer(int userId, string username, string email, string password, int roleId, int customerId, string name) : base(userId, username, email, password, roleId)
        {
            this.customerId = customerId;
            this.name = name;
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        public override bool Add(User user)
        {
            try
            {
                if (user is Customer customer)
                {
                    bool userAdded = UserDL.AddUserToDatabase(user);
                    if (!userAdded)
                    {
                        return false;
                    }
                    return CustomerDL.AddCustomerToDatabase(customer);
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
                if (user is Customer customer)
                {
                    bool userUpdated = UserDL.UpdateUserToDatabse(user);
                    if (!userUpdated)
                    {
                        return false;
                    }
                    return CustomerDL.UpdateCustomerToDatabase(customer);
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
                if (user is Customer customer)
                {
                    bool customerDeleted = CustomerDL.DeleteCustomerFromDatabase(customer);
                    if (!customerDeleted)
                    {
                        return false;
                    }
                    return CustomerDL.DeleteCustomerFromDatabase(customer);
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
