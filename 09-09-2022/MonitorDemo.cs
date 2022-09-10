using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    internal class MonitorDemo
    {
        static object Lock1 = new object();
        static void PrintTable()
        {

           // Thread.Sleep(1000);
            WriteToFile();

        }

        static void WriteToFile()
        {
            Monitor.Enter(Lock1);
            string threadname = Thread.CurrentThread.Name;
            Console.WriteLine(threadname);
            

            try
            {

                using (FileStream fs = new FileStream("Order.txt", FileMode.Append, FileAccess.Write))
                {
                    StreamWriter wr = new StreamWriter(fs);
                    wr.WriteLine(threadname);
                    wr.Close();
                    fs.Close();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {


                Monitor.Exit(Lock1);
                Console.WriteLine("Releasing the thread " + threadname);

            }




        }
        static void Main(string[] args)
        {

            //for (int i = 0; i < 4; i++)
            //{
            //    Thread thread = new Thread(PrintTable);
            //    thread.Name = string.Concat("thread ", i);
            //    thread.Start();

            //}
            Thread t1 = new Thread(PrintTable);
            Thread t2 = new Thread(PrintTable);
            Thread t3 = new Thread(PrintTable);
            Thread t4 = new Thread(PrintTable);
            t1.Name = "T1";
            t2.Name = "T2";
            t3.Name = "T3";
            t4.Name = "T4";




            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();


        }
    }
}
