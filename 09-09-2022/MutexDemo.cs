using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadDemo
{
    internal class MutexDemo
    {
        static void Main(string[] args)
        {
            using (Mutex mutex = new Mutex(false, "ThreadingDemo"))
            {

                if (!mutex.WaitOne(5000, false))
                {
                    Console.WriteLine("already running....");
                    Console.ReadLine();
                    return;

                }
                else
                {
                    Console.WriteLine("app is running");
                    Console.ReadLine();
                }

            }
        }
    }
}
