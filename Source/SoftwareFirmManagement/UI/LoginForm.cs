using System;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.UI
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize UI
            txt_email.PlaceHolder = "Email";
            txtPassword.PlaceHolder = "Password";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            AuthenticateUser();
        }

        private void AuthenticateUser()
        {
            string email = txt_email.TextBoxText.Trim();
            string password = txtPassword.TextBoxText;

            if (!ValidateInputs(email, password))
                return;

            try
            {
                User authenticatedUser = UserDL.allUsers.FirstOrDefault(u =>
                    u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                    u.Password == password);

                if (authenticatedUser != null)
                {
                    if(authenticatedUser is Admin ad)
                        Program.CurrentUser = ad;
                    else if (authenticatedUser is Employee emp)
                        Program.CurrentUser = emp;
                    else if (authenticatedUser is Customer cust)
                        Program.CurrentUser = cust;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid credentials", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.TextBoxText = "";
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email is required", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
                return false;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address",
                    "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var signupForm = new SignupForm())
            {
                if (signupForm.ShowDialog() == DialogResult.OK)
                {
                    UserDL.LoadAllUsers();
                    txt_email.TextBoxText = signupForm.UserEmail;
                    txtPassword.TextBoxText = "";
                    txtPassword.Focus();
                }
            }
            this.Show();
        }

        private void lbl_forgetpassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var recoveryForm = new PasswordRecoveryForm())
            {
                recoveryForm.ShowDialog();
            }
            this.Show();
        }
    }
}