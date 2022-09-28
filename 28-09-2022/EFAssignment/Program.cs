using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Insert Book 2.Update Book 3.Book Count 4.Get All Books");
            int ch = Int32.Parse(Console.ReadLine());
            BookOperations b = new BookOperations();
            BookBal book = new BookBal();
            switch (ch)
            {
                case 1:
                    
                    Console.WriteLine("Enter Book Number :");
                    book.Book_No = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Book Name :");
                    book.Book_Name = Console.ReadLine();
                    Console.WriteLine("Enter Author ;");
                    book.Author = Console.ReadLine();
                    Console.WriteLine("Enter Cost of the Book");
                    book.Cost = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Category");
                    book.Category = Console.ReadLine();
                    b.InsertBook(book);
                    break;
                case 2:
                    //BookBal book = new BookBal();
                    Console.WriteLine("Enter Book Number :");
                    book.Book_No = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Book Name :");
                    book.Book_Name = Console.ReadLine();
                    Console.WriteLine("Enter Author ;");
                    book.Author = Console.ReadLine();
                    Console.WriteLine("Enter Cost of the Book");
                    book.Cost = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Category");
                    book.Category = Console.ReadLine();
                    b.UpdateBook(book);
                    break;
                case 3:
                    int id = b.Count();
                    Console.WriteLine("Book Count  : " + id );
                    break;
                case 4:
                    List<BookBal> bookList = new List<BookBal>();
                    bookList = b.GetAllBooks();
                    foreach (var item in bookList)
                    {
                        Console.WriteLine(item.Book_No + " " + item.Book_Name + " " + item.Author + " " + item.Cost);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
