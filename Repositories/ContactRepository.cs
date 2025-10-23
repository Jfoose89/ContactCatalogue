using System;
using System.Collections.Generic;
using ContactCatalogue.Models;
using ContactCatalogue.Interfaces;
using ContactCatalogue.Exceptions;

namespace ContactCatalogue.Repositories
{
    /// <summary>
    /// Stores contacts using Dictionary + HashSet to prevent duplicates.
    /// </summary>
    public class ContactRepository : IContactRepository
    {
        private readonly Dictionary<int, Contact> byId = new();
        private readonly HashSet<string> emails = new(StringComparer.OrdinalIgnoreCase);

        public void Add(Contact contact)
        {
            // TODO: Add validation, duplicate checks
        }

        public IEnumerable<Contact> GetAll()
        {
            return byId.Values;
        }
    }
}
