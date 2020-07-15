using System;
using System.Collections.Generic;
using System.Text;
using Cash.Core.Models;

namespace Cash.Core.Intarfaces
{
     public interface IClientManager
    {
        public void CreateClient();
        public void GetAllClients();
        public void GetClientBasket();
        public void ShowClientBasket();
    }
}
