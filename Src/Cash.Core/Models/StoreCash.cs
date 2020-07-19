using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Cash.Core.Models
{
    public class StoreCash
    {
        public string StoreCashNumber { get; set; }
        public int Speed { get; set; }
        public bool IsFree { get; set; } = true;
        public StoreCash()
        {
            var random = new Random();
            StoreCashNumber = Guid.NewGuid().ToString();
            Speed = random.Next(100, 500);
        }
         public void GetInfo()
        {
            Console.WriteLine($"Cash number:{StoreCashNumber}\nCash Speed:{Speed}\n");
        }
    }
}
