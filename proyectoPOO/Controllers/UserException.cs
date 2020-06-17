using System;

namespace proyectoPOO
{
    public class UserException: Exception
    {
        public UserException(string message) : base(message)
        {
        }
    }
}