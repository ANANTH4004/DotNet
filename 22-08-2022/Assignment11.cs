using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_22
{
    internal class Assignment11
    {
        static void Main(string[] args)
        {
            SortedList<int, string> s = new SortedList<int, string>();
            s.Add(23, "anand");
            s.Add(45, "varun");
            s.Add(56, "nithya");
            s.Add(54, "sam");
            s.Add(433, "cami");
            s.Add(65, "jaanu");
            foreach (var item in s)
            {
                Console.WriteLine($"key : {item.Key} value : {item.Value}");
            }
        }
    }
}
