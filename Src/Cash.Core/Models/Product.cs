using System;
using System.Collections.Generic;
using System.Text;

namespace Cash.Core
{
    public class Product
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        
        public Product()
        {
            var random = new Random();
            Name = Guid.NewGuid().ToString();
            Cost = random.Next(1, 100);
        }
        public void Getinfo()
        {
            Console.WriteLine($"Name of product:{Name}\n Cost of product:{Cost}\n");
        }
    }
}
