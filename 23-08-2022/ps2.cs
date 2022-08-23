using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_08_2022
{
    internal class ps2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b :");
            int j = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("The sum is {0}", add(i, j));
        }
        static int add(int i, int j)
        {
            return i + j;
        }
    }
}
