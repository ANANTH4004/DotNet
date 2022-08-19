using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_08_2022_Assignment
{
    internal class ReverseNumber
    {
        static void Main(string[] args)
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reversed Number: " + reverse);
            Console.Write("Enter a String: ");
            String s = Console.ReadLine();
            Console.WriteLine(s.ToCharArray().Reverse().ToArray());
        }
    }
}
