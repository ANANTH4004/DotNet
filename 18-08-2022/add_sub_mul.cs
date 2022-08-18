using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_sub_mul_div
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j,i1,i2,i3,i4;
            Console.WriteLine("Input First Number  : ");
            i = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Second Number : ");
            j = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}",i,j,(i+j));
            Console.WriteLine("{0} - {1} = {2}",i,j,(i-j));
            Console.WriteLine("{0} * {1} = {2}",i,j,(i*j));
            Console.WriteLine("{0} / {1} = {2}",i,j,(i/j));
            Console.WriteLine("{0} % {1} = {2}",i,j,(i%j));
            Console.WriteLine("================333333======================");
            Console.WriteLine("Input First Number  : ");
            i1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Second Number  : ");
            i2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Third Number  : ");
            i3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Fourth Number  : ");
            i4 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("avg {0} / {1} = {2}",(i1+i2+i3+i4),4, (i1 + i2 + i3 + i4)/4);
            Console.WriteLine("===============444444=======================");
            Console.WriteLine("Input First Number  : ");
           int j1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Second Number  : ");
           int j2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input Third Number  : ");
            int j3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("(x+y).z is {0} \n(x.y)+(y.z) is {1}",(j1+j2)*j3, (j1*j2)+(j2*j3));
            Console.WriteLine("=================555555=====================");

            Console.WriteLine("Enter the Age");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("you look older than {0}",age);



        }
    }
}
