using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    internal class Assignment3cont
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();
           
            bool ans = true;
            do
            {
                Console.WriteLine("Enter a choice 1.Add  2.Remove");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Products p = new Products();
                        Console.WriteLine("Enter Product Id");
                        p.getPId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name:");
                        p.getName = Console.ReadLine();
                        list.Add(p);
                        break;
                    case 2:
                        Products p1 = new Products();
                        Console.WriteLine("Enter Product Id");
                        p1.getPId = Convert.ToInt32(Console.ReadLine());
                        //Console.WriteLine("Enter Product Name:");
                        //p1.getName = Console.ReadLine();
                        var item = list.Find(p2 => p2.getPId == 2);
                        list.Remove(item);

                        break;
                    default:
                        break;
                }
                Console.WriteLine("Do you want to continue: (Y/N)");
                string a = Console.ReadLine();
                if(a == "y" || a == "Y")
                {
                    ans = true;
                }
                else
                {
                    ans = false;
                }
            } while (ans);
            foreach (var item in list)
            {
                Console.WriteLine(item.getName + "  " + item.getPId);
            }
           
        }
    }
}
