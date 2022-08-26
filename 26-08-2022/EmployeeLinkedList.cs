using Hr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class EmployeeLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<Employee> elink = new LinkedList<Employee>();
            elink.AddFirst(new Employee { getEmpId = 1, getEmpName = "JACK", getCity = "Chennai" });
            elink.AddAfter(elink.First,new Employee { getEmpId = 2, getEmpName = "anand", getCity = "Chennai" });
            elink.AddAfter(elink.First.Next,new Employee { getEmpId = 3, getEmpName = "JILL", getCity = "Bangalore" });
            elink.AddBefore(elink.Last.Previous,new Employee { getEmpId = 4, getEmpName = "HARI", getCity = "Pune" });
            elink.AddBefore(elink.Last,new Employee { getEmpId = 5, getEmpName = "PARI", getCity = "Hyderabed" });
            elink.AddLast(new Employee { getEmpId = 6, getEmpName = "JIM", getCity = "Chennai" });
            foreach (var item in elink)
            {
                Console.WriteLine(item.getEmpId);
                Console.WriteLine(item.getEmpName);
                Console.WriteLine(item.getCity);
            }
        }
    }
}
