using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Categories;
using Products;

namespace _02_09_2022_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.getPid = 1;
            p1.getPName = "cookies";
            p1.getQtySold = 2000;
            p1.getQtyinHand = 4000;
            p1.getUnitPrice = 10;
            Product p2 = new Product();
            p2.getPid = 2;
            p2.getPName = "lays";
            p2.getQtyinHand = 3000;
            p2.getQtySold = 8000;
            p2.getUnitPrice = 5;

            Product p5 = new Product(5, "chips");
            Product p6 = new Product();
            p6.AddProducts(6, "puffs");
            Category Snack = new Category();
            Snack.getCatId = 1;
            Snack.getCatName = "Snacks";
            Snack.getDescription = "a small amount of food eaten between meals.";
            Snack.AddItems(p1);
            Snack.AddItems(p2);
            Snack.AddItems(p5);
            Snack.AddItems(p6);
            Snack.ShowDetails();

            Product p3 = new Product();
            p3.getPid = 1;
            p3.getPName = "Milk";
            p3.getQtySold = 200;
            p3.getQtyinHand = 40;
            p3.getUnitPrice = 20;

            Product p4 = new Product();
            p4.getPid = 2;
            p4.getPName = "Butter";
            p4.getQtySold = 2033;
            p4.getQtyinHand = 450;
            p4.getUnitPrice = 15;

            Category Dairy = new Category();
            Dairy.getCatId = 2;
            Dairy.getCatName = "Dairy Products";
            Dairy.getDescription = " milk and any of the foods made from milk, including butter, cheese, ice cream, yogurt, and condensed and dried milk.";
            Dairy.AddItems(p3);
            Dairy.AddItems(p4);
            Dairy.ShowDetails();
            Console.WriteLine("Total Products: " + Category.ProductCount);


        }
    }
}
