using System;

namespace iabilet.domain.validators
{
    public class ValidationException : ApplicationException
    {
        public ValidationException(String message) : base(message)
        {
        }
    }
}