using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_08_2022_Assignment
{
    internal class StringWithString
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("Enter a String:");
            a = Console.ReadLine();
            Console.WriteLine("Enter a String:");
            b = Console.ReadLine();
            if (a == b)
            {
                Console.WriteLine("{0} and {1} are Equal", a, b);
            }
            else
            {
                Console.WriteLine("{0} and {1} are Not Equal", a, b);
            }
        }
    }
}
