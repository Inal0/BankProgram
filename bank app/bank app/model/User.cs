using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bank_app.model
{
    internal class User
    {
        public int ID { get; set; }
        string _name;
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                if (value.Length>3)
                {
                    _name = value;
                }
            } 
        }
        string _surname;
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

        string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (EmailChecker(value))
                {
                    _email = value;
                }
            }
        }
        string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }
        public bool IsAdmin { get; set; }
        public bool IsBlock { get; set; }
        public bool IsLogin { get; set; }
        public double Balance { get; set; }
        static int count;
        static User()
        {
            count = 0;
        }
        public User(string name, string surname, string email, string password, bool Isadmin)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            IsAdmin = Isadmin;
            IsBlock = false;
            IsLogin = false;
            Balance = default;
            ID = ++count;
        }
        public static bool EmailChecker(string email) 
        {
            if (email.Contains('@'))
            {
                return true;
            }
            return false;
        }
        public static bool PasswordChecker(string password) 
        {
            bool lower = false;
            bool upper = false;
            bool result = false;
            if (password.Length<7)
            {
                return result;
            }
            foreach (var item in password)
            {
                if (char.IsLower(item))
                {
                    lower = true;
                }
                if (char.IsUpper(item))
                {
                    upper = true;
                }
                result = upper && lower;
                if (result)
                {
                    break;
                }

            }
            return result;
        }
    }

}
