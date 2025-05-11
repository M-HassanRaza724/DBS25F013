using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SoftwareFirmManagement.UI
{
    public partial class EmployeeAssignationForm: Form
    {

        OrderDetailsForm parentForm;
        public OrderDetailsForm ParentF { get { return parentForm; } set { parentForm = value; } }
        private EmployeeAssignationDTO employeeAssignationDTO;
        public EmployeeAssignationDTO EmployeeAssignationDTO { get { return employeeAssignationDTO; } set { employeeAssignationDTO = value; } }

        private List<bool> PreviousAssignments = new List<bool>();
        public EmployeeAssignationForm(OrderDTO order)
        {
            InitializeComponent();
            employeeAssignationDTO = EmployeeAssignationDL.GetAssignations(order.OrderId);
            LoadEmployees();
        }
        List<EmployeeDisplay> employees = new List<EmployeeDisplay>();
        private void LoadEmployees()
        {
            employees.Clear();
            int i = 0;
            foreach (Employee e in EmployeeDL.GetAllEmployees())
            {

                EmployeeDisplay employeeDisplay = new EmployeeDisplay();

                employeeDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
                employeeDisplay.BackColor = System.Drawing.Color.Transparent;
                employeeDisplay.Employee = e;
                employeeDisplay.Location = new System.Drawing.Point(((pnl_main.Width / 2) - (410)), 100 + (i*200));
                employeeDisplay.Name = $"employeeDisplay{i+1}";
                employeeDisplay.Size = new System.Drawing.Size(820, 150);

                employeeDisplay.TabIndex = 13;
                employeeDisplay.AssignButton =  true;
                PreviousAssignments.Add( employeeAssignationDTO.Employees.Contains(e));
                employeeDisplay.Assigned = PreviousAssignments[i];
                employees.Add(employeeDisplay);
                this.pnl_main.Controls.Add(employees[i]);
                pnl_main.Height += 170;
                i++;
            }

            //lbl_footer.Location = new System.Drawing.Point(6, 300 + (i * 260));
            vScrollBar.Maximum = (6 * i);
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int change = e.NewValue - e.OldValue;
            if (change > 0)
            {
                pnl_main.Location = new Point(pnl_main.Location.X, pnl_main.Location.Y - e.NewValue);
            }
            else
            {
                pnl_main.Location = new Point(pnl_main.Location.X, pnl_main.Location.Y + e.NewValue);
            }
            if (e.NewValue == 0)
            {
                this.pnl_main.Location = new System.Drawing.Point(0, 0);

            }
            if (e.NewValue == 100)
            {
                this.pnl_main.Location = new System.Drawing.Point(0, -pnl_main.Height);

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (EmployeeDisplay empdis in employees)
            {
                if (empdis.Assigned != PreviousAssignments[i])
                {
                    if (empdis.Assigned)
                        EmployeeAssignationDL.AddAsssignation(employeeAssignationDTO.Order.OrderId, empdis.Employee.EmployeeId);
                    else
                        EmployeeAssignationDL.DeleteAssignation(employeeAssignationDTO.Order.OrderId, empdis.Employee.EmployeeId);
                }
                i ++;
            }
            ParentF.Return();
            this.Close();
        }
    }
}
