using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCode
{
    public class UnderstandingString
    {
        
        public static void StringLength(string s)
        {
            int len = s.Length;
            Console.WriteLine(len);
        }
        public static void CompareString(string a , string b)
        {
            if(a == b)
            {
                Console.WriteLine("Strings are Equal");
            }
            else
            {
                Console.WriteLine("Strings are not Equal");
            }
        }
        
        public static void Strcpy(string s)
        {
            string s1;
            s1 = String.Copy(s);
            Console.WriteLine("Copied string "+ s1);
        }
        public static int FindIndex(string s , char c)
        {
            return s.IndexOf(c);
        }
        public static void SplitString()
        {
            string names = "Welcome to the World of C# Programming";
            string[] spl = { "#" };
            string[] result = names.Split(spl, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
        public static string ToUpperCase(string s)
        {
             return s.ToUpper();
        }
       
    }
}
