using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;

namespace Categories
{
    public class Category
    {
		public Category()
		{

		}
		public Category(int cid , string cname)
		{
			getCatId = cid;
			getCatName = cname;
		}
        public void AddCategory(int cid, string cname)
        {
            getCatId = cid;
            getCatName = cname;
			Console.WriteLine("Enter description : ");
			getDescription = Console.ReadLine();
        }
        public static int ProductCount = 0;
		List<Product> products = new List<Product>();
		public void AddItems(Product p)
		{
			products.Add(p);
			ProductCount++;
		}
		public void ShowDetails()
		{
			Console.WriteLine("Category Name : "+ this.getCatName);
			foreach (var item in products)
			{
				Console.WriteLine("Name : " + item.getPName + "\t" + "Uint Price : " + item.getUnitPrice);
			}
			Console.WriteLine("Product count : " + ProductCount);
			Console.WriteLine("======================================================");
		}
		private int catId;

		public int getCatId
		{
			get { return catId; }
			set { catId = value; }
		}
		private string catName;

		public string getCatName
		{
			get { return catName; }
			set { catName = value; }
		}
		private string description;

		public string getDescription
		{
			get { return description; }
			set { description = value; }
		}


	}
}
