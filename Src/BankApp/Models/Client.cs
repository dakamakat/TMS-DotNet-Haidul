using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Models
{
    class Client
    {
        public readonly string _id;
        private string _fullname;
        private decimal _balance;

        public Client(string fullname)
        {
            _fullname = fullname;
        }
        public Client(string fullname,decimal balance)
        {
            _id = Guid.NewGuid().ToString();
            _fullname = fullname;
            _balance = balance;
        }
        public string GetFullName()
        {
            return _fullname;
        }
        public string GetId()
        {
            return _id;
        }
        public void SetFullName(string fullname)
        {
            _fullname = fullname;
        }
        public decimal GetBalance()
        {
            return _balance;
        }
        public void UpdateBalance(decimal money)
        {
            _balance += money;
        }
    }
}
