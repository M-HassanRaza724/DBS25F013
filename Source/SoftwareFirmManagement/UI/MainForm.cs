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

namespace SoftwareFirmManagement.UI
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
            //this.ContextMenuStrip = contextMenuStrip1;
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //new Form1().Show();

        }

        private void orders1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

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

        private void kryptonCheckButton1_Click(object sender, EventArgs e)
        {

        }

        //private void kryptonCheckButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (cbtn_test.Checked)
        //    {
        //        cbtn_test.Values.ExtraText = "▼";
        //    }
        //    else
        //    {
        //        cbtn_test.Values.ExtraText = "▲";
        //    }

        //}

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
            if(sidePanel1.Width == 60)
            {
                sidePanel1.Width = 230;
                pnl_dashboard.Width = 230;
                pnl_menu.Width = 230;
                pnl_user_management.Width = 230;
                pnl_services.Width = 230;
                pnl_order_management.Width = 230;

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

            }
        }

        private void btn_customer_management_Click(object sender, EventArgs e)
        {
            DeleteExistingChild();
            ShowFormInPanel(new CustomerManagement());
        }

         private void btn_employee_management_Click(object sender, EventArgs e)
        {
            DeleteExistingChild();
            ShowFormInPanel(new EmployeeManagement());
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            DeleteExistingChild();
            ShowFormInPanel(new ServiceManagement());
        }

        private void btn_order_management_Click(object sender, EventArgs e)
        {
            OrderManagement orderManagement = new OrderManagement();
            ShowFormInPanel(orderManagement);
            orderManagement.ParentForm = this;

        }
    }
}