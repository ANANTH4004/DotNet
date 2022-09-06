using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee : Person
    {
        public override void Work()
        {
            Console.WriteLine("Employee is working...");
        }
    }
}
