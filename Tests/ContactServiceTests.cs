using System.Collections.Generic;
using System.Linq;
using Xunit;
using Moq;
using ContactCatalogue.Models;
using ContactCatalogue.Interfaces;
using ContactCatalogue.Services;

namespace ContactCatalogue.Tests
{
    public class ContactServiceTests
    {
        // TODO: Add xUnit tests using Moq here

        [Fact]
        public void Filter_By_Tag_Returns_Only_Matching()
        {
            var mock = new Mock<IContactRepository>();
            mock.Setup(r => r.GetAll()).Returns(new[]
            {
                new Contact(1, "Anna", "a@x.se", new[] {"friend"}),
                new Contact(2, "Bo", "b@x.se", new[] {"work"})
            });

            var svc = new ContactService(mock.Object);
            var result = svc.FilterByTag("friend").ToList();

            Assert.Single(result);
            Assert.Equal("Anna", result[0].Name);
        }
    }
}
