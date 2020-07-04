using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace BankApp.Interfaces
{
    interface IBankManager
    {
        void Put(Client client, decimal money);
        void Take(Client client, decimal money);
    }
}
