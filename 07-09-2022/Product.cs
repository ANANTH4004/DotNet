using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_09_2022Assignment
{
    public delegate void PrintProduct(Product p);
    public class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }

        public static void Print(Product p)
        {
            Console.WriteLine("Product Id : " + p.Pid);
            Console.WriteLine("Product Name : " + p.Pname);
        }
    }
}
