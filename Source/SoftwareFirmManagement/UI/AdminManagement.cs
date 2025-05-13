using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.UI
{
    public partial class AdminManagement : KryptonForm
    {
        string sortby = null, direction = null;
        DataGridViewRow currentContextRow = null;
        List<Lookup> adminRolesList;
        public AdminManagement()
        {
            InitializeComponent();

            userCredentials1.UsernamePlaceHolder = "Username";
            userCredentials1.EmailPlaceHolder = "Email";
            userCredentials1.PasswordPlaceHolder = "Password";
        }
        public void LoadData(string search = null)
        {
            if (search == "Search")
                search = null;

            var allUsers = AdminDL.GetOnlyUsersFromDatabase();
            var adminUsers = allUsers.Where(u => u.Role == "Admin").ToList();

            if (!string.IsNullOrEmpty(search))
            {
                adminUsers = adminUsers.Where(u => (u.Username != null && u.Username.ToLower().Contains(search.ToLower())) ||
                                                  (u.Name != null && u.Name.ToLower().Contains(search.ToLower()))).ToList();
            }

            if (!string.IsNullOrEmpty(sortby))
            {
                if (sortby == "name")
                {
                    adminUsers = direction == "ASC" ? adminUsers.OrderBy(u => u.Name).ToList() : adminUsers.OrderByDescending(u => u.Name).ToList();
                }
                else if (sortby == "username")
                {
                    adminUsers = direction == "ASC" ? adminUsers.OrderBy(u => u.Username).ToList() : adminUsers.OrderByDescending(u => u.Username).ToList();
                }
            }

            AdminBindingSource.DataSource = adminUsers;
            dgv_admins.DataSource = AdminBindingSource;
        }
        private void AdminManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            dgv_admins.CellMouseDown += dgv_admins_CellMouseDown;
        }
        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            enableGroupBox();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            disableGroupBox();
        }

        private void btn_add_update_admin_Click(object sender, EventArgs e)
        {
            if (cmbAdminRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an admin role!");
                return;
            }

            // Debug UserCredentials values
            string username = userCredentials1.Username ?? "NULL";
            string email = userCredentials1.Email ?? "NULL";
            string password = userCredentials1.Password ?? "NULL";
            MessageBox.Show($"Username: {username}, Email: {email}, Password: {password}");

            // Check for empty fields
            if (string.IsNullOrEmpty(username) || username == "NULL" ||
                string.IsNullOrEmpty(email) || email == "NULL" ||
                string.IsNullOrEmpty(password) || password == "NULL")
            {
                MessageBox.Show("One or more UserCredentials fields are empty or not bound!");
                return;
            }

            int adminRoleId = GetSelectedAdminRoleId();

            if (btn_add_update_admin.Text == "Update")
            {
                try
                {
                    //(int userId, string username, string email, string password, int role, int adminId, string name, string phone, int adminRoleId, string adminRole) : base(userId, username, email, password, role)
                    Admin admin = new Admin(
                        Convert.ToInt32(currentContextRow.Cells["UserIdColumn"].Value),
                        userCredentials1.Username,
                        userCredentials1.Email,
                        userCredentials1.Password,
                        LookupDL.GetLookupId("user_role", "Admin"),
                        Convert.ToInt32(currentContextRow.Cells["AdminIdColumn"].Value),
                        txt_full_name.TextBoxText,
                        txt_Phone.TextBoxText,
                        adminRoleId

                    );
                    admin.Update(admin);
                    LoadData();
                    disableGroupBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Update failed: {ex.Message}");
                }
            }
            else
            {
                try
                {
                    //(int userId, string username, string email, string password, int role, string name, string phone, int adminRoleId) : base(userId, username, email, password, role)
                    Admin admin = new Admin(
                        Convert.ToInt32(currentContextRow.Cells["UserIdColumn"].Value),
                        userCredentials1.Username,
                        userCredentials1.Email,
                        userCredentials1.Password,
                        LookupDL.GetLookupId("user_role", "Admin"),
                        txt_full_name.TextBoxText,
                        txt_Phone.TextBoxText,
                        adminRoleId
                    );
                    admin.Add(admin);
                    LoadData();
                    disableGroupBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Add failed: {ex.Message}");
                }
            }
        }

        private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (direction != "ASC") direction = "ASC";
            else direction = null;
            LoadData();
        }


        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (direction != "DESC") direction = "DESC";
            else direction = null;
            LoadData();
        }
        private void dgv_admins_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                currentContextRow = dgv_admins.Rows[e.RowIndex];
                dgv_admins.ClearSelection();
                currentContextRow.Selected = true;
                contextMenuStrip_grd.Show(dgv_admins, dgv_admins.PointToClient(Cursor.Position));
            }
        }
        
       private void loadAdminRoles()
        {
            try
            {
                cmbAdminRoles.Items.Clear();
                adminRolesList = LookupDL.GetLookupsByKeyGroup("admin_role");
                cmbAdminRoles.Items.AddRange(adminRolesList.ToArray());

                if (cmbAdminRoles.Items.Count > 0)
                    cmbAdminRoles.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int GetSelectedAdminRoleId()
        {
            if (cmbAdminRoles.SelectedIndex >= 0 && cmbAdminRoles.SelectedIndex < adminRolesList.Count)
            {
                return adminRolesList[cmbAdminRoles.SelectedIndex].LookupId;
            }
            return 0;
        }
        void enableGroupBox(int adminId = -1)
        {
            gbx_add_update_employee.Enabled = true;
            gbx_add_update_employee.Visible = true;
            loadAdminRoles();

            if (adminId != -1)
            {
                txt_full_name.TextBoxText = currentContextRow.Cells["FullNameColumn"].Value.ToString();
                txt_Phone.TextBoxText = currentContextRow.Cells["PhoneColumn"].Value.ToString();

                userCredentials1.Username = currentContextRow.Cells["UsernameColumn"].Value.ToString();
                userCredentials1.Email = currentContextRow.Cells["EmailColumn"].Value.ToString();
                userCredentials1.Password = currentContextRow.Cells["PasswordColumn"].Value.ToString();

                int roleId = Convert.ToInt32(currentContextRow.Cells["RoleIdColumn"].Value);
                for (int i = 0; i < adminRolesList.Count; i++)
                {
                    if (adminRolesList[i].LookupId == roleId)
                    {
                        cmbAdminRoles.SelectedIndex = i;
                        break;
                    }
                }

                btn_add_update_admin.Text = "Update";
                gbx_add_update_employee.Text = "Update Admin";
            }
            else
            {
                //txt_full_name.TextBoxText = "";
                //txt_Phone.TextBoxText = "";
                //userCredentials1.Username = "";
                //userCredentials1.Email = "";
                //userCredentials1.Password = "";
                cmbAdminRoles.SelectedIndex = -1;

                btn_add_update_admin.Text = "Add";
                gbx_add_update_employee.Text = "Add Admin";
            }
        }
        void disableGroupBox()
        {
            gbx_add_update_employee.Enabled = false;
            gbx_add_update_employee.Visible = false;

            txt_full_name.TextBoxText = "";
            txt_full_name.PlaceHolder = "Full Name";
            txt_Phone.TextBoxText = "";
            txt_Phone.PlaceHolder = "Phone Number";
            userCredentials1.Username = "";
            userCredentials1.UsernamePlaceHolder = "Username";
            userCredentials1.Email = "";
            userCredentials1.EmailPlaceHolder = "Email";
            userCredentials1.Password = "";
            userCredentials1.PasswordPlaceHolder = "Password";
            cmbAdminRoles.SelectedIndex = -1;
            cmbAdminRoles.Text = "Select Admin Role";

            btn_add_update_admin.Text = "Add";
            gbx_add_update_employee.Text = "Add Admin";
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableGroupBox(Convert.ToInt32(currentContextRow.Cells["UserIdColumn"].Value));
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(currentContextRow.Cells["UserIdColumn"].Value);
            Admin admin = new Admin(
                userId,
                currentContextRow.Cells["UsernameColumn"].Value.ToString(),
                currentContextRow.Cells["EmailColumn"].Value.ToString(),
                currentContextRow.Cells["PasswordColumn"].Value.ToString(),
                Convert.ToInt32(currentContextRow.Cells["RoleIdColumn"].Value),
                Convert.ToInt32(currentContextRow.Cells["AdminIdColumn"].Value),
                currentContextRow.Cells["FullNameColumn"].Value.ToString(),
                currentContextRow.Cells["PhoneColumn"].Value.ToString(),
                Convert.ToInt32(currentContextRow.Cells["RoleIdColumn"].Value)
            );

            if (DialogResult.Yes == MessageBox.Show($"Are you sure you want to delete {currentContextRow.Cells["FullNameColumn"].Value.ToString()}?", "Warning", MessageBoxButtons.YesNo))
            {
                admin.Delete(admin);
                LoadData();
            }
        }
    }
}
