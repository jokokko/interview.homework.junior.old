using System.Collections.Generic;
using Sample.Tasks.Domain.Model;

namespace Sample.Tasks.Console.Messages
{
    public sealed class FetchedBusinessRecords
    {
        public IEnumerable<BusinessRecord> Records { get; }

        /// <question>
        /// What benefits might using an IEnumerable<T> over e.g. a List<T> provide?
        /// </question>
        public FetchedBusinessRecords(IEnumerable<BusinessRecord> records)
        {
            Records = records;
        }
    }
}