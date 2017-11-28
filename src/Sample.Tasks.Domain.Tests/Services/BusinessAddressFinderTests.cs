using System;
using System.Linq;
using System.Threading.Tasks;
using Ploeh.SemanticComparison.Fluent;
using Sample.Tasks.Domain.Model;
using Sample.Tasks.Domain.Services;
using Xunit;

namespace Sample.Tasks.Domain.Tests.Services
{
    public sealed class BusinessAddressFinderTests
    {
        private readonly BusinessAddressFinder sut;

        public BusinessAddressFinderTests()
        {
            sut = new BusinessAddressFinder();
        }

        [Fact]
        public void SutIsIBusinessFinder()
        {
            Assert.IsAssignableFrom<IBusinessAddressFinder>(sut);
        }

        [Fact]
        public async Task ThrowsOnNullSearchTerm()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(() => sut.SearchByBusinessRecord(null));
        }

        [Theory]
        [ClassData(typeof(AddressTestData))]
        public async Task CanGetInventionTitle(BusinessRecord searchTerm, Address expectedAddress)
        {
            var dataFromSut = await sut.SearchByBusinessRecord(searchTerm);

            var likeness = expectedAddress.AsSource().OfLikeness<Address>();

            Assert.True(dataFromSut.Any(x => likeness.Equals(x)));
        }
    }
}