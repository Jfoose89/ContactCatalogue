using System.Collections.Generic;
using ContactCatalogue.Models;

namespace ContactCatalogue.Interfaces
{
    /// <summary>
    /// Abstraction for storing and retrieving contacts.
    /// </summary>
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
        void Add(Contact contact);
        // TODO: Add more methods like Remove, Update if needed
    }
}
