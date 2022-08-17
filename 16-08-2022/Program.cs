using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 20,ch=0;
            string symbol = ""; 
            int k = i + j;
            Console.WriteLine(k);
            Console.WriteLine("Menu 1.Add 2.Subtract 3.Multiplication 4.Division 5.Exit");
            ch = Convert.ToInt32(Console.ReadLine());
            if(ch !=5)
            {
                Console.WriteLine("Enter the value For I");
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value For J");
                j = Convert.ToInt32(Console.ReadLine());
            }
            switch (ch)
            {
                case 1:
                    k = i + j;
                    symbol = "+";
                    break;
                case 2:
                    k = i - j;
                    symbol = "-";
                    break;
                case 3:
                    k = i * j;
                    symbol = "*";
                    break;
                case 4:
                    k = i / j;
                    symbol = "/";
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Result of {0} {1} {2} = {3}", i, symbol, j, k);
            Console.Read();
        }
    }
}
