using Hr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class ObjectArrayDemo
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[2];
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Employee();
                Console.WriteLine("Enter Empid");
                emp[i].getEmpId= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Empname");
                emp[i].getEmpName= Console.ReadLine();
                Console.WriteLine("Enter City");
                emp[i].getCity = Console.ReadLine();
                Console.WriteLine("enter basic salary");
                int bs = Convert.ToInt32(Console.ReadLine());
                emp[i].CalculateSalary(bs);
            }
            Console.WriteLine("----------------------");

            foreach (var item in emp)
            {
                Console.WriteLine("Following are the details");
                Console.WriteLine(item.getEmpId);
                Console.WriteLine(item.getEmpName);
                Console.WriteLine(item.getCity);
                Console.WriteLine(item.GrossSalary);

            }
        }
    }
}
