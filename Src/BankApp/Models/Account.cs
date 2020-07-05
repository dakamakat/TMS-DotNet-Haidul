using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    class Account
    {
        public string Id { get; set; }
        public MoneyType Type { get; set; }
        public decimal Balance { get; set; }

        public Account()
        {
            Id = Guid.NewGuid().ToString();
            Type = MoneyType.BYN;
        }
        public Account(string id)
        {
            Id = Guid.NewGuid().ToString();
        }
        public Account(string id, MoneyType type)
        {
            Id = Guid.NewGuid().ToString();
            Type = type;
        }
        public Account(string id, MoneyType type,decimal balance)
        {
            Id = Guid.NewGuid().ToString();
            Type = type;
            Balance = balance;
        }
        public void UpdateBalance(decimal money)
        {
            Balance += money;
        }
    }
}
