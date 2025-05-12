using System;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.UI
{
    public partial class SignupForm : KryptonForm
    {
        public string UserEmail { get; private set; }

        public SignupForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            txtname.Text = "";
            txtusername.Text = "";
            txt_email.Text = "";
            txtPassword.Text = "";

            txtname.Text = "Full Name";
            txtusername.Text = "Username";
            txt_email.Text = "Email";
            txtPassword.Text = "Password";
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    var newCustomer = new Customer(
                        username: txtusername.Text.Trim(),
                        email: txt_email.Text.Trim(),
                        password: txtPassword.Text,
                        roleId: LookupDL.GetLookupId("user_role", "Customer"),
                        name: txtname.Text.Trim()
                    );

                    if (newCustomer.Add(newCustomer))
                    {
                        UserEmail = txt_email.Text.Trim();
                        MessageBox.Show("Registration successful!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Registration failed: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs()
        {
            string username = txtusername.Text.Trim();
            string email = txt_email.Text.Trim();
            string name = txtname.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                ShowError("Full name is required", txtname);
                return false;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                ShowError("Username is required", txtusername);
                return false;
            }

            if (UserDL.allUsers.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                ShowError("Username already exists", txtusername);
                return false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                ShowError("Email is required", txt_email);
                return false;
            }

            if (!IsValidEmail(email))
            {
                ShowError("Invalid email format", txt_email);
                return false;
            }

            if (UserDL.allUsers.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
            {
                ShowError("Email already registered", txt_email);
                return false;
            }

            // Validate password
            if (string.IsNullOrWhiteSpace(password))
            {
                ShowError("Password is required", txtPassword);
                return false;
            }

            if (password.Length < 8)
            {
                ShowError("Password must be at least 8 characters", txtPassword);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var atIndex = email.IndexOf('@');
                var dotIndex = email.LastIndexOf('.');
                return atIndex > 0 &&
                       dotIndex > atIndex + 1 &&
                       dotIndex < email.Length - 1;
            }
            catch
            {
                return false;
            }
        }

        private void ShowError(string message, Control control)
        {
            MessageBox.Show(message, "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}