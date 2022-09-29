using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;

namespace CodeFirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Banking context = new Banking();
            context.Loans.Add(new Loan { LoanId = 101, Amount = 30000, RateOfInterest = 5, Type = "LOAN" });
            context.SaveChanges();
            Console.WriteLine("done");
           
        }
    }
}
