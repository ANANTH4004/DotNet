using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;
using BusinessLogicLibrary;



namespace ADOassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
			try
			{
                Class1 c = new Class1();
                List<Products> products = new List<Products>();
                products = c.GetProducts();
                foreach (var item in products)
                {
                    Console.WriteLine(item.Prouduct_Id + "\t  " + item.ProductName + "\t | " + item.UnitPrice);
                    
                    
                    count++;
                }

            }
            catch (Exception ex)
			{

				Console.WriteLine("Error Message : " + ex.Message);
			}
            finally
            {
                Console.WriteLine("Count : " + count);
            }

        }
    }
}
