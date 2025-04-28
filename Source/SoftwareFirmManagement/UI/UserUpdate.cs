using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;

namespace SoftwareFirmManagement.UI
{
    public partial class UserUpdate: UserControl
    {
        public UserUpdate(User user)
        {
            if (user is Admin) 
            {
                
            }
            if (user is Employee)
            {

            }
            //if() { }
            InitializeComponent();
        }
    }
}
