using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Managers
{
    class AccountManager
    {
       public void GetInfo(Account account)
        {
            Console.WriteLine($"Account id : {account.Id}");
            Console.WriteLine($"Account type : {account.Type}");
            Console.WriteLine($"Account balance : {account.Balance}");
        }
        public Account Createaccount()
        {
            return new Account();
        }
        public Account Createaccount(string id)
        {
            return new Account(id);
        }
        public Account Createaccount(string id, MoneyType type)
        {
            return new Account(id, type);
        }
        public Account Createaccount(string id, MoneyType type,decimal balance)
        {
            return new Account(id, type,balance);
        }
    }
}
