using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_22
{
    internal class Assignment14
    {
        static void Main(string[] args)
        {

            int[] s = { 1, 2, 3 };
            int m = s.Length;
            Console.WriteLine("Total combination {0}",Calculate(s, m, 10));

        }
        static int Calculate(int[] arr, int size, int total)
        {

            if (total == 0)
                return 1;


            if (total < 0)
                return 0;


            if (size <= 0)
                return 0;


            return Calculate(arr, size - 1, total) +
                Calculate(arr, size, total - arr[size - 1]);
        }
    }
}
