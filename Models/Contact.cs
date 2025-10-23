using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactCatalogue.Models
{
    /// <summary>
    /// Represents a single contact in the catalog.
    /// </summary>
    public class Contact
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public List<string> Tags { get; private set; }

        public Contact(int id, string name, string email, IEnumerable<string> tags)
        {
            Id = id;
            Name = name;
            Email = email;
            Tags = tags.ToList();
            // TODO: Add any validation logic if needed
        }

        public override string ToString()
        {
            var tags = string.Join(", ", Tags);
            return $"({Id}) {Name} <{Email}> [{tags}]";
        }
    }
}
