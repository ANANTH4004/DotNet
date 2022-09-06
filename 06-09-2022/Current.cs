using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Current : IBank
    {
        private static double balance = 20000;

        public static DateTime lastDeposit = new DateTime();
        public static DateTime lastWithdraw = new DateTime();
        public double getBalance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void CalculateInterest()
        {
            double interest = (balance * 5 * 2) / 100;
            Console.WriteLine("Total interest for Five years : " + interest);
        }
        public void CalculateInterest(int year)
        {
            double interest = (balance * year * 2) / 100;
            Console.WriteLine($"Total interest for {year} years : " + interest);
        }

        public void PrintBalance()
        {
            Console.WriteLine("The Available Account Balance is : " + balance);
        }
    }
}
