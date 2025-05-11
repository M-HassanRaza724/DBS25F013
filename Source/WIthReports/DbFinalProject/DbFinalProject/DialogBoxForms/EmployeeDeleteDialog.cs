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

namespace DbFinalProject.DialogBoxForms
{
    public partial class EmployeeDeleteDialog : Form
    {
        public EmployeeDeleteDialog()
        {
            InitializeComponent();
            foreach (var username in Employee.GetEmployeeUsernames())
            {
                cbUsername.Items.Add(username);
            }
        }


        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbUsername.SelectedItem == null)
                {
                    MessageBox.Show("Please select an employee's username.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string username = cbUsername.SelectedItem.ToString();
                Employee.DeleteEmployeeFromUsername(username);
                MessageBox.Show("Employee deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
