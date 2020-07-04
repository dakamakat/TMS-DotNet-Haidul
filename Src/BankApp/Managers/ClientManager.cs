using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Interfaces;
using BankApp.Models;

namespace BankApp.Managers
{
    class ClientManager:IClientManager
    {
        public void GetInfo(Client client)
        {
            Console.WriteLine($"Client id : {client.GetId()}");
            Console.WriteLine($"Client name : {client.GetFullName()}");
            Console.WriteLine($"Client balance : {client.GetBalance()}");
        }
        public void SetFullname(Client client,string fullname)
        {
            if (!string.IsNullOrEmpty(fullname))
            {
                client.SetFullName(fullname);
            }
            else
            {
                Console.WriteLine("Cant change name");
            }
        }
        public Client CreateClient()
        {
            return new Client();
        }
        public Client CreateClient(string name)
        {
            return new Client(name);
        }
        public Client CreateClient(string name, decimal balance)
        {
            return new Client(name, balance);
        }
    }
}
