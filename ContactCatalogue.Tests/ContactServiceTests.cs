//using System.Linq;
//using Moq;
//using Xunit;
//using ContactCatalogue.Models;
//using ContactCatalogue.Interfaces;
//using ContactCatalogue.Services;

//namespace ContactCatalogue.Tests
//{
//    public class ContactServiceTests
//    {
//        [Fact]
//        public void SearchByName_ReturnsCorrectResults()
//        {
//            var mockRepo = new Mock<IContactRepository>();
//            mockRepo.Setup(r => r.GetAll()).Returns(new[]
//            {
//                new Contact(1, "Alice", "alice@example.com", new string[]{ }),
//                new Contact(2, "Bob", "bob@example.com", new string[]{ }),
//                new Contact(3, "Alicia", "alicia@example.com", new string[]{ })
//            });

//            var service = new ContactService(mockRepo.Object);
//            var results = service.SearchByName("ali").ToList();

//            Assert.Equal(2, results.Count);
//            Assert.Equal("Alicia", results[0].Name);
//            Assert.Equal("Alice", results[1].Name);
//        }

//        [Fact]
//        public void SearchByName_NoMatches_ReturnsEmpty()
//        {
//            var mockRepo = new Mock<IContactRepository>();
//            mockRepo.Setup(r => r.GetAll()).Returns(new[]
//            {
//                new Contact(1, "Alice", "alice@example.com", new string[]{ })
//            });

//            var service = new ContactService(mockRepo.Object);
//            var results = service.SearchByName("zzz");

//            Assert.Empty(results);
//        }
//    }
//}
