using System;
using System.Collections.Generic;
using System.Text;
using Cash.Core.Models;

namespace Cash.Core.Intarfaces
{
     interface IClientManager
    {
        public void CreateClient();
        public void ShowAllClients();
        public void GetClientBasket();
        public void ShowClientBasket();
    }
}
