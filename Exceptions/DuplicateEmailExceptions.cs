using System;

namespace ContactCatalogue.Exceptions
{
    /// <summary>
    /// Thrown when trying to add a contact with an email that already exists.
    /// </summary>
    public class DuplicateEmailException : Exception
    {
        // TODO: You can add more constructors or custom properties if needed
        public DuplicateEmailException(string email)
            : base($"Duplicate email: {email}")
        {
            // TODO: Optional logging or custom logic
        }
    }
}
