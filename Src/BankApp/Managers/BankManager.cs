using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankApp.Interfaces;
using BankApp.Models;

namespace BankApp.Managers
{
    class BankManager:IBankManager
    {
        private readonly IList<Client> _clients = new List<Client>();
        private readonly ClientManager _clientManager = new ClientManager();

        public void Put(Client client, decimal money)
        {
            if (client != null)
            {
                client.UpdateBalance(money);
            }
        }
        public void Take(Client client, decimal money)
        {
            if (client != null)
            {
                if (client.GetBalance() <= money)
                {
                    Console.WriteLine("Your balance is lower than sum which you wanna take");
                }
                else
                {
                    client.UpdateBalance(-money);
                }
            }
        }
        public void GetClientInfo(Client client)
        {
            _clientManager.GetInfo(client);
        }
        public IList<Client> GetClients()
        {
            return _clients;
        }
        public void GetAllClients()
        {
            if (_clients.Count > 0)
            {
                foreach (var client in _clients)
                {
                    _clientManager.GetInfo(client);
                }
            }
            else
            {
                Console.WriteLine("Bank has no clients");
            }
        }
    }
}


