using System.Threading.Tasks;
using Proto;
using Sample.Tasks.Console.Messages;
using Sample.Tasks.Domain.Services;

namespace Sample.Tasks.Console.Actors
{
    public sealed class AddressFinderActor
    {
        private readonly IBusinessAddressFinder finderService;

        public AddressFinderActor(IBusinessAddressFinder finderService)
        {
            this.finderService = finderService;
        }

        public Task ReceiveAsync(IContext context)
        {
            switch (context.Message)
            {
                case PrintBusinessAddress request:
                    {
                        break;
                    }
            }

            return Actor.Done;
        }
    }
}