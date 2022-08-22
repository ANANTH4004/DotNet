using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_22
{
    internal class Assignment2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for N:");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter 10 Elements");
            for (int i = 0; i <n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Value Stored in the Array");
            foreach (var item in arr)
            {
                Console.WriteLine($"{item} ");
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("Reversed output");
            foreach (var item in arr)
            {
                Console.WriteLine($"{item} ");
            }
        }
    }
}
