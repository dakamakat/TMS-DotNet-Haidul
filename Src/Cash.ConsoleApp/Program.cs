using System;
using Cash.Core.Managers;
using Cash.Core.Models;
using Cash.Core.Intarfaces;

namespace Cash.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientManager clientManager = new ClientManager();
            StoreCashManager storeCashManager = new StoreCashManager(5);
            clientManager.CreateClient();
            clientManager.CreateClient();
            clientManager.ShowAllClients();
            clientManager.ShowClientBasket();
            storeCashManager.GenerateStoreCash();
            storeCashManager.ShowStoreCashes();

            Console.ReadKey();
        }
    }
}
