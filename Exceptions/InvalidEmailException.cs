using System;

namespace ContactCatalogue.Exceptions
{
    /// <summary>
    /// Thrown when trying to add a contact with an invalid email format.
    /// </summary>
    public class InvalidEmailException : Exception
    {
        // TODO: You can add more constructors or custom properties if needed
        public InvalidEmailException(string email)
            : base($"Invalid email: {email}")
        {
            // TODO: Optional logging or custom logic
        }
    }
}
