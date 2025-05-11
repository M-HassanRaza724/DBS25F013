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
using SoftwareFirmManagement.DL;
using SoftwareFirmManagement.BL;

namespace SoftwareFirmManagement.UI
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            AuthenticateUser();
        }
        private void AuthenticateUser()
        {
            try
            {
                string email = txt_email.TextBoxText.Trim();
                string password = txt_Password.TextBoxText;

                if (!ValidateInputs(email, password))
                    return;

                User authenticatedUser = UserDL.allUsers.FirstOrDefault(u =>
                    u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                    u.Password == password);

                if (authenticatedUser != null)
                {
                    Program.SetCurrentUser(authenticatedUser);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid email or password", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Password.TextBoxText = "";
                    txt_Password.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lbl_forgotpassword_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //using (var recoveryForm = new PasswordRecoveryForm())
            //{
            //    recoveryForm.ShowDialog();
            //}
            //this.Show();
        }

        private void lbl_signup_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //using (var signupForm = new SignupForm())
            //{
            //    if (signupForm.ShowDialog() == DialogResult.OK)
            //    {
            //        txt_email.TextBoxText = signupForm.RegisteredEmail;
            //    }
            //}
            //this.Show();
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

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address (e.g., user@example.com)",
                    "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Password.Focus();
                return false;
            }

            return true;
        }
        private void Txt_email_Leave(object sender, EventArgs e)
        {
            string email = txt_email.TextBoxText.Trim();

            if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
            {
                MessageBox.Show("Please check your email format (e.g., user@example.com)",
                    "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var atIndex = email.IndexOf('@');
                var dotIndex = email.LastIndexOf('.');

                return atIndex > 0 &&                       
                       dotIndex > atIndex + 1 &&           
                       dotIndex < email.Length - 1 &&      
                       !email.Contains(" ");              
            }
            catch
            {
                return false;
            }
        }
    }
}
