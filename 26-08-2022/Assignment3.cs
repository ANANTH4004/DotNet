using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    internal class Assignment3
    {
        static void Main(string[] args)
        {
           
            List<Products> plist = new List<Products>();
            Console.WriteLine("Enter No of Products:");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                Products p = new Products();
                Console.WriteLine("Enter Product Id:");
                p.getPId = Int32.Parse( Console.ReadLine());
                Console.WriteLine("Enter Product Name:");
                p.getName = Console.ReadLine();
                plist.Add(p);

            }
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in plist)
            {
                Console.WriteLine(item.getPId + "  "+ item.getName);
            }
            Console.WriteLine("1.add   2.Remove");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Product Id:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Product Name:");
                    string name = Console.ReadLine();
                    add(plist, id, name);
                    break;
                case 2:
                    Console.WriteLine("Enter Product Id:");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Enter Product Name:");
                    //string name1 = Console.ReadLine();
                    Products p = new Products();
                    p.getPId = id1;
                    //p.getName = name1;
                    remove(ref plist,p);
                    break;
                default:
                    break;
            }
            Console.WriteLine("==========After add or remove ===============");
            foreach (var item in plist)
            {
                Console.WriteLine(item.getPId + "  " + item.getName);
            }
        }
        public static void add(List<Products> plist,int id, string name)
        {
            Products p = new Products();
            p.getPId = id;
            p.getName = name;
            plist.Add(p);
        }
        public static void remove( ref List<Products>plist ,Products p1) {
            //Products p2 = new Products();
            //p2.getPId = id;
            //p2.getName = name;
            //Console.WriteLine(plist.Contains(new Products() { getPId = id, getName = name }));
            //plist.Remove(new Products() { getPId = id, getName = name });
            var item = plist.Find(l => l.getPId == p1.getPId);
            plist.Remove(item);

           
            Console.WriteLine(plist.Count);
        }
    }
}
