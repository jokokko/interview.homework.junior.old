using System.Collections.Generic;
using System.Threading.Tasks;
using Sample.Tasks.Domain.Model;

namespace Sample.Tasks.Domain.Services
{
    public interface IBusinessAddressFinder
    {
        Task<IEnumerable<Address>> SearchByBusinessRecord(BusinessRecord record);
    }
}