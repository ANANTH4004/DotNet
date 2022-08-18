using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Digit : ");
            int d = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", d);
            Console.WriteLine("{0}{0}{0}{0}", d);
            Console.WriteLine("{0} {0} {0} {0}", d);
            Console.WriteLine("{0}{0}{0}{0}", d);

            Console.WriteLine("============8888888888=========");
            Console.WriteLine("Enter a Digit : ");
            int d1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", d1);
            Console.WriteLine("{0} {0}", d1);
            Console.WriteLine("{0} {0}", d1);
            Console.WriteLine("{0} {0}", d1);
            Console.WriteLine("{0} {0}", d1);
            Console.WriteLine("{0}{0}{0}", d1);


        }
    }
}
