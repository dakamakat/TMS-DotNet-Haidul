using BankApp.Managers;
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
        private readonly List<Account> _accounts = new List<Account>();
        private readonly AccountManager _accountManager = new AccountManager();

        public Client()
        {
            _id = Guid.NewGuid().ToString();
            _fullname = "Default";
            _balance = 0;
        }
        public Client(string fullname)
        {
            _id = Guid.NewGuid().ToString();
            _fullname = fullname;
        }
        public Client(string fullname, decimal balance)
        {
            _id = Guid.NewGuid().ToString();
            _fullname = fullname;
            _balance = balance;
        }
        public string GetFullName()
        {
            return _fullname;
        }
        public List<Account> GetAccounts()
        {
            return _accounts;
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
        public void GetAllAccounts()
        {
            if (_accounts.Count > 0)
            {
                foreach (var account in _accounts)
                {
                    _accountManager.GetInfo(account);
                }
            }
            else
            {
                Console.WriteLine("Client has no accounts");
            }
        }
    }
}
