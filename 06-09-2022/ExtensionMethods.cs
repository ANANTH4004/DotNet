using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class ExtensionMethods
    {
        public static void Withdraw(this Savings s , int amount)
        {
            if (amount > s.getBalance)
            {
                Console.WriteLine("Insufficient Amount");
            }
            else
            {
                Savings.lastWithdraw = DateTime.Now;
                s.getBalance = s.getBalance - amount;
            }
                   
        }
        public static void Withdraw(this Current c, int amount)
        {
            if (amount > c.getBalance)
            {
                Console.WriteLine("Insufficient Amount");
            }
            else
            {
                Current.lastWithdraw = DateTime.Now;
                c.getBalance = c.getBalance - amount;
            }
                
        }
        public static void Deposit(this Savings s , int amount)
        {

            Savings.lastDeposit = DateTime.Now;
            s.getBalance = s.getBalance + amount;
        }
        public static void Deposit(this Current c, int amount)
        {
            Current.lastDeposit = DateTime.Now;
            c.getBalance = c.getBalance + amount;
        }
    }
}
