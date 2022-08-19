using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_08_2022_Assignment
{
    internal class CharWithChar
    {
        static void Main(string[] args)
        {
            char a, b;
            Console.WriteLine("Enter a Char:");
            a = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Char:");
            b = char.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("{0} and {1} are Equal",a,b);
            }
            else
            {
                Console.WriteLine("{0} and {1} are Not Equal", a, b);
            }
        }
    }
}
