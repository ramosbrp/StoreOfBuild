using System;
using System.Collections.Generic;
using System.Text;

namespace StoreOfBuild.Domain.Products
{
    public class Product
    {
        //Encapsular com private
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Category Category { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }

        public Product(string name, Category category, decimal price, int stockQUantity)
        {
            ValidateValues(name, category, price, stockQUantity);

            SetProperties(name, category, price, stockQUantity);
        }

        public void Update(string name, Category category, decimal price, int stockQUantity)
        {
            ValidateValues(name, category, price, stockQUantity);
            SetProperties(name, category, price, stockQUantity);
        }

        private void SetProperties(string name, Category category, decimal price, int stockQUantity)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockQUantity;
        }

        private static void ValidateValues(string name, Category category, decimal price, int stockQUantity)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
            DomainException.When(category == null, "Category is required");
            DomainException.When(price < 0, "Price is required");
            DomainException.When(stockQUantity < 0, "Stock Quantity is required");
        }

    }
}
