using System;

namespace shoes.AppExceptions
{
    internal class UnauthorizedException : Exception
    {
        public UnauthorizedException() : base("Логин или пароль неверны") { }
    }

}
