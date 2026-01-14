using shoes.AppExceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoes.AppServices
{
    internal class FormManager
    {
        public static ErrorProvider ErrorProvider { get; set; } = new System.Windows.Forms.ErrorProvider();

        public static void PrepareForm(string title, bool showLogout = true)
        {
            ContextManager.parentForm.SetFullNameAndRole();
            ContextManager.parentForm.SetTitle(title);
            if (showLogout)
            {
                ContextManager.parentForm.ShowLogoutButton();
            }
        }

        /// <summary>
        /// PKGH
        /// Универсальная проверка поля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void ValidateGeneral(object sender, CancelEventArgs e)
        {
            Control control = (Control)sender;
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                e.Cancel = true; // PKGH Предотвратить потерю фокуса.
                ErrorProvider.SetError(control, "Введите корректные данные!"); // PKGH показать подсказку.
            }
            else
            {
                ErrorProvider.SetError(control, null); // PKGH Пользователь исправился (он ввел данные), теперь надо очистить сообщение об ошибке.
            }
        }
    }
}
