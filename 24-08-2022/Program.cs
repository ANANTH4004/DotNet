using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReusableCode;
namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== from sample class=======");
            SampleClass.PrintString();
            Console.WriteLine("=======PS1- String Comparision and String Length=====");
            Console.WriteLine("Enter a String");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter a String");
            string s2 = Console.ReadLine();
            UnderstandingString.StringLength(s1);
            UnderstandingString.CompareString(s1, s2);
            Console.WriteLine("====== PS2- String Copy Method==========");
            UnderstandingString.Strcpy(s1);
            Console.WriteLine("========== PS3- Index of String========== ");
            Console.WriteLine("Type  something");
            string s3 = Console.ReadLine();
            Console.WriteLine("Enter a char");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0} is in {1} position", c, UnderstandingString.FindIndex(s3, c));
            Console.WriteLine( "======= PS4 - Split string ==========");
            UnderstandingString.SplitString();
            Console.WriteLine("======== PS5 -  UpperCase=====");
            Console.WriteLine("Enter a String");
            string s4 = Console.ReadLine();
            Console.WriteLine(UnderstandingString.ToUpperCase(s4));
            Console.WriteLine("=========== PS6 - File Creation==========");
            FileCreateDemo.CreateFile("D:\\c#\\Myapp", "FirstFile.txt");



        }
    }
}
