using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_08_2022_Assignment
{
    internal class OddNumbers
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            Console.WriteLine("Enter the value for N:");
            n = Int32.Parse(Console.ReadLine());
            for(int i = 0; i <=n; i++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("Sum : {0}",sum);
            sum = 0;
            for (int i = 1; i <n; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("Sum : {0}", sum);
        }
    }
}
