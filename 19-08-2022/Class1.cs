using System;


namespace _19_08_2022
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("From second class");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Loop {0}",i);
            }
            string[] name = { "anand" , "varun" , "karthi", "sam" };
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
}
