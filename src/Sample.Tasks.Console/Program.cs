using System.Threading.Tasks;
using Proto;
using Sample.Tasks.Console.Actors;
using Sample.Tasks.Console.Messages;
using Sample.Tasks.Domain.Services;

namespace Sample.Tasks.Console
{
    internal static class Program
    {
        private static void Main()
        {
            var businessFinderActorProperties = Actor.FromProducer(() => new BusinessFinderActor(new BusinessFinder()));

            var businessFinderActor = Actor.Spawn(businessFinderActorProperties);

            EnterProgramLoop(businessFinderActor).Wait();
        }

        /// <question>
        /// Can you tell why we use the async and await keywords in the method below?
        /// </question>        
        private static async Task EnterProgramLoop(PID businessFinderActor)
        {
            while (true)
            {
                System.Console.WriteLine("Give a search term >");

                var searchTerm = System.Console.ReadLine();

                var records = await businessFinderActor.RequestAsync<FetchedBusinessRecords>(new FetchBusinessRecords(searchTerm));

                // Now we must mediate this data to AddressFinderActor
            }
        }
    }
}
