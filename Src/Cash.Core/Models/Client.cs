using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Cash.Core.Models
{
     public class Client
    {
        public string  Name { get; set; }
        private readonly IList<Product> basket = new List<Product>();
        public Thread thread;
        
        public Client()
        {
            Name = Guid.NewGuid().ToString();
        }
        public void GetClient()
        {
            Console.WriteLine($"Client:{Name}, products in backet:{basket.Count}");
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
