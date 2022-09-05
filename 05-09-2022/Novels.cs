using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Novels : Book
    {
        private int _nop;

        public int numberOfPages
        {
            get { return _nop; }
            set { _nop = value; }
        }

        public void AddBook(int bookid,string bookName, int price , int pageNo)
        {
            this.bookId = bookid;
            this.bookName = bookName;
            this.price = price;
            this.numberOfPages = pageNo;
        }
        public new void AddBook(int bookid, string bookName, int price)
        {
            this.bookId = bookid;
            this.bookName = bookName;
            this.price = price;
        }
    }
}
