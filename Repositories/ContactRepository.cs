using System;
using System.Collections.Generic;
using System.Linq;
using ContactCatalogue.Models;
using ContactCatalogue.Interfaces;
using ContactCatalogue.Exceptions;

namespace ContactCatalogue.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly Dictionary<int, Contact> byId = new();
        private readonly HashSet<string> emails = new(StringComparer.OrdinalIgnoreCase);

        public void Add(Contact contact)
        {
            if (!IsValidEmail(contact.Email))
                throw new InvalidEmailException(contact.Email);

            if (byId.ContainsKey(contact.Id))
                throw new ArgumentException($"Duplicate Id: {contact.Id}");

            if (!emails.Add(contact.Email))
                throw new DuplicateEmailException(contact.Email);

            byId.Add(contact.Id, contact);
        }

        public IEnumerable<Contact> GetAll()
        {
            return byId.Values;
        }

        public IEnumerable<Contact> SearchByName(string searchTerm)
        {
            return byId.Values
                .Where(c => c.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                .OrderBy(c => c.Name);
        }

        public IEnumerable<Contact> FilterByTag(string tag)
        {
            return byId.Values
                .Where(c => c.Tags.Any(t => t.Equals(tag, StringComparison.OrdinalIgnoreCase)))
                .OrderBy(c => c.Name);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
