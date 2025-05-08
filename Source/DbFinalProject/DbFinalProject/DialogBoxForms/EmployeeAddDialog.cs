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
    public partial class EmployeeAddDialog : Form
    {
        public EmployeeAddDialog()
        {
            InitializeComponent();
            foreach (var designation in Employee.GetEmployeeDesignations())
            {
                cbDesignation.Items.Add(designation);
            }
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsername.Text == "" || tbPassword.Text == "" || tbEmail.Text == "" || tbName.Text == "" || tbPhone.Text == "" || cbDesignation.SelectedItem == null)
                {
                    MessageBox.Show("Please enter input in all fields.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                string email = tbEmail.Text;
                string name = tbName.Text;
                string phone = tbPhone.Text;
                string designation = cbDesignation.SelectedItem.ToString();
                int designationId = Employee.GetLookupIdFromDesignation(designation);
                Employee newEmployee = new Employee(username, email, password, 3, name, phone, DateTime.Now.Date, designationId);
                if (!User.CheckIfUserIsUnique(newEmployee))
                {
                    MessageBox.Show("Username, email or password is already taken. Please enter a unique username, email and password", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                newEmployee.Add(newEmployee);
                MessageBox.Show("Employee added successfully.", "Insertion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
