using shoes.AppForms;
using shoes.AppModels;
using System.Data;
using System.Linq;

namespace shoes.AppExceptions
{
    /// <summary>
    /// PKGH 
    /// Аутентификация и авторизация
    /// </summary>
    internal class AuthManager /// Поскольку вышенаписанной код, не самый лучший (не рабочий), то вот милсударь, рабочий, мать его, код. Еще бывает ошибка отсутствия пользователя G G, он же Гость. Создать его надбыть в БД окоянной с помощью команды || INSERT INTO[User] (Role, FullName, Login, Password) VALUES('Клиент', 'гость', 'g', 'g'); ||
    {
        public static void Login(string login, string password)
        {
            User tmpUser = Program.context.User
            .Where(user => user.Login == login)
            .Where(user => user.Password == password)
            .FirstOrDefault();
            if (tmpUser == null)
            {
                throw new UnauthorizedException();
            }

            ContextManager.user = tmpUser;

            ProductForm productForm = new ProductForm();
            ContextManager.productForm = productForm;

            productForm.Show();
            ContextManager.loginForm.Hide();
        }
        public static void Logout(ParentForm form)
        {
            ContextManager.user = null;
            form.Hide();
            ContextManager.loginForm.Show();
        }
    }
}
