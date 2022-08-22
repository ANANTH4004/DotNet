using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_22
{
    internal class Assignment6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======STACK==========");
            Stack s = new Stack();
            s.Push(23);
            s.Push(101);
            s.Push(34);
            s.Push(56);
            s.Push(99);
            Console.WriteLine("=====Before pop()");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========Methods ans Properties=========");
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Count);

            s.Pop();
            s.Pop();
            Console.WriteLine("=====After Pop()=====");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========Methods ans Properties=========");
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Count);
            if (s.Contains(101))
            {
                Console.WriteLine("Contains work");
            }
        }
    }
}
