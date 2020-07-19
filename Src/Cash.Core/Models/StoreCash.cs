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
        private int _balanceofCash = 0;
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
        public int GetBalance()
        {
            return _balanceofCash;
        }
        public void SetBalance(int value)
        {
            _balanceofCash += value;
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Balance of Cash {StoreCashNumber} = {_balanceofCash}");
        }
    }
}
