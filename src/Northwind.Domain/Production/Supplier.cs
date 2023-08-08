namespace Northwind.Domain.Production
{
    public class Supplier
    {
        public Address Address { get; set; }
        public Contact Contact { get; set; }
        public object Fax { get; set; }
        public object HomePage { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Line1 { get; set; }
        public object Line2 { get; set; }
        public object Location { get; set; }
        public int PostalCode { get; set; }
        public object Region { get; set; }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Title { get; set; }
    }
}