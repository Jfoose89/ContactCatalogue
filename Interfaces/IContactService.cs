using System.Collections.Generic;
using ContactCatalogue.Models;

namespace ContactCatalogue.Interfaces
{
    /// <summary>
    /// Abstraction for service operations like searching and filtering.
    /// </summary>
    public interface IContactService
    {
        IEnumerable<Contact> SearchByName(string searchTerm);
        IEnumerable<Contact> FilterByTag(string tag);
        // TODO: Add more methods as needed
    }
}
