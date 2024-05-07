using System;

namespace SaleStoreApi.Models
{
    // Class that represents a product
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Supplier { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Product(int id, string name, decimal price, string description, string supplier, DateTime expiryDate)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Supplier = supplier;
            ExpiryDate = expiryDate;
        }
    }
}
