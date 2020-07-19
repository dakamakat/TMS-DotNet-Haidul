using Cash.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cash.Core.Intarfaces
{
     interface IStoreCashManager
    {
        public void GenerateStoreCash();
        public IList<StoreCash> GetStoreCashes();
        public void ShowStoreCashes();
    }
}
