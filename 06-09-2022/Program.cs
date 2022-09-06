using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace _06_09_2022_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region person
            //Employee e = new Employee();
            //e.Work();
            //Manager m = new Manager();
            //m.Work();
            //Clerk c = new Clerk();
            //c.Work(); 
            #endregion
            Savings s = new Savings();
            Console.WriteLine("Account Balance : " + s.getBalance);
            s.PrintBalance();
            //  ExtensionMethods.Deposit(s, 212);
            s.Deposit(212);
            Console.WriteLine("Account Balance : " + s.getBalance);
            s.PrintBalance();

            Current c = new Current();
            Console.WriteLine("Current Balance : "+ c.getBalance);
            c.PrintBalance();
            c.Deposit(313);
           // ExtensionMethods.Deposit(c, 313);
            Console.WriteLine("Current Balance : " + c.getBalance);
            c.PrintBalance();

            s.Withdraw(200);
            c.Withdraw(300);
            s.PrintBalance();
            c.PrintBalance();
            s.Duration();
        }
    }
}
