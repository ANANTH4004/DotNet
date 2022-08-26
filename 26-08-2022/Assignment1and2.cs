using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    internal class Assignment1and2
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[2];
            StudentStruct[] s = new StudentStruct[2];
            for(int i = 0; i < 2; i++)
            {
                students[i] = new Student();
                Console.WriteLine("Enter Roll Number:");
                students[i].getRollNo = Convert.ToInt32(Console.ReadLine());
                int roll = students[i].getRollNo;
                Console.WriteLine("Enter Student Name:");
                students[i].getName = Console.ReadLine();
                string name = students[i].getName;
                s[i].AcceptData(roll, name);
               
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("====== From Student Class========");
            Console.WriteLine("Student RollNumber and Name:");
            foreach (var item in students)
            {
                Console.WriteLine(item.getRollNo + "  "+ item.getName);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("====== From Student Structure========");
            Console.WriteLine("Student RollNumber and Name:");
            foreach (var item in s)
            {
                Console.WriteLine(item.name + "  " + item.rollNo);
            }
        }
    }
}
