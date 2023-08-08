namespace Northwind.Domain.Sales
{
    public class Shipper : AggregateRoot
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}