using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace from9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Amount of Celcious :");
            int c = Int32.Parse(Console.ReadLine());
            Console.WriteLine("kelvin = {0}", c+273);
            Console.WriteLine("Fahrenheit = {0}", (c*1.8)+32);
            Console.WriteLine("==================================");
            Console.WriteLine("Input first Integer :");
            int i1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input second Integer :");
            int i2 = Int32.Parse(Console.ReadLine());
            if(i1<0 || i2 < 0)
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
