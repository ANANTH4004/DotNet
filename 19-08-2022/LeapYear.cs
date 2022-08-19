using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_08_2022_Assignment
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int year = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", year);
            }
            else Console.WriteLine("{0} is not a Leap Year.", year);
            
        }
    }
}
