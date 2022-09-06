using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public  class Savings : IBank
    {
       public static DateTime lastDeposit =  new DateTime();
       public static DateTime lastWithdraw = new DateTime();
        private static double balance = 10000;
        public double getBalance
        {
            get { return balance; }
           set { balance = value; }
        }


        public void CalculateInterest()
        {
            double interest = (balance * 5 * 4) / 100;
            Console.WriteLine("Total interest for Five years : " + interest);
        }
        public void CalculateInterest(int year)
        {
            double interest = (balance * year * 4) / 100;
            Console.WriteLine($"Total interest for {year} years : " + interest);
        }

        public void PrintBalance()
        {
            Console.WriteLine("The Available Account Balance is : " + balance);
        }
        public void Duration()
        {
            Console.WriteLine(lastDeposit.Subtract(lastWithdraw));
        }
      
    }
}
