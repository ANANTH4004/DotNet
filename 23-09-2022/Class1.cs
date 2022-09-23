using BusinessLogicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace HelperLibrary
{
    public class Class1
    {
        public List<Products> GetProducts()
        {
            Dalcon d = new Dalcon();
            List<Products> products = new List<Products>();
           products =  d.ShowProducts();
            return products;
        }
    }
}
