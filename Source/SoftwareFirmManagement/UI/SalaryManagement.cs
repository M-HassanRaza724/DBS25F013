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
using Mysqlx.Crud;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.UI
{
    public partial class SalaryManagement : KryptonForm
    {
        string sortby = null, direction = null;
        DataGridViewRow currentContextRow = null;
        public SalaryManagement()
        {
            InitializeComponent();
        }
        public void LoadData(string search = null)
        {
            if (search == "Search")
                search = null;

            salaryBindingSource.DataSource = Salary.GetSalarysByFilter(search, sortby, direction);
            dgv_salaries.DataSource = salaryBindingSource;
            dgv_salaries.Refresh();
        }
        private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direction = direction != "ASC" ? "ASC" : null;
            LoadData();
        }

        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direction = direction != "DESC" ? "DESC" : null;
            LoadData();
        }

        private void MonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortby = sortby != "date" ? "date" : null;
            LoadData();
        }

        private void AmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortby = sortby != "amount" ? "amount" : null;
            LoadData();
        }

        private void SalaryManagement_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadEmployees();
            disableGroupBox();
            btn_add_update_salary.Enabled = false;
        }
        private void LoadEmployees()
        {
            cmbEmployee.Items.Clear();
            var employees = EmployeeDL.GetAllEmployees();
            cmbEmployee.Tag = employees;

            foreach (Employee emp in employees)
            {
                cmbEmployee.Items.Add($"{emp.Name} (ID: {emp.EmployeeId})");
            }
        }
        private Employee GetSelectedEmployee()
        {
            if (cmbEmployee.SelectedIndex == -1) return null;
            var employees = (List<Employee>)cmbEmployee.Tag;
            return employees[cmbEmployee.SelectedIndex];
        }
        private void dgv_salaries_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                currentContextRow = dgv_salaries.Rows[e.RowIndex];
                dgv_salaries.ClearSelection();
                currentContextRow.Selected = true;
                contextMenuStrip_grd.Show(dgv_salaries, dgv_salaries.PointToClient(Cursor.Position));
            }
        }
        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_add_update_salary.Enabled = cmbEmployee.SelectedIndex != -1;
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            disableGroupBox();
        }
        private void btn_add_salary_Click(object sender, EventArgs e)
        {
            enableGroupBox();
        }

        private void btn_add_update_salary_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill all fields with valid values");
                return;
            }

            Employee selectedEmployee = GetSelectedEmployee();
            if (selectedEmployee == null) return;

            try
            {
                double amount = Convert.ToDouble(txt_amount.TextBoxText);
                double bonus = Convert.ToDouble(txtBonus.TextBoxText);

                if (btn_add_update_salary.Text == "Update")
                {
                    int salaryId = Convert.ToInt32(currentContextRow.Cells["salaryIdDataGridViewTextBoxColumn"].Value);
                    var salary = new Salary(salaryId, selectedEmployee, DateTime.Now, amount, bonus);
                    salary.Update();
                }
                else
                {
                    var salary = new Salary(selectedEmployee, DateTime.Now, amount, bonus);
                    salary.Add();
                }

                LoadData();
                disableGroupBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private bool ValidateInputs()
        {
            return cmbEmployee.SelectedIndex != -1 &&
                   double.TryParse(txt_amount.TextBoxText, out _) &&
                   double.TryParse(txtBonus.TextBoxText, out _);
        }

        private void enableGroupBox(int salaryId = -1)
        {
            gbx_add_update_salaries.Enabled = true;
            gbx_add_update_salaries.Visible = true;

            if (salaryId != -1 && currentContextRow != null)
            {
                txt_amount.TextBoxText = currentContextRow.Cells["amountDataGridViewTextBoxColumn"].Value.ToString();
                txtBonus.TextBoxText = currentContextRow.Cells["bonusDataGridViewTextBoxColumn"].Value.ToString();

                string employeeName = currentContextRow.Cells["FullNameColumn"].Value.ToString();
                var employees = (List<Employee>)cmbEmployee.Tag;
                cmbEmployee.SelectedIndex = employees.FindIndex(e => e.Name == employeeName);

                btn_add_update_salary.Text = "Update";
                gbx_add_update_salaries.Text = "Update Salary";
            }
            else
            {
                txt_amount.TextBoxText = "";
                txtBonus.TextBoxText = "";
                cmbEmployee.SelectedIndex = -1;
                btn_add_update_salary.Text = "Add";
                gbx_add_update_salaries.Text = "Add Salary";
            }
        }
        private void disableGroupBox()
        {
            gbx_add_update_salaries.Enabled = false;
            gbx_add_update_salaries.Visible = false;
            cmbEmployee.SelectedIndex = -1;
            txt_amount.TextBoxText = "";
            txtBonus.TextBoxText = "";
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentContextRow != null)
            {
                enableGroupBox(Convert.ToInt32(currentContextRow.Cells["salaryIdDataGridViewTextBoxColumn"].Value));
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentContextRow == null) return;

            int salaryId = Convert.ToInt32(currentContextRow.Cells["salaryIdDataGridViewTextBoxColumn"].Value);
            DateTime salaryDate = Convert.ToDateTime(currentContextRow.Cells["dateDataGridViewTextBoxColumn"].Value);

            // Check if salary is older than 1 day
            if ((DateTime.Now - salaryDate).TotalDays > 1)
            {
                MessageBox.Show("Cannot delete salary older than 1 day");
                return;
            }

            if (DialogResult.Yes == MessageBox.Show(
                "Are you sure you want to delete this salary record?",
                "Warning",
                MessageBoxButtons.YesNo))
            {
                try
                {
                    SalaryDL.DeleteSalaryFromDatabase(new Salary { SalaryId = salaryId });
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting salary: {ex.Message}");
                }
            }
        }
    }
}
