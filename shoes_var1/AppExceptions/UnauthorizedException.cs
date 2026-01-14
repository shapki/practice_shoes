using System;

namespace shoes.AppExceptions
{
    /// <summary>
    /// PKGH 
    /// Ошибка авторизации
    /// </summary>
    internal class UnauthorizedException : Exception
    {
        public UnauthorizedException() : base("Логин или пароль неверны") { }
    }

}
