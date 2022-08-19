using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_08_2022_Assignment
{
    internal class Range
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int sum = 0;
            Console.WriteLine("Enter Starting Range :");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending Range :");
            j = Convert.ToInt32(Console.ReadLine());
            for(int k = i; k <= j; k++)
            {
                if (k % 9 == 0)
                {
                    Console.Write("{0} ",k);
                    sum += k;
                }
            }
           
            Console.WriteLine("\nSum: {0} ", sum);

        }
    }
}
