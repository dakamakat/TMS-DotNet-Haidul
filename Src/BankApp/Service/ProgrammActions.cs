using BankApp.Managers;
using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace BankApp
{
    class ProgrammActions
    {
        private static readonly ClientManager _clientManager = new ClientManager();
        private static readonly BankManager _bankManager = new BankManager();
        public static void InputClient()
        {
            Console.Write("Enter name: ");
            var name = Console.ReadLine();
            Client client;

            if (!string.IsNullOrEmpty(name))
            {
                client = _clientManager.CreateClient(name);
            }
            else
            {
                client = _clientManager.CreateClient();
            }
            Console.WriteLine("Enter your balance: ");
            decimal.TryParse(Console.ReadLine(), out decimal balance);
            client.UpdateBalance(balance);
            _bankManager.GetClients().Add(client);
            Console.WriteLine("Client successfully added");
        }
        public static void DeleteClient()
        {
            try
            {
                Console.Write("Enter id of client which you wanna remowe: ");
                var input = Console.ReadLine();
                Client client;
                if ((client = ChooseClient()) != null)
                {
                    _bankManager.GetClients().Remove(client);
                }
                else
                    Console.WriteLine("Client with such id not found");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Client sucsessefuly deleted");
        }
        public static void GetAllClients()
        {
            _bankManager.GetAllClients();
        }
        public static void GetClient()
        {
            Client client;
            if((client = ChooseClient()) != null)
            {
                _bankManager.GetClientInfo(client);
            }
        }
        public static Client ChooseClient()
        {
            Console.Write("Enter id of client: ");
            Client client;
            string id = Console.ReadLine();
            client = (Client)_bankManager.GetClients().Where(c => c._id.Contains(id));
            if(client != null)
            {
                return client;
            }
            else
            {
                Console.WriteLine("Client with such id not found");
                return null;
            }
        
        }
        public static void ShowMenu()
        {
            Console.WriteLine("Choose action :");
            Console.WriteLine("1.Add new client :");
            Console.WriteLine("2.Delete client :");
            Console.WriteLine("3.Show client :");
            Console.WriteLine("4.Show all clients :");

        }
    }
}
