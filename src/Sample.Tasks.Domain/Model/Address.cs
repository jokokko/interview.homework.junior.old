namespace Sample.Tasks.Domain.Model
{
    /// <question>
    /// All the properties in this type all mutable. What implications might it have?
    /// Can you think of any negatives effects that this scheme could introduce?
    /// </question>
    public sealed class Address
    {
        public string Street { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}