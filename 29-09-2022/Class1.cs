using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class Borrower
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }

        public string JobName { get; set; }

    }
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public int RateOfInterest { get; set; }
    }
    public class Banking : DbContext
    {
        public Banking() : base("Banking")
        {
            Database.SetInitializer<Banking>(new CreateDatabaseIfNotExists<Banking>());
        }
        public virtual DbSet<Borrower> Bankings { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
    }
}
