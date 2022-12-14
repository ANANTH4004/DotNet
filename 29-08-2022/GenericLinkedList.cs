using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Node<T>
    {
        internal Node<T> next;
        public T data;
        public Node(T data)
        {
            this.data = data;
        }
    }

    public class Slink<T>
    {
        internal Node<T> head;


        internal void InsertFront(Slink<T> link, T data)
        {
            Node<T> newnode = new Node<T>(data);
            newnode.next = link.head;
            link.head = newnode;

        }

        internal void InsertLast(Slink<T> link, T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (link.head == null)
            {
                link.head = newnode;
                return;
            }
            Node<T> last = GetLastNode(link);
            last.next = newnode;

        }

        private Node<T> GetLastNode(Slink<T> link)
        {
            Node<T> last = link.head;
            while (last != null)
            {
                last = last.next;
            }
            return last;
        }

        internal void InsertAfter(Node<T> prevNode, T data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("This cannot be null");
                return;

            }
            Node<T> newnode = new Node<T>(data);
            newnode.next = prevNode.next;
            prevNode.next = newnode;
        }

        internal void DeleteByFindingData(Slink<T> link, T key)
        {

            Node<T> temp = link.head;
            Node<T> prev = null;
            if (temp != null && temp.data.Equals( key))
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
        public void Print(Slink<T> link)
        {
            Node<T> temp = link.head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine("================================");
        }
    }
    /// <summary>
    /// This is for the doubly linked list node with generics (NODE CLASS)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Dnode<T>
    {
        public T data;
        internal Dnode<T> next;
        internal Dnode<T> prev;
        public Dnode(T data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;

        }
    }
    /// <summary>
    /// This class is for Doubly Linked List Implementation - generics
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Dlink<T>
    {
        internal Dnode<T> head;
        internal Dnode<T> tail;
        public void InsertFront(Dlink<T> link, T data)
        {
            Dnode<T> newnode = new Dnode<T>(data);
            newnode.next = link.head;
            link.head = newnode;
            newnode.prev = null;
            if (link.head != null)
            {
                link.head.prev = newnode;
            }
            link.head = newnode;
        }
        public Dnode<T> GetLast(Dlink<T> link)
        {
            Dnode<T> last = link.head;
            while (last.next != null)
            {
                last = last.next;
            }
            return last;
        }
        public void InsertLast(Dlink<T> link, T data)
        {
            Dnode<T> newnode = new Dnode<T>(data);
            if (link.head == null)
            {

                link.head = newnode;
                link.tail = newnode;
                return;
            }
            Dnode<T> lastNode = GetLast(link);
            lastNode.next = newnode;
            newnode.prev = lastNode;
        }
        public void DeleteKey(Dlink<T> link, T key)
        {
            Dnode<T> temp = link.head;
            if (temp != null && temp.data.Equals( key))
            {
                link.head = temp.next;
                link.head.prev = null;
                return;
            }
            while (temp != null && !temp.data.Equals(key))
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }
        public void Print(Dlink<T> link)
        {
            Dnode<T> temp = link.head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine("=================================================");
        }

    }
}
