using System;
using System.Collections.Generic;
using System.Linq;
using ContactCatalogue.Models;
using ContactCatalogue.Interfaces;

namespace ContactCatalogue.Services
{
    public class ContactService
    {
        private readonly IContactRepository repository;

        public ContactService(IContactRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Contact> SearchByName(string searchTerm)
        {
            return repository.GetAll()
                .Where(c => c.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .OrderBy(c => c.Name);
        }
        public IEnumerable<Contact> FilterByTag(string tag)
        {
            return repository.GetAll()
                .Where(c => c.Tags.Any(t => t.Equals(tag, StringComparison.OrdinalIgnoreCase)))
                .OrderBy(c => c.Name);
        }

    }
}
