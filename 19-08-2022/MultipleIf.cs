using System;


namespace _19_08_2022_Assignment
{
    internal class MultipleIf
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a Number:");
            n = Int32.Parse(Console.ReadLine());
            if (n < 100)
            {
                if (n == 0)
                {
                    Console.WriteLine("The number is Zero.");
                }
                else if(n%2==0)
                {
                    if(n%10==0)
                        Console.WriteLine(" Even Number and Divide by 10");
                    Console.WriteLine(" Even Number");
                }
                else if (n % 2 == 1)
                {
                    Console.WriteLine("Odd Number");
                }
            }
            else
            {
                if (n % 10 == 0)
                {
                    Console.WriteLine(" large Number and  devide by 10");
                }
                else
                {
                    Console.WriteLine(" large Number.");
                }
            }
        }
    }
}
