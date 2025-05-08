using DbFinalProject.BL;
using DbFinalProject.DialogBoxForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFinalProject.ChildForms
{
    public partial class ProfileForm : Form
    {
        MainForm parent;

        public ProfileForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            Label lblProfileDisplay = new Label();
            lblProfileDisplay.AutoSize = true;
            lblProfileDisplay.Text = $"Username: {Program.currentUser.Username}\nEmail: {Program.currentUser.Email}\nPassword: {Program.currentUser.Password}";
            if (Program.currentUser is Customer customer)
            {
                lblProfileDisplay.Text += $"\nName: {customer.Name}";
            }
            else if (Program.currentUser is Employee employee)
            {
                lblProfileDisplay.Text += $"\nName: {employee.Name}\nPhone: {employee.Phone}"; 
            }
            else if (Program.currentUser is Admin admin)
            {
                lblProfileDisplay.Text += $"\nName: {admin.Name}\nPhone: {admin.Phone}";
            }
            lblProfileDisplay.Location = new Point(50, 30);
            pProfileDisplay.Controls.Add(lblProfileDisplay);
        }


        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            ProfileEditDialog frm = new ProfileEditDialog();
            frm.Show();
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your profile?", "Profile Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Program.currentUser is Customer customer)
                {
                    customer.Delete(customer);
                }
                else if (Program.currentUser is Employee employee)
                {
                    employee.Delete(employee);
                }
                else if (Program.currentUser is Admin admin)
                {
                    admin.Delete(admin);
                }
                this.Close();
                parent.Close();
                LoginSingUpForm loginSingUpForm = new LoginSingUpForm();
                loginSingUpForm.Show();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }


        private void btnEditProfile_Click_1(object sender, EventArgs e)
        {
            ProfileEditDialog dialog = new ProfileEditDialog();
            dialog.Show();
        }

    }
}
