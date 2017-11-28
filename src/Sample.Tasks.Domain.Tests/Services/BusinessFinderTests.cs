using System;
using System.Linq;
using System.Threading.Tasks;
using Ploeh.SemanticComparison.Fluent;
using Sample.Tasks.Domain.Model;
using Sample.Tasks.Domain.Services;
using Xunit;

namespace Sample.Tasks.Domain.Tests.Services
{
    public sealed class BusinessFinderTests
    {
        private readonly BusinessFinder sut;

        public BusinessFinderTests()
        {
            sut = new BusinessFinder();
        }

        [Fact]
        public void SutIsIBusinessFinder()
        {
            Assert.IsAssignableFrom<IBusinessFinder>(sut);
        }

        [Fact]
        public async Task ThrowsOnNullSearchTerm()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(() => sut.SearchByName(null));
        }

        /// <question>
        /// Here we use SemanticComparison (https://www.nuget.org/packages/SemanticComparison)
        /// to check for equality. How could we avoid having this test dependency and what
        /// it tells us about our model?
        /// </question>        
        [Theory]
        [ClassData(typeof(BusinessRecordTestData))]
        public async Task CanGetInventionTitle(string searchTerm, BusinessRecord expectedRecord)
        {
            var dataFromSut = await sut.SearchByName(searchTerm);

            var likeness = expectedRecord.AsSource().OfLikeness<BusinessRecord>();

            Assert.True(dataFromSut.Any(x => likeness.Equals(x)));
        }
    }
}
