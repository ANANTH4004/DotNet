using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_22
{
    internal class Assignment9
    {
        static void Main(string[] args)
        {
            List<float> f = new List<float>() { 2.3f,34.43f , 56.64f,99.99f,23.43f};
            Console.WriteLine("Original List");
            foreach (var item in f)
            {
                Console.WriteLine(item);
            }
            f.Sort();
            Console.WriteLine("Sorted List");
            foreach (var item in f)
            {
                Console.WriteLine(item);
            }
            f.Reverse();
            Console.WriteLine("Reversed List");
            foreach (var item in f)
            {
                Console.WriteLine(item);
            }
        }
    }
}
