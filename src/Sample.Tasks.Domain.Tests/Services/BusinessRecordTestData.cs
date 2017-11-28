using System;
using System.Collections;
using System.Collections.Generic;
using Sample.Tasks.Domain.Model;

namespace Sample.Tasks.Domain.Tests.Services
{
    internal sealed class BusinessRecordTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
              "Papula", new BusinessRecord("0236098-2", "Papula Oy", new Uri(@"http://avoindata.prh.fi/opendata/tr/v1/0236098-2"))
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}