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
using System.Runtime.CompilerServices;
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.UI
{
    public partial class EmployeeManagement : KryptonForm
    {
        string sortby = null, direction = null;
        DataGridViewRow currentContextRow = null;
        public EmployeeManagement()
        {
            InitializeComponent();
        }
        public void LoadData(string search = null) // search argument is used only when a search button calls this function.
        {
            if (search == "Search")
                search = null;
            //EmployeeBindingSource.DataSource = EmployeeDL.GetAllEmployees(search, sortby, direction);
            //dgv_employees.DataSource = EmployeeBindingSource;
        }
        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            loadDesignations();
        }
        private void userNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortby != "username") sortby = "username";
            else sortby = null;
            LoadData();
            //MessageBox.Show($"Sort by {sortby}");
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
        private void dgv_employees_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                currentContextRow = dgv_employees.Rows[e.RowIndex];
                dgv_employees.ClearSelection();
                currentContextRow.Selected = true;
                contextMenuStrip_grd.Show(dgv_employees, dgv_employees.PointToClient(Cursor.Position));
            }
        }

        void enableGroupBox(int custId = -1)
        {
            gbx_add_update_employee.Enabled = true;
            gbx_add_update_employee.Visible = true;
            if (custId != -1)
            {
                txt_full_name.TextBoxText = currentContextRow.Cells["FullNameColumn"].Value.ToString();
                userCredentials1.Username = currentContextRow.Cells["UsernameColumn"].Value.ToString();
                userCredentials1.Email = currentContextRow.Cells["EmailColumn"].Value.ToString();
                userCredentials1.Password = currentContextRow.Cells["PasswordColumn"].Value.ToString();

                btn_add_update_employee.Text = "Update";
                gbx_add_update_employee.Text = "Update Customer";
            }
        }
        void disableGroupBox()
        {
            gbx_add_update_employee.Enabled = false;
            gbx_add_update_employee.Visible = false;
            txt_full_name.PlaceHolder = "FirstName";
            userCredentials1.UsernamePlaceHolder = "Username";
            userCredentials1.EmailPlaceHolder = "Email";
            userCredentials1.PasswordPlaceHolder = "Password";
            btn_add_update_employee.Text = "Add";
            gbx_add_update_employee.Text = "Add Customer";
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableGroupBox(Convert.ToInt32(currentContextRow.Cells["EmployeeIdColumn"].Value));
            //Customer.UpdateCustomer(Convert.ToInt32(currentContextRow.Cells["dataGridViewTextBoxColumn1"].Value));
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(currentContextRow.Cells["EmployeeIdColumn"].Value);
            Employee employee = new Employee();
            employee.EmployeeId = employeeId;

            if (DialogResult.Yes == MessageBox.Show($"Are you sure you want to delete {currentContextRow.Cells["FullNameColumn"].Value.ToString()}?", "Warning", MessageBoxButtons.YesNo))
                employee.Delete(employee);
        }
        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            enableGroupBox();
        }
        private void EmployeeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sortby != "name") sortby = "name";
            else sortby = null;
            MessageBox.Show($"Sort by {sortby}");
            LoadData();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            disableGroupBox();

        }
        private void loadDesignations()
        {
        }
        private void btn_add_update_employee_Click(object sender, EventArgs e)
        {
            if (btn_add_update_employee.Text == "Update")
            {
                try
                {
                    //    Employee employee = new Employee(Convert.ToInt32(currentContextRow.Cells["UserIdColumn"].Value), userCredentials1.Username, userCredentials1.Email, userCredentials1.Password, LookupDL.GetLookupId("user_role", "Employee"), Convert.ToInt32(currentContextRow.Cells["EmployeeIdColumn"].Value), txt_full_name.TextBoxText);
                    //    employee.Update(employee);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

                try
                {
                    //Employee employee = new Employee(userCredentials1.Username, userCredentials1.Email, userCredentials1.Password, LookupDL.GetLookupId("user_role", "Employee"), txt_full_name.TextBoxText);
                    //employee.Add(employee);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            LoadData();
            disableGroupBox();
        }
    }
}
