using System.Threading.Tasks;
using Proto;
using Sample.Tasks.Console.Messages;
using Sample.Tasks.Domain.Services;

namespace Sample.Tasks.Console.Actors
{
    public sealed class BusinessFinderActor : IActor
    {
        /// <question>
        /// What effects does the readonly modifier have?
        /// </question>
        private readonly IBusinessFinder finderService;

        public BusinessFinderActor(IBusinessFinder finderService)
        {
            this.finderService = finderService;
        }

        public Task ReceiveAsync(IContext context)
        {
            switch (context.Message)
            {
                case FetchBusinessRecords request:
                    {
                        // We got FetchBusinessRecords message
                        break;
                    }
            }

            return Actor.Done;
        }
    }
}