using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp.Models
{
    class Bank
    {
        private IList<Client> clients = new List<Client>();

        public void Put(string id, decimal money)
        {
            Client client = clients.SingleOrDefault(c => c._id == id);
            if(client != null)
            {
                client.UpdateBalance(money);
            }
        }
        public void Take (string id , decimal money)
        {
            Client client = clients.SingleOrDefault(c => c._id == id);
            if (client != null)
            {
                if (client.GetBalance() <= money)
                {
                    Console.WriteLine("Your balance is lower than sum which you wanna take");
                }
                else
                {
                    client.UpdateBalance(--money);
                }
            }
        }
    }
}
