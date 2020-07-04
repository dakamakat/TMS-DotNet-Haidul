using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankApp.Models;

namespace BankApp.Managers
{
    class BankManager
    {
        private readonly IList<Client> _clients = new List<Client>();
        private readonly ClientManager _clientManager = new ClientManager();

        public void Put(string id, decimal money)
        {
            Client client = _clients.SingleOrDefault(c => c._id == id);
            if (client != null)
            {
                client.UpdateBalance(money);
            }
        }
        public void Take(string id, decimal money)
        {
            Client client = _clients.SingleOrDefault(c => c._id == id);
            if (client != null)
            {
                if (client.GetBalance() <= money)
                {
                    Console.WriteLine("Your balance is lower than sum which you wanna take");
                }
                else
                {
                    client.UpdateBalance(--money);
                }
            }
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
        public GetClientById(string id)
        {

        }
    }
}


