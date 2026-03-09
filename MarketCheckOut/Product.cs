using System;
using System.Collections.Generic;
using System.Text;

namespace MarketCheckOut
{
    public class Product
    {
        public Product(int id, string name, int quantity, decimal unitPrice)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = quantity * unitPrice;   
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }


    }
}
