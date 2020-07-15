using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Cash.Core.Models
{
    class Cash
    {
        public int CashNumber { get; set; }
        public int Speed { get; set; }

        public Cash()
        {
            var random = new Random();
            new Semaphore(1, 1);
            CashNumber = random.Next(3522, 3575);
        }
    }
}
