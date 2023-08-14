using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram
{
    internal class User
    {
        private string _name;
        public string Name {
            get
            {
                return _name;
            }
            set {
                if (value.Length > 3)
                {
                    _name = value;
                }

            }
        
        }
        private string _surname;
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length > 3)
                {
                    _surname = value;
                }
            }
        }
        private string password;
        public string PASSWORD
        {
            get
            {
                return password;
            }
            set 
            {
                if (CheckPassword(value))
                {
                    password = value;
                }

            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set {
                if (Checkemail(value))
                {
                    email= value;
                }
            }
        }
        public int ID;
        public bool isAdmin;
        public bool isBlock;
        public bool isLogin;
        public double balance;
        static int count;
        static User ()
        {
            count = 0;
        }
        public User(string name, string surname, string email, string password,bool isAdmin)
        {
           Name = name;
            Surname = surname;

        Email = email;
            PASSWORD= password;
            this.isAdmin = isAdmin;
            balance = 0;
            isBlock = false;
            isLogin = false;
            ID =++ count;

        }

        public static bool Checkemail(string email)
        {
            if(email.Contains("@"))
            {
                return true;
            }
            return false;
        }
        public static bool CheckPassword(string password)
        {
            bool lower= false;
            bool upper= false;
            bool result= false;
            if (password.Length < 7)
            {
                return result;

            }
                
            foreach (char c in password) {

                if (char .IsLower(c))
                {
                    lower = true;
                } 
                if (char .IsUpper(c)) {upper= true; }
                result =lower && upper;
                if (result)
                {
                    break;
                }


            }

            return result;
        }
    }
}

