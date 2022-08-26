using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class LinkedListDemo
    {
        static void Main(string[] args)
        {
            //LinkedListTypeInt();
            LinkedList<Student> slist = new LinkedList<Student>();


        }

        private static void LinkedListTypeInt()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(10);
            list.AddLast(100);
            list.AddAfter(list.First, 20);
            list.AddBefore(list.Last, 90);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Student
    {
        internal string name;
        internal int rollno;
        internal Student next;
        public Student(string name,int rollno)
        {
            this.name = name;
            this.rollno = rollno;
            next = null;
        }


    }
}
