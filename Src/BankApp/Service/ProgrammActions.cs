using BankApp.Managers;
using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        public static void InputAccount()
        {
            Client client;
            client = ChooseClient();
            Console.WriteLine(@"Choose type of money\n 1.USD\n2.BYN\n3.RUB");
            int.TryParse(Console.ReadLine(), out int userInput);
            Account account = new Account();
            switch (userInput)
            {
                case 1:
                    {
                        account.Type = MoneyType.USD;
                        break;
                    }
                case 2:
                    {
                        account.Type = MoneyType.BYN;
                        break;
                    }
                case 3:
                    {
                        account.Type = MoneyType.RUB;
                        break;
                    }
            }
            Console.WriteLine("Enter balance of your account: ");
            decimal.TryParse(Console.ReadLine(), out decimal balance);
            account.Balance = balance;
            client.GetAccounts().Add(account);
            Console.WriteLine("Account sucsessefully added");
        }
        public static void ConvertMoney(Account account1 , Account account2)
        {

        }
        public static void DeleteClient()
        {
            try
            {
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
            var id = Console.ReadLine();
            foreach (var client in _bankManager.GetClients())
            {
                if (client._id.Contains(id))
                {
                    Console.WriteLine($"You choosed {client.GetFullName()}");
                    return client;
                }
                
            }
            Console.WriteLine("Client with such id not found");
            return null;
        }
        public static void TakeMoney()
        {
            Client client;
            client = ChooseClient();
            if(client != null)
            {
                Console.WriteLine("Enter a sum : ");
                decimal.TryParse(Console.ReadLine(), out decimal money);
                _bankManager.Take(client, money);
            }
         

        }
        public static void PutMoney()
        {
            Client client;
            client = ChooseClient();
            if (client != null)
            {
                Console.WriteLine("Enter a sum : ");
                decimal.TryParse(Console.ReadLine(), out decimal money);
                _bankManager.Put(client, money);
            }
        }
        public static void ShowMenu()
        {
            Console.WriteLine("Choose action :");
            Console.WriteLine("1.Add new client :");
            Console.WriteLine("2.Add new account to client");
            Console.WriteLine("3.Convert money");
            Console.WriteLine("4.Delete client :");
            Console.WriteLine("5.Show client :");
            Console.WriteLine("6.Show all clients :");
            Console.WriteLine("7.Take money :");
            Console.WriteLine("8.Put money :");
            Console.WriteLine("9.Exit :\n");
        }
        public static void ShowMassage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
