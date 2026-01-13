using shoes.AppExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoes.AppServices
{
    internal class FormManager
    {
        public static void PrepareForm(string title, bool showLogout = true)
        {
            ContextManager.parentForm.SetFullNameAndRole();
            ContextManager.parentForm.SetTitle(title);
            if (showLogout)
            {
                ContextManager.parentForm.ShowLogoutButton();
            }
        }
    }
}
