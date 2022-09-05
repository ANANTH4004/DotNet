using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
		public Book()
		{

		}
		public Book(int bookId , string bookName , int price , string author)
		{
			this.bookId = bookId;
			this.bookName = bookName;
			this.price = price;
			this.author = author;
		}
		private int _BookId;

		public int bookId
		{
			get { return _BookId; }
			set { _BookId = value; }
		}
		private string _bookName;

		public string bookName
		{
			get { return _bookName; }
			set { _bookName = value; }
		}

		private int _price;

		public int price
		{
			get { return _price; }
			set { _price = value; }
		}

		private string _author;

		public string author
		{
			get { return _author; }
			set { _author = value; }
		}


        public void AddBook(int bookId, string bookName)
        {
            this.bookId = bookId;
            this.bookName = bookName;
        }
        public void AddBook(int bookId, string bookName, int price)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.price = price;
        }


        public void AddBook(int bookId , string bookName , int price ,string author)
		{
			this.bookId = bookId;
			this.bookName = bookName;
			this.price = price;
			this.author = author;
		}


	}
}
