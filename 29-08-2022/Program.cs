using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region linkdemo
            //Dlink d = new Dlink();
            //d.InsertFront(d, 100);
            //d.InsertLast(d, 200);
            //d.InsertLast(d, 300);
            //d.InsertLast(d, 400);
            //d.InsertLast(d, 500);
            //d.Print(d);
            //Console.WriteLine("===================");
            //d.DeleteKey(d, 500);
            //d.Print(d);
            //Console.WriteLine("===================");
            //d.DeleteKey(d, 100);
            //d.Print(d);
            //Console.WriteLine("===================");
            #endregion

            #region stackdemo
            //Stack s = new Stack();
            //s.push(100);
            //s.push(200);
            //s.push(300);
            //s.push(400);
            //s.push(500);
            //s.Print();
            //s.pop();
            //s.pop();
            //s.pop();
            //s.Print();
            //Console.WriteLine(s.Peek());  
            #endregion

            #region GenericDemo
            //GenericDemo<string> stringdata = new GenericDemo<string>();
            //stringdata.AddOrEdit(0, "Hello");
            //string printdata = stringdata.ReturnData(0);
            //Console.WriteLine(printdata);
            //Console.WriteLine("-------------------");
            //stringdata.AddOrEdit(0, "Welcome");

            //stringdata.ShowData(0);
            #endregion

            #region Doubly linkedList demo
            //Dlink<string> dls = new Dlink<string>();
            //dls.InsertFront(dls, "anand");
            //dls.InsertLast(dls, "varun");
            //dls.InsertLast(dls, "nithya");
            //dls.InsertLast(dls, "sk");
            //dls.Print(dls);
            //dls.InsertLast(dls, "sam");
            //dls.DeleteKey(dls, "varun");
            //dls.Print(dls);
            //Dlink<int> dli = new Dlink<int>();
            //dli.InsertLast(dli, 100);
            //dli.InsertLast(dli, 200);
            //dli.InsertLast(dli, 300);
            //dli.InsertLast(dli, 400);
            //dli.InsertLast(dli, 500);
            //dli.Print(dli); 
            #endregion

            #region Generic stack demo
            //Stack<string> ss = new Stack<string>();
            //ss.push("anand");
            //ss.push("varun");
            //ss.push("Nithya");
            //ss.push("sk");
            //ss.push("sam");
            //ss.Print();
            //ss.pop();
            //ss.Print();
            //Console.WriteLine(ss.Peek());
            //Console.WriteLine("===============================");
            //Stack<object> os = new Stack<object>();
            //os.push("anand");
            //os.push(1003);
            //os.push(34.532);
            //os.push('s');
            //os.push("sk");
            //os.Print();
            //Console.WriteLine(os.Peek()); 
            #endregion

            #region Queue using Array Demo
            //Queue q = new Queue(10);
            //q.Enqueue(100);
            //q.Enqueue(200);
            //q.Enqueue(300);
            //q.Enqueue(400);
            //q.Enqueue(500);
            //q.Print();
            //q.Dequeue();
            //q.Dequeue();
            //q.Print();
            #endregion

            #region Singly linked list demo
            //Slink s = new Slink();
            //s.InsertFront(s, 100);
            //s.InsertFront(s, 200);
            //s.InsertFront(s, 300);
            //s.InsertFront(s, 400);
            //s.InsertFront(s, 500);
            //s.Print(s); 
            #endregion

            #region generic demo singly
            //    Slink<string> sli = new Slink<string>();
            //    try
            //    {
            //        // sli.InsertFront(sli, "anand");
            //        sli.InsertLast(sli, "varun");
            //        sli.InsertLast(sli, "Nithya");
            //        //sli.InsertLast(sli, "sam");
            //        //sli.InsertLast(sli, "sk");
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine(ex.StackTrace);
            //    }

            //    // sl.InsertAfter(sl.head.next, "middle");
            //    sli.Print(sli);
            //} 
        }
        #endregion


    }
}
