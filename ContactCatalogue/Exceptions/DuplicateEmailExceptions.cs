using System;

namespace ContactCatalogue.Exceptions
{
    public class DuplicateEmailException : Exception
    {
        public string Email { get; }

        public DuplicateEmailException(string email) : base($"Duplicate email: {email}")
        {
            Email = email;
        }
    }
}