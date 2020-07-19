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
        private int balance;

        public int GetBalance()
        {
            return balance;
        }

        private void SetBalance(int value)
        {
            balance = value;
        }

        public Client()
        {
            var random = new Random();
            Name = Guid.NewGuid().ToString();
            SetBalance(random.Next(900,2000));
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
