using System;
using Cash.Core.Managers;
using Cash.Core.Models;
using Cash.Core.Intarfaces;
using System.Linq;

namespace Cash.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientManager clientManager = new ClientManager();
            Console.WriteLine("Entee number of clients:");
            int.TryParse(Console.ReadLine(), out int userinp);

            for (int i = 0; i < userinp; i++)
            {
                clientManager.CreateClient();
            }
            clientManager.ShowAllClients();
            Console.WriteLine("Enter a number of cashes:");
            int.TryParse(Console.ReadLine(), out int userinput);
            StoreCashManager storeCashManager = new StoreCashManager(userinput);
            storeCashManager.GenerateStoreCash();
            storeCashManager.ClientHeandler(clientManager);
            storeCashManager.ServeClient();
            System.Threading.Thread.Sleep(10000);
            foreach (var cash in storeCashManager.GetStoreCashes())
            {       
                cash.GetInfo();
                cash.ShowBalance();
            }
            Console.ReadKey();
        }
    }
}
