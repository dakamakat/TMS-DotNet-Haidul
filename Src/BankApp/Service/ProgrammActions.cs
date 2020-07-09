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
        private static readonly AccountManager _accountManager = new AccountManager();
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
            Console.WriteLine(@"Choose type of money 1.USD 2.BYN 3.RUB");
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
            if(client != null)
            {
                client.GetAccounts().Add(account);
                Console.WriteLine("Account sucsessefully added");
            }
            else
            {
                Console.WriteLine("Cant add account");
            }     
        }
        public static void ConvertMoney()
        {
            Account account1 = ChooseAccount();
            Account account2 = ChooseAccount();
            if (account1 != null && account1.Type != MoneyType.BYN)
            {
                Console.WriteLine("Can convert only BYN");
            }
            if(account2 == null)
            {
                Console.WriteLine($"Account {account2.Id} didnt exist");
            }
            else
            {
                Console.WriteLine(@"Choose type of conversion 1.USD 2.BYN 3.RUB");
                int.TryParse(Console.ReadLine(), out int type);
                Console.WriteLine("Enter amount of money which you wanna convert");
                decimal.TryParse(Console.ReadLine(), out decimal money);
                switch (type)
                {
                    case 1:
                        {
                            account1.Balance -= money;
                            account2.Balance += Convert.ToDecimal(Convert.ToDouble(money) / 2.4);
                            break;
                        }
                    case 2:
                        {
                            account1.Balance -= money;
                            account2.Balance += Convert.ToDecimal(Convert.ToDouble(money) / 0.43);
                            break;
                        }
                    case 3:
                        {
                            account1.Balance -= money;
                            account2.Balance += Convert.ToDecimal(Convert.ToDouble(money) / 0.3);
                            break;
                        }
                }
                Console.WriteLine("Conwertatioin sucsesseful");
            }
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
        public static void DeleteAccount()
        {
            try
            {
                Client client;
                client = ChooseClient();
                Account account = new Account();
                account = ChooseAccount();
                if (client != null || account != null)
                {
                    client.GetAccounts().Remove(account);
                }
                else
                    Console.WriteLine("Account or client with such id not found");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Account sucsessefuly deleted");
        }
        public static void GetAllClients()
        {
            _bankManager.GetAllClients();
        }
        public static void GetAllAccounts()
        {
            Client client = ChooseClient();
            client.GetAllAccounts();
        }

        public static void GetClient()
        {
            Client client;
            if((client = ChooseClient()) != null)
            {
                _bankManager.GetClientInfo(client);
            }
        }
        public static void GetAccount()
        {
            Client client;
            client = ChooseClient();
            Account account = new Account();
            account = ChooseAccount();
            if ((client = ChooseClient()) != null || account != null)
            {
                _accountManager.GetInfo(account);
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
        public static Account ChooseAccount()
        {
            Client client;
            client = ChooseClient();
            Console.Write("Enter id of account: ");
            var id = Console.ReadLine();
            if(client != null)
            {
                foreach (var account in client.GetAccounts())
                {
                    if (account.Id.Contains(id))
                    {
                        Console.WriteLine($"You choosed {account.GetType()}");
                        return account;
                    }
                }
            }               
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
            Console.WriteLine("5.Delete account :");
            Console.WriteLine("6.Show client :");
            Console.WriteLine("7.Show account :");
            Console.WriteLine("8.Show all accounts :");
            Console.WriteLine("9.Show all clients :");
            Console.WriteLine("10.Put money :");
            Console.WriteLine("11.Take money :");
            Console.WriteLine("12.Exit :\n");
        }
    }
}
