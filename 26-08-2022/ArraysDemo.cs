using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class ArraysDemo
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];//Multi Dimentional or Rectangular Array
            a[0,0] = 10;
            a[1, 1] = 20;
            a[2, 2] = 30;
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j <a.GetLength(1); j++)
                {
                    Console.Write(" {0} ", a[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("==========================================================================");
            try
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        Console.Write(" {0} ", a[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"Array Length {a.Length}");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
