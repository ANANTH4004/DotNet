using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class StringSort
    {
        static void Main(string[] args)
        {
            List<string> sl = new List<string>() { "1Anand", "snithya", "2varun" , "Anand" , "varun" , "xnithya"};
            Print(sl);
            Console.WriteLine("======== Sorted List=======");
            sl.Sort((a,b)=> a[a.Length-1].CompareTo(b[b.Length-1]));
            Print(sl);
        }
        static void Print(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=============================");
        }
    }
}
