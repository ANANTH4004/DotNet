using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_22
{
    internal class Assignment4
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList(5);
            arr.Add(34);
            arr.Add(43);
            arr.Add(45);
            arr.Add(53);
            arr.Add(76);
            Console.WriteLine("Count {0}",arr.Count);
            arr.Remove(45);
            Console.WriteLine("Count After Remove {0}",arr.Count);
        }
    }
}
