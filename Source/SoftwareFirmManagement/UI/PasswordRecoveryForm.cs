using System;
using System.Linq;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SoftwareFirmManagement.BL;
using SoftwareFirmManagement.DL;

namespace SoftwareFirmManagement.UI
{
    public partial class PasswordRecoveryForm : KryptonForm
    {
        private bool _credentialsVerified = false;
        private User _userToRecover;

        public PasswordRecoveryForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize UI
            txtusername.TextBoxText = "";
            txt_email.TextBoxText = "";
            txtnewPassword.TextBoxText = "";
            txtConfirmPassword.TextBoxText = "";

            txtusername.PlaceHolder = "Username";
            txt_email.PlaceHolder = "Email";
            txtnewPassword.PlaceHolder = "New Password";
            txtConfirmPassword.PlaceHolder = "Confirm Password";

            // Initially hide password fields
            SetPasswordFieldsVisibility(false);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!_credentialsVerified)
            {
                VerifyCredentials();
            }
            else
            {
                UpdatePassword();
            }
        }

        private void VerifyCredentials()
        {
            string username = txtusername.Text.Trim();
            string email = txt_email.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email is required", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
                return;
            }

            try
            {
                _userToRecover = UserDL.allUsers.FirstOrDefault(u =>
                    u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                    u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

                if (_userToRecover != null)
                {
                    _credentialsVerified = true;
                    SetPasswordFieldsVisibility(true);
                    MessageBox.Show("Credentials verified. Please set new password.",
                        "Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No account found with these credentials",
                        "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Verification failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePassword()
        {
            string newPassword = txtnewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("New password is required", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnewPassword.Focus();
                return;
            }

            if (newPassword.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnewPassword.Focus();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                _userToRecover.Password = newPassword;
                if (UserDL.UpdateUserToDatabse(_userToRecover))
                {
                    MessageBox.Show("Password updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Password update failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetPasswordFieldsVisibility(bool visible)
        {
            txtnewPassword.Visible = visible;
            txtConfirmPassword.Visible = visible;
            btn_update.Values.Text = visible ? "Update Password" : "Verify Credentials";

            // Adjust form height
            this.Height = visible ? 500 : 350;
        }
    }
}