using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_08_2022_Assignment
{
    internal class Biggest
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            Console.WriteLine("Enter First Number :");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            j = Convert.ToInt32(Console.ReadLine());
            if (i > j)
            {
                Console.WriteLine("Biggest Number is {0}",i);
            }
            else
            {
                Console.WriteLine("Biggest Number is {0}", j);
            }
        }
    }
}
