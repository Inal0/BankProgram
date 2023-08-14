using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_app.model
{
    internal class Bank
    {
        public int ID { get; set; }
        static int count;
        public User[] users = new User[0];
        static Bank()
        {
            count = 0;
        }
        public Bank()
        {
            ID = ++count;
        }
    }
}
