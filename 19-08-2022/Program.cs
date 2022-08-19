using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_08_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //changes form the new branch 
            int i;
            Console.WriteLine("Enter the value for I : ");
            i = Convert.ToInt32(Console.ReadLine());
            if(i != 0)
            {
                if( i> 0 && i < 10)
                {
                    Console.WriteLine("I is greater than 0 and less then 10");
                }
                else if (i==10)
                {
                    Console.WriteLine("i equals to 10");
                }
                else
                {
                    Console.WriteLine("Enter the number between 1 and 10");
                }
            }
            else
            {
                Console.WriteLine("Enter the number between 1 and 10");
            }
        }
    }
}
