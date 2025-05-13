using ComponentFactory.Krypton.Toolkit;
using SoftwareFirmManagement.BL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoftwareFirmManagement.UI
{


    public partial class MainForm : KryptonForm
    {
        ServiceManagement serviceManagement = new ServiceManagement();
        ClientReviews clientReviews = new ClientReviews();
        SalaryManagement salaryManagement;
        CustomerDashboard customerDashboard = new CustomerDashboard();
        EmployeeDashboard employeeDashboard;
        AdminDashboard adminDashboard;
        OrderManagement orderManagement;
        CustomerManagement customerManagement;
        EmployeeManagement employeeManagement;
        OrderPlacementForm orderPlacementForm;
        AdminManagement adminManagement;
              //if(Program.CurrentUser is Admin ad)
                //{
                //}
        public void LoadForms()
        {
            if (Program.CurrentUser is Admin ad)
            {
                orderManagement = new OrderManagement();
                adminDashboard = new AdminDashboard();
                adminDashboard.ParentForm = this;
                employeeManagement = new EmployeeManagement();
                customerManagement = new CustomerManagement();
                salaryManagement = new SalaryManagement();
                serviceManagement = new ServiceManagement();
                adminManagement = new AdminManagement();
                if (ad.AdminRole == "superAdmin")
                {
                    adminManagement = new AdminManagement();
                }
                //btn_user_management.Enabled = true;
                //btn_user_management.Visible = true;
                btn_salary_management.Enabled = true;
                btn_salary_management.Visible = true;
            }
            else if (Program.CurrentUser is Employee emp)
            {
                employeeDashboard = new EmployeeDashboard();
                salaryManagement = new SalaryManagement();
                orderManagement = new OrderManagement();
                btn_salary_management.Enabled = true;
                btn_salary_management.Visible = true;
            }
            else if (Program.CurrentUser is Customer cust)
            {
                customerDashboard = new CustomerDashboard();
                orderManagement = new OrderManagement();

            }
        }
        public MainForm()
        {
            InitializeComponent();
            LoadForms();
            OpenDashboard();
            //this.ContextMenuStrip = contextMenuStrip1;
        }



        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_size_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(800, 600);
                this.btn_size.StateCommon.Back.Image = global::SoftwareFirmManagement.Properties.Resources.Full_Screen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.btn_size.StateCommon.Back.Image = global::SoftwareFirmManagement.Properties.Resources.Normal_Screen;

            }


        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }



        public void DeleteExistingChild()
        {
            // Clear existing content
            if (pnl_main.Controls.Count > 0)
            {
                var oldForm = pnl_main.Controls[0] as Form;
                oldForm?.Close(); // Properly dispose old form
                pnl_main.Controls.Clear();
            }
        }
        public void HideForm()
        {
            // hide existing content
            if (pnl_main.Controls.Count > 0)
            {
                var oldForm = pnl_main.Controls[0] as Form;
                oldForm?.Hide(); // Properly dispose old form
                pnl_main.Controls.Clear();
            }
        }
        public void ShowFormInPanel(Form formToShow)
        {


            // Prepare new form
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;

            // Add to panel
            pnl_main.Controls.Add(formToShow);
            pnl_main.Tag = formToShow;

            // Show form
            formToShow.Show();

            // Optional: Handle form closing
            formToShow.FormClosed += (s, e) =>
            {
                if (pnl_main.Tag == formToShow)
                {
                    pnl_main.Controls.Clear();
                    pnl_main.Tag = null;
                }
            };
        }


        private void btn_user_management_Click(object sender, EventArgs e)
        {
            if (pnl_user_management.Height == 50)
            {
                pnl_user_management.Height = 200;
            }
            else
            {
                pnl_user_management.Height = 50;
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (sidePanel1.Width == 60)
            {
                sidePanel1.Width = 230;
                pnl_dashboard.Width = 230;
                pnl_menu.Width = 230;
                pnl_user_management.Width = 230;
                pnl_services.Width = 230;
                pnl_order_management.Width = 230;
                pnl_reviews.Width = 230;

            }
            else
            {
                sidePanel1.Width = 60;
                sidePanel1.Width = 60;
                pnl_dashboard.Width = 60;
                pnl_menu.Width = 60;
                pnl_user_management.Width = 60;
                pnl_services.Width = 60;
                pnl_order_management.Width = 60;
                pnl_reviews.Width = 60;

            }
        }

        private void btn_customer_management_Click(object sender, EventArgs e)
        {
            HideForm();
            ShowFormInPanel(customerManagement);
        }

        private void btn_employee_management_Click(object sender, EventArgs e)
        {
            HideForm();
            ShowFormInPanel(employeeManagement);
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            HideForm();
            ShowFormInPanel(serviceManagement);
        }

        private void btn_order_management_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser == Customer.defaultCustomer)
            {
                MessageBox.Show("Please Login First", "Remainder", MessageBoxButtons.OK);
                return;
            }
            HideForm();
            ShowFormInPanel(orderManagement);
            orderManagement.ParentForm = this;

        }

        private void btn_salary_management_Click(object sender, EventArgs e)
        {
            HideForm();
            ShowFormInPanel(salaryManagement);

        }

        private void btn_reviews_Click(object sender, EventArgs e)
        {
            HideForm();
            ShowFormInPanel(clientReviews);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser == Customer.defaultCustomer)
            {

                using (var loginForm = new LoginForm())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        HideForm();
                        //CloseForms();
                        DeleteExistingChild();
                        LoadForms();
                        OpenDashboard();
                        btn_logout.Enabled = true;
                        btn_logout.Visible = true;
                    }
                }
            }
            else
            {
                ShowCredentials();
            }
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            if(Program.CurrentUser != Customer.defaultCustomer)
                if (MessageBox.Show("Are you sure.You want to logout", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Program.CurrentUser = Customer.defaultCustomer;
                    HideForm();
                    CloseForms();
                    DeleteExistingChild();
                    LoadForms();
                    OpenDashboard();

                    btn_logout.Enabled = false;
                    btn_logout.Visible = false;
                }
            
        }
        private void ShowCredentials()
        {
            if (Program.CurrentUser is Admin ad)
            {
                //DisplayA
            }
            else if (Program.CurrentUser is Employee emp)
            {
                EmployeeDisplay employeeDisplay = new EmployeeDisplay();
                employeeDisplay.Show();

            }
            else if (Program.CurrentUser is Customer cust)
            {

                CustomerDisplay customerDisplay = new CustomerDisplay();
                customerDisplay.Show();

            }
        }

      
        private void CloseForms()
        {
            try
            {

                if (Program.CurrentUser is Admin ad)
                {
                    orderManagement.Close();
                    adminDashboard.Close();
                    employeeManagement.Close();
                    customerManagement.Close();
                    salaryManagement.Close();
                    serviceManagement.Close();
                    if (ad.AdminRole == "superAdmin")
                    {
                        adminManagement.Close();
                    }
                }
                else if (Program.CurrentUser is Employee emp)
                {
                    //employeeDashboard.Close();
                    salaryManagement.Close();
                    orderManagement.Close();
                }
                else if (Program.CurrentUser is Customer cust)
                {
                    customerDashboard.Close();
                    orderManagement.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            OpenDashboard();
        }
        private void OpenDashboard()
        {
            HideForm();
            if (Program.CurrentUser is Admin ad)
            {
                ShowFormInPanel(adminDashboard);
            }
            else if (Program.CurrentUser is Employee emp)
            {
                ShowFormInPanel(employeeDashboard);
            }
            else if (Program.CurrentUser is Customer cust)
            {
                ShowFormInPanel(customerDashboard);
            }

        }

        public void ShowEmployeeManagement()
        {
            HideForm();
            ShowFormInPanel(employeeManagement);
        }
        public void ShowAdminManagement()
        {
            HideForm();
            ShowFormInPanel(adminManagement);
        }
        public void ShowCustomerManagement()
        {
            HideForm();
            ShowFormInPanel(customerManagement);
        }
    }
}