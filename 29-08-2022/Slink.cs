using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    
    public class Slink
    {
        Node head;


       internal void InsertFront(Slink link, int data)
        {
            Node newnode = new Node(data);
            newnode.next = link.head;
            link.head = newnode;

        }

       internal void InsertLast(Slink link, int data)
        {
            Node node = new Node(data);
            if (link.head == null)
            {
                link.head = node;
                return;
            }
            Node newnode = GetLastNode(link);
            newnode.next = node;

        }

        private Node GetLastNode(Slink link)
        {
            Node last = link.head;
            while (last != null)
            {
                last = last.next;
            }
            return last;
        }

       internal void InsertAfter(Node prevNode, int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("This cannot be null");
                return;

            }
            Node newnode = new Node(data);
            newnode.next = prevNode.next;
            prevNode.next = newnode;
        }

        internal void DeleteByFindingData(Slink link, int data)
        {

            Node temp = link.head;
            Node prev = null;
            if (temp != null && temp.data == data)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }
        public void Print(Slink link)
        {
           Node temp = link.head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine("================================");
        }
    }






    public class Dlink
    {
       internal Dnode head;
       internal Dnode tail;
        public void InsertFront(Dlink link , int data)
        {
            Dnode newnode = new Dnode(data);
            newnode.next = link.head;
            link.head = newnode;
            newnode.prev = null;
            if(link.head != null)
            {
                link.head.prev = newnode;
            }
            link.head = newnode;     
        }
        public Dnode GetLast(Dlink link)
        {
            Dnode last = link.head;
            while (last.next != null)
            {
                last = last.next;
            }
            return last;
        }
        public void InsertLast(Dlink link , int data)
        {
            Dnode newnode = new Dnode(data);
            if(link.head == null)
            {
                
                link.head = newnode;
                link.tail = newnode;
                return;
            }
            Dnode lastNode = GetLast(link);
            lastNode.next = newnode;
            newnode.prev = lastNode;
        }
        public void DeleteKey(Dlink link,int key)
        {
            Dnode temp = link.head;
            if (temp != null && temp.data == key)
            {
                link.head = temp.next;
                link.head.prev = null;
                return;
            }
            while (temp != null && temp.data != key)
            {
                temp = temp.next;
            }
            if(temp == null)
            {
                return;
            }
            if(temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if(temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }
        public void Print(Dlink link)
        {
            Dnode temp = link.head;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

    }
}
