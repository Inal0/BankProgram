using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram
{
    internal class Bank
    {
        public int ID;
        public User[] Users=new User[0];
        static int count;
        static Bank ()
        { count = 0; }
        public Bank()
        {
            ID = ++count; 
        }
    }
}
