using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    class Account
    {
        public string Id { get; set; }
        public MoneyType Type { get; set; }
        public decimal balance { get; set; }
    }
}
