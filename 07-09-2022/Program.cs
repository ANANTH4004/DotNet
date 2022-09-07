using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_09_2022Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product() { Pid = 202, Pname = "Lays" };
            Product p2 = new Product() { Pid = 404, Pname = "Bingo" };
            PrintProduct p = new PrintProduct(Product.Print);
            p(p1);
            p(p2);
            Employee e1 = new Employee() { joiningYear = 2018 };
            Employee e2 = new Employee() { joiningYear = 2001 };
            // Years y = e1.YearOfService;
            //int emp1 =  y(e1);
            // Console.WriteLine("years of service : " +emp1);
            //int emp2 =  y(e2);
            // Console.WriteLine("years of service : " + emp2);
            Years y = delegate (Employee e) { return DateTime.Now.Year - e.joiningYear; };
            int emp1 = y(e1);
            Console.WriteLine("years of service : " + emp1);
            int emp2 = y(e2);
            Console.WriteLine("years of service : " + emp2);

        }
    }
}
