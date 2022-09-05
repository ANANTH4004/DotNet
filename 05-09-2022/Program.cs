using BookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_09_2022_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(101,"Ponniyin Selvan",2000,"kalki");
            Book b2 = new Book();
            b2.AddBook(202, "Game Of Thrones", 1000);
            Book b3 = new Book();
            b3.AddBook(303, "Rich Dad,Poor Dad");
            Cart c1 = new Cart();
            c1.AddToCart(b1);
            c1.AddToCart(b2);
            c1.AddToCart(b3);
            c1.Display();
        }
    }
}
