using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : SystemException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
