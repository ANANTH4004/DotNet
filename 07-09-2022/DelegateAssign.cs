using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_09_2022Assignment
{
   public  delegate int FindLength(string s);

    public delegate void Greet(string s);

    public delegate int Math(int n1, int n2);
    public delegate string Concat(string s1, string s2);
    internal class DelegateAssign
    {
        public int Add(int a, int b)
        {
            Console.WriteLine($"Addition : {a+b}");
            return a + b;
        }
        public int Sub(int a, int b)
        {
            Console.WriteLine($"Subtraction : {a - b}");
            return a - b;
        }
        public int Mul(int a, int b)
        {
            Console.WriteLine($"Multiplication : {a * b}");
            return a * b;
        }
        public static void Greeting(string s)
        {
            Console.WriteLine("welcome " + s);
        }
        public static int Length(string s)
        {
            Console.WriteLine( $"The length of {s} is {s.Length}" );
            return s.Length;
        } 
        static void Main(string[] args)
        {
            FindLength f = new FindLength(Length);
            f("anand");
           FindLength f1 = Length;
           int len =  f1("vaurnKrishnan");
            Console.WriteLine(len);
            Greet g = Greeting;
            g("Nithya");
            DelegateAssign d = new DelegateAssign();
            Math[] m1 = new Math[3] { d.Add, d.Sub, d.Mul };
            Math m = (Math)MulticastDelegate.Combine(m1);
            m(10, 20);

            Concat c = delegate (string s1, string s2) { return s1 + s2; };
            Console.WriteLine(c("anand", "balamurugan")); 
        }
    }
}
