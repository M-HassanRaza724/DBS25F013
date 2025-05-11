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
    public partial class LoginForm : Form
    {
        private LoginSignUpForm parent;

        public LoginForm(LoginSignUpForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string role = cbRole.SelectedItem?.ToString();
            if (username == null || password == null || role == null)
            {
                MessageBox.Show("Please fill all the input fields.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = User.CheckIfUserExists(username, password);
            if (user == null)
            {
                MessageBox.Show("Incorrect username or password.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Program.currentUser = user;
                this.Hide();
                parent.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
    }
}
