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
            HideLogoutButton();
        }

        private void HideLogoutButton()
        {
            logoutButton.Visible = false;
        }

        public void ShowLogoutButton()
        {
            logoutButton.Visible = true;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            AuthManager.Logout(this);
        }

        public void SetFullNameAndRole()
        {
            this.fullNameLabel.Text = ContextManager.user.FullName;
            this.roleLabel.Text = ContextManager.user.Role;
        }

        public void SetTitle(string title)
        {
            string tmpTitle = "ООО \"Обувь\": " + title;
            this.Text = tmpTitle;
            this.titleLabel.Text = title;
        }
    }
}
