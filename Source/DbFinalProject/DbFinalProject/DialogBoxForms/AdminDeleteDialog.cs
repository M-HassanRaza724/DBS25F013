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
    public partial class AdminDeleteDialog : Form
    {
        public AdminDeleteDialog()
        {
            InitializeComponent();
            foreach (var username in Admin.GetSecondaryAdminsUsernames())
            {
                cbUsername.Items.Add(username);
            }
        }


        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbUsername.SelectedItem == null)
                {
                    MessageBox.Show("Please select an admin's username to delete.", "Incomplte Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Admin admin = Admin.GetAdminFromUsername(cbUsername.SelectedItem.ToString());
                admin.Delete(admin);
                MessageBox.Show($"Admin deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException exception)
            {
                MessageBox.Show($"Database error: {exception.Message}.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
