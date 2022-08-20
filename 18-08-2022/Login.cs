using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_08_2022
{
    internal class Login
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your frist Name :");
            string fn = Console.ReadLine();
            Console.WriteLine("Enter your last Name :");
            string ln = Console.ReadLine();
            if( !String.IsNullOrEmpty(fn) && !String.IsNullOrEmpty(ln))
            {
                Console.WriteLine("User id : {0}\nPassword : {1}\nWelcome to my App",fn,ln);
            }
            else
            {
                Console.WriteLine("Enter First Name and Last Name");
            }
        }
    }
}
