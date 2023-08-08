namespace Northwind.Domain.Sales
{
    public class Region : AggregateRoot
    {
        public string Name { get; set; }
        public List<Territories> Territories { get; set; }
    }

    public class Territories
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
}