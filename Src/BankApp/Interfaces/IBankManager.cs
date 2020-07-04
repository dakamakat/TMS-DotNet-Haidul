using System;
using System.Collections.Generic;
using System.Text;


namespace BankApp.Interfaces
{
    interface IBankManager
    {
        void Put(string id, decimal money);
        void Take(string id, decimal money);
    }
}
