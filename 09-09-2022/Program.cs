using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace ThreadDemo
{
    
    internal class Program
    {
        public static void MyThreadMethod()
        {
            Console.WriteLine(Thread.CurrentThread.Name +" Thread is Running");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 1 : " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Thread Ends");
        }
         private static void M1()
        {

            Thread.Sleep(300);
            Console.WriteLine("Sleep State =" + Thread.CurrentThread.ThreadState);
        }

        static void Main(string[] args)
        {
           // Thread t1 = new Thread(MyThreadMEthod);
           //// t1.IsBackground = true;
           // t1.Name = "Anand";
           // t1.Start();
            Thread t1 = new Thread(MyThreadMethod);
            Thread t2 = new Thread(M1);
            Console.WriteLine("----Before Start---- ");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            t1.Start();
            t2.Start();
            Console.WriteLine("----After Start----");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            //t1.Abort();
            //t2.Abort();
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);
            Console.WriteLine("Main ends.......");
            
        }

       
    }
}
