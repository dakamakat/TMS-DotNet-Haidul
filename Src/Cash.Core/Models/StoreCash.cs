using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Cash.Core.Models
{
    class StoreCash
    {
        public int StoreCashNumber { get; set; }
        public int Speed { get; set; }

        public StoreCash()
        {
            var random = new Random();
            StoreCashNumber = random.Next(3522, 3275);
            new Semaphore(1, 1);
            Speed = random.Next(800, 1000);
        }
         public void GetInfo()
        {
            Console.WriteLine($"Cash number:{StoreCashNumber}\nCash Speed:{Speed}");
        }
    }
}
