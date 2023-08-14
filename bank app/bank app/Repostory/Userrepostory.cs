using bank_app.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_app.Repostory
{
    internal class Userrepostory : Iuserrepostory

    {
        private Bank _bank;
        public Bank Bank 
        {
            get
            {
                return _bank;

            }
        }
        public Userrepostory(Bank bank)
        {
            _bank = bank;
        }
        public void FindUser(User user)
        {
            Console.WriteLine($"user: {user.Name} {user.Surname} ");
        }

        public void Login(User user)
        {
            user.IsLogin = true;
            Console.WriteLine($" user:{user.Name} {user.Surname} {user.Balance} {user.IsAdmin} ");
        }

        public void Registration(User user)
        {
            Array.Resize(ref _bank.users, _bank.users.Length + 1);
            _bank.users[_bank.users.Length - 1] = user;
            Console.WriteLine("Registration success");
        }
    }
}
