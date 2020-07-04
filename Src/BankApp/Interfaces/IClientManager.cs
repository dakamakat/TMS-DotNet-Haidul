using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    interface IClientManager
    {
        void GetInfo(Client client);
        void SetFullname(Client client, string fullname);

    }
}
