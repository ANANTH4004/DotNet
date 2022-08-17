using System;

namespace Day2
{
    internal class String_DateTime_17_08_22
    {
        static void Main(string[] args)
        {
            //string name;
            //int age;
            //DateTime DOB;
            //Console.WriteLine("Enter your name");
            //name = Console.ReadLine();
            //Console.WriteLine("Enter your Date of Birth");
            //DOB = Convert.ToDateTime(Console.ReadLine());
            //age = Calculation(DOB);
            //Console.WriteLine("Name : "+name +"\nDate of Birth : "+ DOB + "\nAge : "+ age);
            ArrayDemo demo1 = new ArrayDemo();
            demo1.Loop1();
            demo1.Sort1();
            //demo1.Loop1();
            

        }
        static int Calculation(DateTime date)
        {
            int bYear = date.Year;
            int cYear = DateTime.Now.Year;
            int age = cYear - bYear;
            return age;
        }
    }
}
