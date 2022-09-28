using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace BAL
{
    public class BookOperations
    {
        public void InsertBook(BookBal b)
        {
            ShoppingEntities context = new ShoppingEntities();
            Book bookdal = new Book();
            bookdal.Book_No = b.Book_No;
            bookdal.Book_Name = b.Book_Name;
            bookdal.Author = b.Author;
            bookdal.Cost = b.Cost;
            bookdal.Category = b.Category;
            context.Books.Add(bookdal);
            context.SaveChanges();
        }
        public void UpdateBook(BookBal b)
        {
            ShoppingEntities context = new ShoppingEntities();
            // context.s(b.Book_No, b.Book_Name, b.Author, b.Cost, b.Category);
            context.sp_UpdateBook(b.Book_No, b.Book_Name, b.Author, b.Cost, b.Category);
        }
        public int Count()
        {
            ShoppingEntities context = new ShoppingEntities();
           // _db = new DbEntities();
            int id =  context.sp_BookCountFinal();
            return id;
        }
        public List<BookBal> GetAllBooks()
        {
            ShoppingEntities context = new ShoppingEntities();
            var ans = context.GetAllBook();
            List<BookBal> book = new List<BookBal>();
            foreach (var item in ans)
            {
                book.Add(new BookBal { Book_No = item.Book_No, Book_Name = item.Book_Name, Author = item.Author, Cost = item.Cost, Category = item.Category });
            }
            return book;
        }

    }

   
}
