using bank_app.model;
using bank_app.Repostory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace bank_app.Service
{
    internal class UserServices
    {
        readonly Iuserrepostory iuserrepostory;
        Bank Bank;
        public UserServices(Bank bank)
        {
            Bank = bank;
            iuserrepostory = new Userrepostory(Bank);

        }
        public bool Registration(string name, string surname, string password, string email, bool isadmin) 
        {
            foreach (User user in Bank.users)
            {
                if (user.Email == email)
                {
                    Console.WriteLine("This email already used");
                }
            
            }
            User newuser = new User(name, surname, email, password, isadmin);
            iuserrepostory.Registration(newuser);
            return true;
        }
        public bool Login(string email, string password) 
        {
            foreach (User user in Bank.users)
            {
                if (user.Email == email && user.Password == password)
                {
                    iuserrepostory.Login(user);
                    return true;
                }
            }
            Console.WriteLine("User not found");
            return false;
        }
        public bool FindUser(string email) 
        {
            foreach (User user in Bank.users)
            {
                if (user.Email == email)
                {
                    iuserrepostory.FindUser(user);
                    return true;
                }
            }
            Console.WriteLine("User not found");
            return false;
        }
    }
}
