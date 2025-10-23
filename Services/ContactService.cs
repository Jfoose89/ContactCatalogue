using System;
using System.Collections.Generic;
using System.Linq;
using ContactCatalogue.Models;
using ContactCatalogue.Interfaces;

namespace ContactCatalogue.Services
{
    /// <summary>
    /// Provides search and filter functionality for contacts.
    /// </summary>
    public class ContactService : IContactService
    {
        private readonly IContactRepository repository;

        public ContactService(IContactRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Contact> SearchByName(string searchTerm)
        {
            // TODO: Implement LINQ search by Name
            return Enumerable.Empty<Contact>();
        }

        public IEnumerable<Contact> FilterByTag(string tag)
        {
            // TODO: Implement LINQ filter by Tag
            return Enumerable.Empty<Contact>();
        }
    }
}
