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
            IClientManager clientManager = new ClientManager();
            clientManager.CreateClient();
            clientManager.GetAllClients();
            clientManager.ShowClientBasket();
            Console.ReadKey();
        }
    }
}
