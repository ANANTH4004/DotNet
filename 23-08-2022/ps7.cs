using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_08_2022
{
    internal class ps7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number :");
            int j = Convert.ToInt32(Console.ReadLine());

            div(i, j);
           
        }
        static void div(int i , int j)
        {
            int k =0;
            try {
                 k = i / j;
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine("Enter a Non Zero Number");
                Console.WriteLine(ex.StackTrace + "\n");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Result : {0}",k);
            }
           
            
        }
    }
}
