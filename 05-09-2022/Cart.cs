using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Cart : Book
    {
		static int BookCount = 0;
		private int _bookingId;

		public int bookingId
		{
			get { return _bookingId; }
			set { _bookingId = value; }
		}

		private int _custId;

		public int custId
		{
			get { return _custId; }
			set { _custId = value; }
		}		
		List<Book> myCart = new List<Book>();
		
		public void AddToCart(Book b)
		{
			BookCount++;
			myCart.Add(b);
		}
		public void Display()
		{
			foreach (var item in myCart)
			{
				Console.WriteLine($"Book Id : {item.bookId}\nBook Name : {item.bookName}\nPrice : {item.price}\n");
			}
			Console.WriteLine("Number of Books in the Cart : " + BookCount);
			Console.WriteLine("==================================================");
		}
	}
}
