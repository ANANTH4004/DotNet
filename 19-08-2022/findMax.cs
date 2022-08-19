using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_08_2022
{
    internal class findMax
    {
        static void Main(string[] args)
        {
            int i=0,j=0;
            Console.WriteLine("Enter First Number :");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            j = Convert.ToInt32(Console.ReadLine());
            if (i > j)
            {
                Console.WriteLine("{o} is greater than {1}",i,j);
            }
            else
            {
                Console.WriteLine("{o} is greater than {1}", j, i);
            }

        }
    }
}
