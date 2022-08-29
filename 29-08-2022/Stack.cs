using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Stack
    {
        static int max = 10;
         int top;
        public Stack()
        {
             top = -1;
        }
       internal int[] stack = new int[max];
       internal  bool isEmpty()
        {
            return (top < 0);
        }
       public void push(int data)
        {
            if (top >= max)
            {
                Console.WriteLine("No space on the stack");
                return;
            }
            else
            {
                stack[++top] = data;
            }
        }
        public void pop()
        {
            int value = 0;
            if (isEmpty())
            {
                Console.WriteLine("No Element in the Stack");
                return;
            }
            else
            {
               value =  stack[top--];
                //Console.WriteLine(value);
            }
        }
        public int Peek()
        {
            return stack[top];
        }
        public void Print()
        {
            for(int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
            Console.WriteLine("===============================");
        }
    }
}
