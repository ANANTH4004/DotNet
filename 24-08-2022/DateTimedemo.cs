using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practices
{
    internal class DateTimedemo
    {
        static void Main(string[] args)
        {
            ;
            DateTime d = new DateTime();
          
            d = DateTime.Now;
            
            Console.WriteLine(d);
            Console.WriteLine("Long Date " + d.ToLongDateString());
            Console.WriteLine("Long Date " + d.ToBinary());
            Console.WriteLine("Long Time " + d.ToLongTimeString());
            Console.WriteLine("date " + d.Day);
            Console.WriteLine("month " + d.Month);
            Console.WriteLine("year " + d.Year);
            Console.WriteLine("hour " + d.Hour);
            Console.WriteLine( "add tow days "+ d.AddDays(2));
            Console.WriteLine( "Day of year "+ d.DayOfYear);
            Console.WriteLine("=================================");
            Console.WriteLine("Enter DOB");
           
           DateTime b = new DateTime(2001, 05, 11);
            Console.WriteLine("Age :"+ (d.Year-b.Year)) ;
            Console.WriteLine(b.DayOfYear);
            Console.WriteLine( "age in days "+d.Subtract(b).TotalDays);
            Console.WriteLine( "age in Months "+d.Subtract(b).TotalDays/12);
            Console.WriteLine("age in days " + d.Subtract(b).Days);
            Console.WriteLine(b.DayOfWeek);


        }
    }
}
