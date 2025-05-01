using System.Windows.Forms;

namespace SoftwareFirmManagement.UI
{
    public partial class UserCredentials : UserControl
    {
        public UserCredentials()
        {
            InitializeComponent();

        }

        public string UsernamePlaceHolder
        {
            get { return txt_username.PlaceHolder; }
            set { txt_username.PlaceHolder = value; }
        }
        public string EmailPlaceHolder
        {
            get { return txt_email.PlaceHolder; }
            set { txt_email.PlaceHolder = value; }
        }
        public string PasswordPlaceHolder
        {
            get { return txt_password.PlaceHolder; }
            set { txt_password.PlaceHolder = value; }
        }

        public string Username
        {
            get { return txt_username.TextBoxText; }
            set { txt_username.TextBoxText = value; }
        }
        public string Email
        {
            get { return txt_email.TextBoxText; }
            set { txt_email.TextBoxText = value; }
        }
        public string Password
        {
            get { return txt_password.TextBoxText; }
            set { txt_password.TextBoxText = value; }
        }

        private void lbl_password_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
