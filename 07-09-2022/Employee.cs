using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_09_2022Assignment
{
    public delegate int Years(Employee e);
    public class Employee
    {
        public int joiningYear { get; set; }

        //public int YearOfService(Employee e)
        //{
        //    return  (DateTime.Now.Year)- e.joiningYear ;
        //}
    }
}
