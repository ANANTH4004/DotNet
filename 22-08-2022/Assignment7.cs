using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_22
{
    internal class Assignment7
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>(7);
            q.Enqueue(23);
            q.Enqueue(4004);
            q.Enqueue(5345);
            q.Enqueue(6576);
            q.Enqueue(254);
            
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("count : {0}", q.Count);
            Console.WriteLine("peek : {0}",q.Peek());

        }
    }
}
