using Cash.Core.Intarfaces;
using Cash.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cash.Core.Managers
{
     public class ClientManager:IClientManager
    {
        private readonly IList<Client> Clients;
        public ClientManager()
        {
            Clients = new List<Client>();
        }
        public void CreateClient()
        {
            Client client = new Client();
            FeelBasket(client);
            Clients.Add(client);
        }
        private void FeelBasket(Client client)
        {
            var random = new Random();
            var productsCount = random.Next(1, 10);
            for (int i = 0; i < productsCount; i++)
            {
                client.GetBasket().Add(new Product());
            }
        }
        public void ShowAllClients()
        {
            foreach (var client in Clients)
            {
                client.GetClient();
            }
        }
        public void GetClientBasket()
        {
            foreach (var client in Clients)
            {
                client.GetBasket();
            }
        }
        public void ShowClientBasket()
        {
            foreach (var client in Clients)
            {
                Console.WriteLine($"{client.Name} products");
                client.ShowBasket();
            }
        }
    }
}
