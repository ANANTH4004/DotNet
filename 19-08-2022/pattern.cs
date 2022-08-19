using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_08_2022_Assignment
{
    internal class pattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
