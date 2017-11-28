using System;

namespace Sample.Tasks.Console.Messages
{
    public sealed class PrintBusinessAddress
    {
        public Uri BusinessDetailUri { get; }

        public PrintBusinessAddress(Uri businessDetailUri)
        {
            BusinessDetailUri = businessDetailUri;
        }
    }
}