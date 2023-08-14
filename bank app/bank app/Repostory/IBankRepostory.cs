using bank_app.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_app.Repostory
{
    internal interface IBankRepostory
    {
        public Bank Bank { get; }
        void UserList(User user);
        bool BlockUser(User user);
        string ChangePassword(User user, string newpassword);
        void CheckBalance(User user);
        void TopUpBalance(User user, double balance);
        bool LogOut(User user);

    }
}
