using shoes.AppForms;
using shoes.AppModels;

namespace shoes.AppExceptions
{
    /// <summary>
    /// PKGH
    /// Помнит текущего пользователя
    /// и некоторые формы.
    /// </summary>
    internal class ContextManager
    {
        public static User user;
        public static ParentForm parentForm;
        public static ProductForm productForm;
        public static LoginForm loginForm;
    }

}
