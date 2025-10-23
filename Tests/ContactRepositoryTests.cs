using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using ContactCatalogue.Models;
using ContactCatalogue.Repositories;
using ContactCatalogue.Exceptions;

namespace ContactCatalogue.Tests
{
    public class ContactRepositoryTests
    {
        // TODO: Initialize repository before each test if needed

        [Fact]
        public void Add_ValidContact_ShouldSucceed()
        {
            var repo = new ContactRepository();
            var contact = new Contact(1, "Anna", "anna@example.com", new[] { "friend" });

            repo.Add(contact);

            var all = repo.GetAll().ToList();
            Assert.Single(all);
            Assert.Equal("Anna", all[0].Name);
        }

        [Fact]
        public void Add_DuplicateEmail_ShouldThrowException()
        {
            var repo = new ContactRepository();
            var contact1 = new Contact(1, "Anna", "anna@example.com", new[] { "friend" });
            var contact2 = new Contact(2, "Bo", "anna@example.com", new[] { "work" });

            repo.Add(contact1);

            Assert.Throws<DuplicateEmailException>(() => repo.Add(contact2));
        }

        [Fact]
        public void Add_InvalidEmail_ShouldThrowException()
        {
            var repo = new ContactRepository();
            var contact = new Contact(1, "Anna", "invalid-email", new[] { "friend" });

            Assert.Throws<InvalidEmailException>(() => repo.Add(contact));
        }

        // TODO: Add more tests for edge cases (empty tags, large numbers, etc.)
    }
}
