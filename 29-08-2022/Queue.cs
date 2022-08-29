using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Queue
    {
        internal int front, rear, capacity;
        internal int[] ele;
        public Queue(int capacity)
        {
            ele = new int[capacity];
            front = 0;
            rear = 0;
            this.capacity = capacity;
        }
        public void Enqueue(int data)
        {
            if(rear == capacity)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else
            {
                ele[rear++] = data;
            }

        }
        public int Dequeue()
        {
            if(front == rear)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("The deleted Element is : {0}", ele[front]);
                return ele[front++];
            }
        }
        public void Print()
        {
            if(front == rear)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                for (int i = front; i < rear; i++)
                {
                    Console.WriteLine(ele[i]);
                }
                Console.WriteLine("==========================================");
            }
        }
    }
}
