using bank_app.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bank_app.Repostory
{
    internal class BankRepostory : IBankRepostory
    {
         Bank _bank;
        public Bank Bank
        {
            get
            {
                return _bank;

            }
        }

        public BankRepostory(Bank bank)
        {
            _bank = Bank;
        }

        public bool BlockUser(User user)
        {
            user.IsBlock = true;
            return true;
        }

        public string ChangePassword(User user, string newpassword)
        {
            user.Password = newpassword;
            Console.WriteLine("Password changed");
            return user.Password;
        }

        public void CheckBalance(User user)
        {
            Console.WriteLine(user.Balance);
        }

        public bool LogOut(User user)
        {
            return user.IsLogin = false;
        }

        public void TopUpBalance(User user, double balance)
        {
            user.Balance += balance;
            Console.WriteLine("New balance: " + user.Balance);
        }

        public void UserList(User user)
        {
            foreach (var item in _bank.users)
            {
                Console.WriteLine(user.Name , user.Surname);
            }
        }
    }
}
