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

    }
}
