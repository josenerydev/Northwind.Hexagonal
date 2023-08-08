﻿namespace Northwind.Domain.Production
{
    public class Product
    {
        public string Category { get; set; }
        public bool Discontinued { get; set; }
        public string Name { get; set; }
        public float PricePerUnit { get; set; }
        public string QuantityPerUnit { get; set; }
        public int ReorderLevel { get; set; }
        public string Supplier { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
    }
}