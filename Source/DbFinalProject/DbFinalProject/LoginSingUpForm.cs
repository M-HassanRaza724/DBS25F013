using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFinalProject.ChildForms;

namespace DbFinalProject
{
    public partial class LoginSingUpForm : Form
    {
        public LoginSingUpForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoadChildForm(new LoginForm(this));
        }


        private void LoadChildForm(Form childForm)
        {
            pLoginSignUp.Controls.Clear();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pLoginSignUp.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            LoadChildForm(new SignUpForm(this));
        }
    }
}
