using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity;
using OOPDAY1.com.dd.kieunt.demo;
using System;
using System.Collections.Generic;

namespace OOPDAY1
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseDemo dm = new DatabaseDemo();
            CategoryDAO ca = new CategoryDAO();
            Category category = new Category();
            category.categoryId = 100;
            category.name = "kieu";
            Console.WriteLine(ca.insertCategory(category));
            dm.printTableTest();
        }
    }
}
