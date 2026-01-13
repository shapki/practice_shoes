using shoes.AppExceptions;
using System.Windows.Forms;
using System;

namespace shoes.AppForms
{
    public partial class LoginForm : ParentForm
    {
        public LoginForm()
        {
            InitializeComponent();
            ContextManager.parentForm = this;
            ContextManager.parentForm.SetTitle("Вход");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                AuthManager.Login(loginTextBox.Text, passwordTextBox.Text);
            }
            catch (UnauthorizedException ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            AuthManager.Login("g", "g");
        }
    }
}
