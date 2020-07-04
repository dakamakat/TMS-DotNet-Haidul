using BankApp.Managers;
using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class ProgrammActions
    {
        private static readonly ClientManager _clientManager = new ClientManager();
        private static readonly BankManager _bankManager = new BankManager();
        public static void InputAnimal()
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

            //console.writeline("укажите тип животного:\n 1 - хищник \n 2 - травоядное ");
            //int.tryparse(console.readline(), out int userinput);
            //switch (userinput)
            //{
            //    case 1:
            //        animal.kind = enums.kindtype.predator;
            //        break;
            //    case 2:
            //        animal.kind = enums.kindtype.herbivorus;
            //        break;
            //    default:
            //        console.writeline("некорректный ввод");
            //        animal.kind = enums.kindtype.none;
            //        break;
            //}
            _bankManager.GetClients().Add(client);
            Console.WriteLine("Client successfully added");

        }
        public static void DeleteClient()
        {
            try
            {
                Console.Write("Enter id of client which you wanna remowe: ");
                var input = Console.ReadLine();
                if (.animals != null)
                {
                    _zoo.animals.RemoveAt(input - 1);
                }
                else
                    Console.WriteLine("");
            }
            catch (Exception)
            {
                Console.WriteLine("В зоопарке нет животного с таким номером");
            }


            Console.WriteLine("Животное успешно удалено");
        }
        public static void GetAllClients()
        {
            _bankManager.GetAllClients();
        }
        public static void GetClient()
        {
            Client client;
            if ((client = ChooseClient()) != null)
            {
                _clientManager.GetInfo(client);
            }
        }
        private static Animal ChooseClient()
        {
            Console.Write("Enter id of client: ");
            Client client;
            if (Guid.TryParse(Console.ReadLine(), out Guid id) && (client = .GetAnimalbyId(id)) != null)
            {
                return animal;
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
