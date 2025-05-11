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
    public partial class AdminAddDialog : Form
    {
        public AdminAddDialog()
        {
            InitializeComponent();
        }


        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsername.Text == "" || tbEmail.Text == "" || tbPassword.Text == "" || tbName.Text == "" || mtbPhone.Text == null)
                {
                    MessageBox.Show("Please enter input in all fileds.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string username = tbUsername.Text;
                string email = tbEmail.Text;
                string password = tbPassword.Text;
                string name = tbName.Text;
                string phone = mtbPhone.Text;
                Admin newAdmin = new Admin(username, email, password, 1, name, phone, 22); // 1 means admin, 22 means secondary admin
                if (!User.CheckIfUserIsUnique(newAdmin))
                {
                    MessageBox.Show("Username, email or password already in use. Pleasse enter a unique username, email and password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newAdmin.Add(newAdmin);
                MessageBox.Show("Admin added successfully.", "Insertion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
