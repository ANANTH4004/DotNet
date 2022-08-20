using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_08_2022
{
    internal class Age
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you Age : ");
            int i = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You look older than {0}",i);
        }
    }
}
