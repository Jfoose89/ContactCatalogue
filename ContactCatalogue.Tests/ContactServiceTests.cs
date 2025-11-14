using System.Linq;
using System.Reflection.Metadata;
using ContactCatalogue.Interfaces;
using ContactCatalogue.Models;
using ContactCatalogue.Services;
using Moq;
using Xunit;

namespace ContactCatalogue.Tests
{
    public class ContactServiceTests
    {
        [Fact]
        public void SearchByName_ReturnsCorrectResults()
        {
            var mockRepo = new Mock<IContactRepository>();
            mockRepo.Setup(r => r.GetAll()).Returns(new[]
            {
                new Contact(1, "Alice", "alice@example.com", new string[]{ }),
                new Contact(2, "Bob", "bob@example.com", new string[]{ }),
                new Contact(3, "Alicia", "alicia@example.com", new string[]{ })
            });

            var service = new ContactService(mockRepo.Object);
            var results = service.SearchByName("ali").ToList();

            Assert.Equal(2, results.Count);
            Assert.Equal("Alice", results[0].Name);
            Assert.Equal("Alicia", results[1].Name);
        }

        [Fact]
        public void SearchByName_NoMatches_ReturnsEmpty()
        {
            var mockRepo = new Mock<IContactRepository>();
            mockRepo.Setup(r => r.GetAll()).Returns(new[]
            {
                new Contact(1, "Alice", "alice@example.com", new string[]{ })
            });

            var service = new ContactService(mockRepo.Object);
            var results = service.SearchByName("zzz");

            Assert.Empty(results);
        }

        [Theory]
        [InlineData("ali", 2, new[] { "Alice", "Alicia" })]
        [InlineData("bob", 1, new[] { "Bob" })]
        [InlineData("zzz", 0, new string[] { })]
        public void SearchByName_VariousCases_ReturnsExpected(string searchTerm, int expectedCount, string[] expectedNames)
        {
            // Arrange
            var mockRepo = new Mock<IContactRepository>();
            mockRepo.Setup(r => r.GetAll()).Returns(new[]
            {
                new Contact(1, "Alice", "alice@example.com", new string[]{ }),
                new Contact(2, "Bob", "bob@example.com", new string[]{ }),
                new Contact(3, "Alicia", "alicia@example.com", new string[]{ }),
            });

            var service = new ContactService(mockRepo.Object);

            // Act
            var results = service.SearchByName(searchTerm).ToList();

            // Assert
            Assert.Equal(expectedCount, results.Count);
            Assert.Equal(expectedNames, results.Select(r => r.Name).ToArray());
        }
    }
}