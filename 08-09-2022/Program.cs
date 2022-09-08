using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee() { EmpId = 101, EmpName = "Anand", DeptNO = 10, Sal = 40000  };
            Employee e2 = new Employee() { EmpId = 201, EmpName = "Sam", DeptNO = 10, Sal = 40000 , mrg = "Anand"};
            Employee e3 = new Employee() { EmpId = 301, EmpName = "Varun", DeptNO = 20, Sal = 40000 , mrg = "Nithya`" };
            Employee e4 = new Employee() { EmpId = 401, EmpName = "Nithya", DeptNO = 20, Sal = 40000 , mrg = "sk" };
            Employee e5 = new Employee() { EmpId = 501, EmpName = "Sk", DeptNO = 30, Sal = 40000 };

            Department d1 = new Department();
            
            d1.Operation(e1);
            d1.Operation(e3);
            d1.Operation(e2);
            //d1.ShowList();
            d1.Operation(e4);
            d1.Operation(e5);
           // d1.Reporting(d1.EmpList);
            PrintList p = new PrintList(d1.PrintList);
            //p.Invoke(d1.EmpList);
            //d1.RemoveByID(401);
            //d1.RemoveByID(101);
            //d1.ShowList();


            //Department d2 = new Department();
            //d2.Operation(e3);
            //d2.Operation(e4);
            //d2.ShowList();


            Predicate<Tuple<int, string>> Check = (c1) =>
            {
                if (c1.Item2 == "password")
                {
                    if (d1.EmpList.Count(C => C.EmpId == c1.Item1) > 0)
                    {
                        Console.WriteLine("User Found ...:)");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("user Not found.....");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Password Incorrect...");
                    return false;
                }


            };

            var data = Tuple.Create<int, string>(101, "password");
            Check(data);
            
        }
    }
}
