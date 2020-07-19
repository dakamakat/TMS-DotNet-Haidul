using Cash.Core.Intarfaces;
using Cash.Core.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cash.Core.Managers
{
    public class StoreCashManager:IStoreCashManager
    {
        private ConcurrentQueue<Client> taskQueue;
        public static int _cashisonline;
        private readonly IList<StoreCash> _storeCashes;
        public  ClientManager _clientManager = new ClientManager();
        object locker = new object();
        public StoreCashManager(int cashisonline)
        {
            _storeCashes = new List<StoreCash>();
            _cashisonline = cashisonline;
        }
        public void GenerateStoreCash()
        {
            for (int i = 0; i < _cashisonline; i++)
            {
               var storecash = new StoreCash();
                _storeCashes.Add(storecash);
            }
        }
        public void ClientHeandler(ClientManager clientManager)
        {
            int threadCount = _cashisonline;

            taskQueue = new ConcurrentQueue<Client>(clientManager.GetAllClients());
            
            for (int i = 0; i < threadCount; i++)
                new Thread(ServeClient) { IsBackground = true }.Start();
        }
        public void ServeClient()
        {
           
            while (taskQueue.TryDequeue(out Client client))
            {
                StoreCash selectedcash;
                lock (locker)
                { 
                    if ((selectedcash = _storeCashes.FirstOrDefault(c => c.IsFree == true)) != null)
                    {
                        selectedcash.IsFree = false;
                    }
                    else
                    {
                        if((selectedcash = _storeCashes.FirstOrDefault(c => c.IsFree == true)) == null)
                        {
                            Console.WriteLine($"All cashes are busy:Client {client.Name} please wait");
                            while((selectedcash = _storeCashes.FirstOrDefault(c => c.IsFree == true)) == null)
                            {
                            }
                        }
                        selectedcash.IsFree = false;
                    }
                }                   
                Console.WriteLine($"Cass:{selectedcash.StoreCashNumber} start to serve client {client.Name} {Thread.CurrentThread.Name}");
                var time = client.GetBasket().Count * selectedcash.Speed;
                Thread.Sleep(time);
                Console.WriteLine($"Cass:{selectedcash.StoreCashNumber} end to serve client {client.Name} {time}");
                selectedcash.IsFree = true;
                Thread.Sleep(200);
            } 
        }
        public IList<StoreCash> GetStoreCashes()
        {
            return _storeCashes;
        }
        public void ShowStoreCashes()
        {
            foreach (var cashe in _storeCashes)
            {
                cashe.GetInfo();
            }
        }
    }
}
