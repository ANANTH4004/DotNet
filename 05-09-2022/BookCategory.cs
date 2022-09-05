using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class BookCategory
    {

		public BookCategory()
		{

		}
		public BookCategory(int catId , string catName , string desc)
		{
			this.catId = catId;
			this.catName = catName;
			this.desc = desc;
		}
		private int _catId;

		public int catId
		{
			get { return _catId; }
			set { _catId = value; }
		}

		private string _catName;

		public string catName
		{
			get { return _catName; }
			set { _catName = value; }
		}

		private string _desc;

		public string desc
		{
			get { return _desc; }
			set { _desc = value; }
		}

	}
}
