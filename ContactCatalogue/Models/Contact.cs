using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactCatalogue.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new List<string>();

        public Contact() { }

        public Contact(int id, string name, string email, IEnumerable<string> tags)
        {
            Id = id;
            Name = name;
            Email = email;
            Tags = new List<string>(tags);
        }

        public override string ToString()
        {
            var tags = string.Join(", ", Tags);
            return $"({Id}) {Name} <{Email}> [{tags}]";
        }
    }
}
