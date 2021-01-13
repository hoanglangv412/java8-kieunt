using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    public class ProductDemo
    {
        public ProductDemo() { }
        /// <summary>
        /// tao bang
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="categoryId"></param>
        /// <returns name="a" value="Product"></returns>
        public Product createProductTest(int id, string name, int categoryId)
        {
            Product a = new Product();
            Console.Write("ID: ");
            a.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            a.name = Console.ReadLine();
            Console.Write("categoryId: ");
            a.categoryId = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        public void printProduct(Product a)
        {
            Console.Write("Name: " + a.name + "   ID: " + a.id + "   categoryId: " + a.categoryId);
        }
    }
}
