using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sample.Tasks.Domain.Model;

namespace Sample.Tasks.Domain.Services
{
    public sealed class BusinessFinder : IBusinessFinder
    {
        public Task<IEnumerable<BusinessRecord>> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}