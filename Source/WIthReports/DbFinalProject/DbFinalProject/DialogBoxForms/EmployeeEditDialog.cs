using DbFinalProject.BL;
using DbFinalProject.DL;
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
    public partial class EmployeeEditDialog : Form
    {
        public EmployeeEditDialog()
        {
            InitializeComponent();
            dtmPayDate.MaxDate = DateTime.Today;
            foreach (var username in Employee.GetEmployeeUsernames())
            {
                cbUsernameToUpdate.Items.Add(username);
            }
        }


        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbUsernameToUpdate.SelectedItem == null)
                {
                    MessageBox.Show("Pleas select an employee's username to update.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string username = cbUsernameToUpdate.SelectedItem.ToString();
                Employee empToUpdate = Employee.GetEmployeeFromUsername(username);
                Employee ogEmp = empToUpdate;
                if (tbEmail.Text == "" || tbPassword.Text == "" || tbName.Text == "" || mtbPhone.Text == null)
                {
                    MessageBox.Show("Please enter input in all fields.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string newEmail = tbEmail.Text;
                string newPassword = tbPassword.Text;
                string newPhone = mtbPhone.Text;
                string newName = tbName.Text;
                double newSalary = (double)(nmudSalary.Value);
                double newBonus = (double)(nmudBonus.Value);
                DateTime newPayDate = dtmPayDate.Value.Date;
                empToUpdate.Email = newEmail;
                empToUpdate.Password = newPassword;
                empToUpdate.Phone = newPhone;
                empToUpdate.Name = newName;
                if (!User.CheckIfEmailPasswordIsUnique(ogEmp, newEmail, newPassword))
                {
                    MessageBox.Show("Email or password is already taken. Please enter a unique email and password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                empToUpdate.SetSalary(newPayDate, newSalary, newBonus);
                empToUpdate.Update(empToUpdate);
                MessageBox.Show("Employee updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
