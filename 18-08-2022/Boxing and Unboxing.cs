using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_08_2022
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            float f1 = 12.344f;
            double d1 = f1;
             f1 = (float)d1;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            Console.WriteLine("====================================");

            int i1 = 123;
            string s1 = i1.ToString();
            i1 = Convert.ToInt32(s1);
            Console.WriteLine(s1);
            Console.WriteLine(i1);
            Console.WriteLine("====================================");
            string s = "Anand";
            object o = s;
            s = (string)o;
            Console.WriteLine(s);
            Console.WriteLine(o);
            Console.WriteLine("====================================");
            int i2 = 90;
            object obj = new object();
            obj = 90;
            Console.WriteLine(obj.Equals(i2));
            Console.WriteLine("====================================");

            Console.WriteLine(s.ToString());

         



    }
    }
}
