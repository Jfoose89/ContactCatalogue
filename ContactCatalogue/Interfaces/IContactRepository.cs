using System.Collections.Generic;
using ContactCatalogue.Models;

namespace ContactCatalogue.Interfaces
{
    public interface IContactRepository
    {
        void Add(Contact contact);
        IEnumerable<Contact> GetAll();
        IEnumerable<Contact> SearchByName(string searchTerm);
        IEnumerable<Contact> FilterByTag(string tag);
    }
}
