using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_08_2022_Assignment
{
    internal class findMaxOf3
    {
        static void Main(string[] args)
        {

            int i, j, k;
            Console.WriteLine("Enter First Number :");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            k = Convert.ToInt32(Console.ReadLine());
            if (i > j)
            {
                if (i > k)
                {
                    Console.WriteLine("{0} is greater than {1} and {2}", i, j,k);
                }
                else
                {
                    Console.WriteLine("{0} is greater than {1} and {2}", k, j, i);
                }
                
            }
            else if(j>k)
            {
                Console.WriteLine("{0} is greater than {1} and {2}", j, k, i);
            }
            else
            {
                Console.WriteLine("{0} is greater than {1} and {2}", k, j, i);
            }
        }
    }
}
