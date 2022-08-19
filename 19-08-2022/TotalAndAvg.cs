using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_08_2022_Assignment
{
    internal class TotalAndAvg
    {
        static void Main(string[] args)
        {
            int i, j, k;
            string s1="Maths", s2 = "Physics", s3= "Zoology";
            Console.WriteLine("Enter Maths Marks:");
            i = Int32.Parse(Console.ReadLine());
            check(i, s1);
            Console.WriteLine("Enter Physics Marks:");
            j = Int32.Parse(Console.ReadLine());
            check(j, s2);
            Console.WriteLine("Enter Zoology Marks:");
            k = Int32.Parse(Console.ReadLine());
            check(k, s3);
            int total, avg;
            total = i + k + k;
            avg = total / 3;
            if(i>=35 && j>=35 && k >= 35 && avg <40)
            {
                Console.WriteLine("Over All Result: THIRD" );
            }
            else if (i >= 35 && j >= 35 && k >= 35 && avg>=40 && avg <=60)
            {
                Console.WriteLine("Over All Result: Second");
            }
            else if (i >= 35 && j >= 35 && k >= 35 && avg >=60 && avg <= 100)
            {
                Console.WriteLine("Over All Result: First");
            }
            else
            {
                Console.WriteLine("Over All Result: FAIL");
            }

        }

        private static void check(int avg , string s)
        {
            if (avg < 35)
            {
                Console.WriteLine("{0} : FAIL",s);
            }
            else if (avg >= 35 && avg <= 45)
            {
                Console.WriteLine("{0} : THIRD",s);
            }
            else if (avg >= 55 && avg <60)
            {
                Console.WriteLine("{0} : SECOND", s);
            }
            else if (avg >= 60 && avg<=100)
            {
                Console.WriteLine("{0} : FIRST",s);
            }
            else
            {
                Console.WriteLine("Invalid Marks");
            }
        }
    }
}
