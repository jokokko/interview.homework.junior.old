using System;

namespace Sample.Tasks.Domain.Model
{
    /// <question>
    /// What effects does sealing a class have? Why might you want to seal a class?
    /// </question>
    public sealed class BusinessRecord
    {
        public string Identifier { get; }
        public string Name { get; }
        public Uri DetailsUri { get; }

        public BusinessRecord(string identifier, string name, Uri detailsUri)
        {
            Identifier = identifier;
            Name = name;
            DetailsUri = detailsUri;
        }
    }
}