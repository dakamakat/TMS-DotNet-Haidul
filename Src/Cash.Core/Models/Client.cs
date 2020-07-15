using System;
using System.Collections.Generic;
using System.Text;

namespace Cash.Core.Models
{
     class Client
    {
        public string  Name { get; set; }
        private readonly IList<Product> basket = new List<Product>();
        
        public Client()
        {
            Name = Guid.NewGuid().ToString();
        }
        public void GetClient()
        {
            Console.WriteLine($"Name of Client:{Name}");
        }
        public void ShowBasket()
        {
            foreach (var product in basket)
            {
                product.Getinfo();
            }
        }
        public IList<Product> GetBasket()
        {
            return basket;
        }
    }
}
