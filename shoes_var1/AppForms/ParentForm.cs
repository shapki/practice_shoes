using shoes.AppExceptions;
using System;
using System.Windows.Forms;

namespace shoes.AppForms
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            ContextManager.parentForm = this;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            AuthManager.Logout(this);
        }
    }
}
