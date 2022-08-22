using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_22
{
    internal class Assignment8
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(1, "anand");
            h.Add(2, "varun");
            h.Add(3, "Nithya");
            h.Add(4, "Krish");
            h.Add(5, "Barath");

            string s = h[5].ToString();
            IDictionaryEnumerator ie = h.GetEnumerator();
            Console.WriteLine("========While (Before Remove)==========");
            while (ie.MoveNext())
            {
                Console.WriteLine("items {0}  {1}", ie.Key, ie.Value);
            }
            Console.WriteLine("========forEach(After Remove)==========");
            h.Remove(5);
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine($"key {item.Key} value {item.Value}");
            }
            Console.WriteLine("==========TOstring===========");
            Console.WriteLine(s); ;
        }
    }
}
