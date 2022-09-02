using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Product
    {
		private int pId;
		
		public Product()
		{

		}
		public Product(int pid , string pName)
		{
			getPid = pid;
			getPName = pName; 
		}
        public void AddProducts(int pid, string pName)
        {
            getPid = pid;
            getPName = pName;
			Console.WriteLine("Enter Unit Price For This Product: "+ pName);
			getUnitPrice = Int32.Parse(Console.ReadLine());
        }
        public int getPid
		{
			get { return pId; }
			set { pId = value; }
		}
		private string pName;

		public string getPName
		{
			get { return pName; }
			set { pName = value; }
		}
		private int qtySold;

		public int getQtySold
		{
			get { return qtySold; }
			set { qtySold = value; }
		}
		private int unitPrice;

		public int getUnitPrice
		{
			get { return unitPrice; }
			set { unitPrice = value; }
		}

		//private int unitOfMeasurement;

		//public int getUintOfMeasurement
		//{
		//	get { return unitOfMeasurement; }
		//	set { unitOfMeasurement = value; }
		//}
		private int qtyinHand;

		public int getQtyinHand
		{
			get { return qtyinHand; }
			set { qtyinHand = value; }
		}


	}
}
