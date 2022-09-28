using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BookBal
    {
        public int Book_No { get; set; }
        public string Book_Name { get; set; }
        public string Author { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string Category { get; set; }
    }
}
