using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_08_2022
{
    internal class PositiveCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number:");
            int i = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number:");
            int j = Int32.Parse(Console.ReadLine());
            if( i>=0 && j>=0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
