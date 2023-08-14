using bank_app.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_app.Repostory
{
    internal interface Iuserrepostory
    {
        void Registration(User user);
        void Login(User user);
        void FindUser(User user);
    }
 
}
