using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    internal class Assignment4
    {
        static void Main(string[] args)
        {
            LinkedList<string> slist = new LinkedList<string>();
            slist.AddFirst("Anand");
            slist.AddAfter(slist.First,"varun");
            slist.AddFirst("Nithya");
            slist.AddFirst("");
            slist.AddFirst("Anand");
        }
    }
}
