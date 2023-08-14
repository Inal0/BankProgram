using bank_app.model;
using bank_app.Repostory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_app.Service
{
    internal class BankServices
    {
        readonly IBankRepostory bankRepostory;
        Bank Bank;
        public BankServices(Bank bank)
        {
            Bank = bank;
            bankRepostory = new BankRepostory(Bank);
        }
        public bool UserList(string email, string password) 
        {
            foreach (User user in Bank.users)
            {
                if (user.Email == email && user.Password == password)
                {
                    if (user.IsAdmin == true)
                    {
                        bankRepostory.UserList(user);
                        return true;
                    }
                }
            }
            return false;
        }
        public bool ChangePassword(string email, string password, string newpassword) 
        {
         

            foreach  (User user in Bank.users)
            {
                if (user.Email == email && user.Password == password )
                {
                    bankRepostory.ChangePassword(user, newpassword);
                    return true;
                }
            }
            Console.WriteLine("Password error");
            return false;
        }
        public bool BlockUser(string email) 
        {
            foreach (User user in Bank.users)
            {
                if (user.Email == email)
                {
                    bankRepostory.BlockUser(user);
                    return true;
                }
            }
            return false;
        }
        public bool CheckBalance(string email, string password) 
        {
            foreach (User user in Bank.users)
            {
                if (user.Email == email && user.Password == password)
                {
                    bankRepostory.CheckBalance(user);
                    return true;
                }
            }
            return false;
        }
        public bool TopUpBalance(string email, string password, double balance) 
        {
            foreach (User user in Bank.users)
            {
                if (user.Email == email && user.Password == password)
                {
                    bankRepostory.TopUpBalance(user, balance);
                    return true;
                }
            }
            return false;
        }
        public void LogOut(User user) 
        {
            bankRepostory.LogOut(user);
        }
    } 
}
