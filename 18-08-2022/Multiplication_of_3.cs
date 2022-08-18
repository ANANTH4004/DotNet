using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_of_3_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            Console.WriteLine("Input First Number to Multiply : ");
            i = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input First Number to Multiply : ");
            j = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input First Number to Multiply : ");
            k = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} x {1} x {2}  = {3}",i,j,k,(i*j*k));

        }
    }
}
