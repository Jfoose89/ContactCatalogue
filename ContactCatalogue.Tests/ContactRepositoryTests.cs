//using System.Linq;
//using Xunit;
//using ContactCatalogue.Models;
//using ContactCatalogue.Repositories;
//using ContactCatalogue.Exceptions;

//namespace ContactCatalogue.Tests
//{
//    public class ContactRepositoryTests
//    {
//        [Fact]
//        public void Add_ValidContact_ShouldSucceed()
//        {
//            var repo = new ContactRepository();
//            var contact = new Contact(1, "Anna", "anna@example.com", new[] { "friend" });
//            repo.Add(contact);

//            var all = repo.GetAll().ToList();
//            Assert.Single(all);
//            Assert.Equal("Anna", all[0].Name);
//        }

//        [Fact]
//        public void Add_InvalidEmail_ShouldThrowException()
//        {
//            var repo = new ContactRepository();
//            var contact = new Contact(1, "Anna", "invalid-email", new[] { "friend" });
//            Assert.Throws<InvalidEmailException>(() => repo.Add(contact));
//        }

//        [Fact]
//        public void Add_DuplicateEmail_ShouldThrowException()
//        {
//            var repo = new ContactRepository();
//            repo.Add(new Contact(1, "Anna", "anna@example.com", new[] { "friend" }));

//            var duplicate = new Contact(2, "Bob", "anna@example.com", new[] { "work" });
//            Assert.Throws<DuplicateEmailException>(() => repo.Add(duplicate));
//        }
//    }
//}
