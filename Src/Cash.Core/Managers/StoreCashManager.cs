using Cash.Core.Intarfaces;
using Cash.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cash.Core.Managers
{
    public class StoreCashManager:IStoreCashManager
    {
        private readonly int _cashisonline;
        private readonly IList<StoreCash> storeCashes;
        public StoreCashManager(int cashisonline)
        {
            storeCashes = new List<StoreCash>();
            _cashisonline = cashisonline;
        }
        public void GenerateStoreCash()
        {
            for (int i = 0; i < _cashisonline; i++)
            {
               var storecash = new StoreCash();
                storeCashes.Add(storecash);
            }
        }
        public void ShowStoreCashes()
        {
            foreach (var cashe in storeCashes)
            {
                cashe.GetInfo();
            }
        }
    }
}
