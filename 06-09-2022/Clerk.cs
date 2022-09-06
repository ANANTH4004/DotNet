using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Clerk : Person
    {
        public override void Work()
        {
            Console.WriteLine("Clerk is Working....");
        }
    }
}
