using DbFinalProject.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFinalProject.DialogBoxForms
{
    public partial class ProfileEditDialog : Form
    {
        public ProfileEditDialog()
        {
            InitializeComponent();
            if (Program.currentUser is Customer)
            {
                lblPhone.Visible = false;
                tbPhone.Visible = false;
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User orgUser = Program.currentUser;
            try
            {
                string name = tbName.Text;
                string email = tbEmail.Text;
                string phone = tbPhone.Text;
                string password = tbPassword.Text;
                // phone is not an attribute of Customer
                if (Program.currentUser is Customer)
                {
                    if (name == "" || email == "" || password == "")
                    {
                        MessageBox.Show("Please fill all the input fields.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (name == "" || email == "" || phone == "" || password == "")
                {
                    MessageBox.Show("Please fill all the input fields.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.currentUser.Email = email;
                Program.currentUser.Password = password;
                // check if the new email and password is unique
                if (!User.CheckIfEmailPasswordIsUnique(orgUser, Program.currentUser.Email, Program.currentUser.Password))
                {
                    MessageBox.Show("Email or password is already in use. Please enter a unique email and password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Program.currentUser is Customer customer)
                {
                    customer.Name = name;
                    customer.Update(customer);
                }
                else if (Program.currentUser is Employee employee)
                {
                    employee.Name = name;
                    employee.Phone = phone;
                    employee.Update(employee);
                }
                else if (Program.currentUser is Admin admin)
                {
                    admin.Name = name;
                    admin.Phone = phone;
                    admin.Update(admin);
                }
                MessageBox.Show("Profile updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.currentUser = orgUser;
                return;
            }
        }
    }
}
