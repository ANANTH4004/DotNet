using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parse_convert_null
{
    internal class CallBy
    {
        static void Main(string[] args)
        {
            //StringExample();
            Console.WriteLine("Inuput the First Number : ");
           int  i = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number : ");
           int  j = Int32.Parse(Console.ReadLine());
            Console.WriteLine("==============================================");
            CallByValue(i, j);
            CallByRef(ref i, ref j);


        }
        
        private static void CallByValue(int i , int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("After Swapping i : " + i);
            Console.WriteLine("After Swapping j : " + j);
            Console.WriteLine("==============================================");

        }
        private static void CallByRef( ref int i, ref int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine("After Swapping (ref) i : " + i);
            Console.WriteLine("After Swapping (ref) j : " + j);
            Console.WriteLine("==============================================");

        }

        private static void StringExample()
        {
            string name = String.Empty;
            Console.WriteLine("Enter Your Name : ");
            name = Console.ReadLine();
            if (!String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Your Name Is : " + name);
            }
            else
            {
                Console.WriteLine("You didn't Enter your Name. ");
            }
        }
    }
}
