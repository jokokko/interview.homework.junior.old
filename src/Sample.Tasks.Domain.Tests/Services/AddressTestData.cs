using System;
using System.Collections;
using System.Collections.Generic;
using Sample.Tasks.Domain.Model;

namespace Sample.Tasks.Domain.Tests.Services
{
    /// <question>
    /// What effects does the internal modifier have?
    /// </question>
    internal sealed class AddressTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new BusinessRecord("0236098-2", "Papula Oy", new Uri(@"http://avoindata.prh.fi/opendata/tr/v1/0236098-2")),
                new Address
                {
                    Street = "Mechelininkatu 1a",
                    PostCode = 00180,
                    City = "Helsinki",                    
                    Country = "Finland"
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}