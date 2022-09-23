using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary
{
    public class Products
    {
		private int _Pid;

		public int Prouduct_Id
		{
			get { return _Pid; }
			set {
				if ( value.ToString().Length>4)
				{
					throw new Exception("Product Id isn't valid");
				}
				else
				{
                    _Pid = value;
                }
				
			}
		}

		private string _Product_Name;

		public string ProductName
		{
			get { return _Product_Name; }
			set {
				if (String.IsNullOrEmpty(value) || value.Length > 80)
				{
					throw new Exception("Product Name can't be Null or greater than 80 Character");
				}
				else
				{
                    _Product_Name = value;
                }
            }
				
		}
		private double _UnitPrice;

		public double UnitPrice
		{
			get { return _UnitPrice; }
			set {
				if (value.ToString().Length > 8)
				{
					throw new Exception("Not a valid Unit Price");
				}
				else
				{
                    _UnitPrice = value;
                }
				 }
		}




	}
}
