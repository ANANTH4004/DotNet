using Hr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class ObjectListDemo
    {
        static void Main(string[] args)
        {
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee { getEmpId = 1, getEmpName = "anand", getCity = "Chennai"});
            elist[0].CalculateSalary(40000);
            Employee emp2 = new Employee();
            emp2.CalculateSalary(20000);
            emp2.getCity = "Pune";
            emp2.getEmpId = 2;
            emp2.getEmpName = "varun";
            elist.Add(emp2);
            elist.Sort();
            foreach (var item in elist)
            {
                Console.WriteLine(item.getEmpId);
                Console.WriteLine(item.getEmpName);
                Console.WriteLine(item.getCity);
                Console.WriteLine(item.GrossSalary);
                Console.WriteLine(item.getB);
                Console.WriteLine("=========================");
            }
        }
    }
}
