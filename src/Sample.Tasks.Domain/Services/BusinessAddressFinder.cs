using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sample.Tasks.Domain.Model;

namespace Sample.Tasks.Domain.Services
{
    public sealed class BusinessAddressFinder
    {
        /// <question>
        /// Our method takes in a BusinessRecord. What are the implications of this?
        /// Could the signature be simplified and if so, what benefits could there be?
        /// </question>        
        public Task<IEnumerable<Address>> SearchByBusinessRecord(BusinessRecord record)
        {
            throw new NotImplementedException();
        }
    }
}