namespace Northwind.Domain.Production
{
    public class Category : AggregateRoot
    {
        public string Description { get; set; }
        public string Name { get; set; }
    }
}