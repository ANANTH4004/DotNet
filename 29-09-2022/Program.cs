using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library.Library context = new Library.Library();
           // context.Books.Create();

            context.Books.Add(new Book{ Book_No = 7, Book_Name = "Ponniyin Selvan", Author = "Kalki", Cost = 1500, Category = "Tamil"});
            context.SaveChanges();
            Console.WriteLine("Created.....");
        }
    }
}
