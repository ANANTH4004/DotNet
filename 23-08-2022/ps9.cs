using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_08_2022
{
    internal class ps9
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Console.WriteLine("Enter EmployeeNo");
            emp1.empNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            emp1.empname = Console.ReadLine();
            Console.WriteLine("Enter Salary : ");
             emp1.sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter DeptNo:");
            emp1.deptNo = Convert.ToInt32(Console.ReadLine());
            emp1.Display1();
        }
    }
}
