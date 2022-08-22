using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_22
{
    internal class Assignment3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a value for N:");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter 10 Elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sum of all the Elements in the Array : {0}",arr.Sum());
            
        }
    }
}
