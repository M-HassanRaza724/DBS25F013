using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFinalProject.BL;

namespace DbFinalProject.ChildForms
{
    public partial class SignUpForm : Form
    {
        private LoginSingUpForm parent;

        public SignUpForm(LoginSingUpForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string email = tbEmail.Text;
            string name = tbName.Text;
            if (username == null || password == null || email == null || name == null)
            {
                MessageBox.Show("Please fill all the input fields.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User newUser = new Customer(username, email, password, 2, name);
            if (!User.CheckIfUserIsUnique(newUser))
            {
                MessageBox.Show("Username, password or email is already taken.", "Non-unique Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    Customer newCustomer = (Customer)newUser;
                    newCustomer.Add(newCustomer);
                    MessageBox.Show("Signed up successfully.", "Sign Up Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    parent.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
