using System;

namespace Day2
{
    internal class ArrayDemo
    {
        string[] names = { "Anand", "Varun", "Nithya", "Bindhu" };
        public void Loop1() {
            for (int i = 0; i < names.Length;i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        public void Sort1()
        {

            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
        }
    }
}
