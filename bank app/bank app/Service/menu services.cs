using bank_app.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace bank_app.Service
{
    internal static class menu_services
    {
        readonly static BankServices _bankservices;
        readonly static UserServices _userservices;
        static Bank Mybank;

        static menu_services()
        {
            Mybank = new Bank();
            _bankservices = new BankServices(Mybank);
            _userservices = new UserServices(Mybank);
        }

        public static void Registration()
        {
            string name;
            do
            {
                Console.WriteLine("Please enter name");
                name = Console.ReadLine();
            } while (!NameSurnameChecker(name));
            string surname;
            do
            {
                Console.WriteLine("Please enter surname");
                surname = Console.ReadLine();
            } while (!NameSurnameChecker(surname));


            string email;
            do
            {
                Console.WriteLine("Please enter email");
                email = Console.ReadLine();
            } while (!EmailChecker(email));



            string password;
            do
            {
                Console.WriteLine("Please enter password");
                password = Console.ReadLine();
            } while (!PasswordChecker(password));



            bool Isadmin;
            char yesorno;
            do
            {
                Console.WriteLine("Are you superadmin?(y/n)");
                Isadmin = char.TryParse(Console.ReadLine(), out yesorno);
            } while (!Isadmin);
            if (yesorno.ToString().ToLower() == 'y'.ToString())
            {
                _userservices.Registration(name, surname, password, email, true);

            }
            else
            {
                _userservices.Registration(name, surname, password, email, false);
            }
        }


        public static void Login()
        {
            string email;
            string password;
            Console.WriteLine("Enter your email");
            email = Console.ReadLine();
            password = Console.ReadLine();
            _userservices.Login(email, password);
        }

        public static void FindUser()
        {
            string email;
            Console.WriteLine("Enter mail which your find user");
            email = Console.ReadLine();
            _userservices.FindUser(email);
        }

        public static void CheckBalance()
        {
            string email;
            Console.WriteLine("Enter email:");
            email = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            _bankservices.CheckBalance(email, password);

        }
        public static void TopUpBalance()
        {
            string email;
            Console.WriteLine("Enter email:");
            email = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            double newbalance;
            newbalance = Convert.ToDouble(Console.ReadLine());
            if (_bankservices.TopUpBalance(email, password, newbalance))
            {
                Console.WriteLine("returns to Bank menu");
                Thread.Sleep(3000);
            }

        }
        public static void UserList() 
        {
            string email;

            Console.WriteLine("Enter mail for show userlist");
            email = Console.ReadLine();
            string password = Console.ReadLine();
            _bankservices.UserList(email,password); 

        }
        public static void LogOut() 
        {
        
        }

        public static void BlockUser() 
        {
            string email;
            do
            {
                Console.WriteLine("Enter email which you want blocked");
                email = Console.ReadLine();

            } while (!_bankservices.BlockUser(email));
        }

        public static void ChangePassword() 
        {
            string email;
            string password;
            string newpassword;
            do
            {
                Console.WriteLine("Enter your email");
                email = Console.ReadLine();
                Console.WriteLine("Enter your password");
                password = Console.ReadLine();
                Console.WriteLine("Enter the your new password");
                newpassword = Console.ReadLine();
                PasswordChecker(newpassword);

            } while (!_bankservices.ChangePassword(email, password, newpassword));
           
        }

        static bool PasswordChecker(string password)
        {
            bool lower = false;
            bool upper = false;
            bool result = false;
            if (password.Length < 7)
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


        static bool NameSurnameChecker(string name) 
        {
            if (name.Length>3)
            {
                return true;
            }
            return false;
        }

         static bool EmailChecker(string email)
        {
            if (email.Contains('@'))
            {
                return true;
            }
            return false;
        }

    }
}
