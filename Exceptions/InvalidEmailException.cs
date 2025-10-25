using System;

namespace ContactCatalogue.Exceptions
{
    public class InvalidEmailException : Exception
    {
        public string Email { get; }

        public InvalidEmailException(string email) : base($"Invalid email: {email}")
        {
            Email = email;
        }
    }
}
