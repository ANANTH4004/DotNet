using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Node
    {
       internal int data;
       internal Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    public class Dnode
    {
       internal int data;
       internal Dnode next;
       internal Dnode prev;
        public Dnode(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }
}
