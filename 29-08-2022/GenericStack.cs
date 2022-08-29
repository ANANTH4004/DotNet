using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Stack<T>
    {
        static int max = 10;
        int top;
        public Stack()
        {
            top = -1;
        }
        internal T[] stack = new T[max];
        internal bool isEmpty()
        {
            return (top < 0);
        }
        public void push(T data)
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
            T value;
            if (isEmpty())
            {
                Console.WriteLine("No Element in the Stack");
                return;
            }
            else
            {
                value = stack[top--];
                //Console.WriteLine(value);
            }
        }
        public T Peek()
        {
            return stack[top];
        }
        public void Print()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
            Console.WriteLine("===============================");
        }
    }
}
