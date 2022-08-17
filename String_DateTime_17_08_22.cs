using System;

namespace Day2
{
    internal class String_DateTime
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            DateTime DOB;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Date of Birth");
            DOB = Convert.ToDateTime(Console.ReadLine());
            age = Calculation(DOB);
            Console.WriteLine("Name : "+name +"\n Date of Birth : "+ DOB + "\n Age : "+ age);
            

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
