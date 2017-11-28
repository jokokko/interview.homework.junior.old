namespace Sample.Tasks.Console.Messages
{
    public sealed class FetchBusinessRecords
    {
        public string SearchTerm { get; }

        public FetchBusinessRecords(string searchTerm)
        {
            SearchTerm = searchTerm;
        }
    }
}