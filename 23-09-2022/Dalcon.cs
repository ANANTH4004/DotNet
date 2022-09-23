using BusinessLogicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Configuration;

namespace DAL
{
    public class Dalcon
    {
        public List<Products> ShowProducts()
        {
            string conStr = "Data Source=DESKTOP-SF8TDPM\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

            SqlConnection sql = new SqlConnection(conStr);

            //SqlCommand cmd = new SqlCommand("create   view temp as select ProductID, ProductName, UnitPrice  from products ", sql);
            //SqlCommand cmd = new SqlCommand("select * from Products ", sql);
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM temp ", sql);
            sql.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            List<Products> products = new List<Products>();
            while (dr.Read())
            {
                Products p = new Products();
                //int.TryParse(dr[0], out int ans)
                p.Prouduct_Id = Convert.ToInt32(dr[0]);
                p.ProductName = dr[1].ToString();
                p.UnitPrice = Convert.ToDouble(dr[2]);
                products.Add(p);
               
            }
            sql.Close();
            return products;
        }
    }
}
