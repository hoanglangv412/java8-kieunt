using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.demo;
using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;

namespace OOPDAY1
{
    class Program
    {
        static void Main(string[] args) {

            ProductDAODemo cad1 = new ProductDAODemo();
            Product bc= new Product(1, "kieu",2);
            Product bc2 = new Product(1, "kieu2", 2);
            cad1.insertTest(bc);
            cad1.updateTest(bc2);
            //cad1.deleteTest(bc2);
            foreach (Product item in cad1.findAllTest(Database.getProductName()))
            {
                Console.WriteLine("hahahaha" + item.getName() + item.getId());
            }

            CategoryDaoDemo cad2 = new CategoryDaoDemo();
            Category b = new Category(1, "kieu");
            Category b2 = new Category(1, "kieuca");
            cad2.insertTest(b);
            cad2.updateTest(b2);
            //cad2.deleteTest(b2);
            foreach (Category item in cad2.findAllTest(Database.getCategoryName()))
            {
                Console.WriteLine("hahahaha" + item.getName() + item.getId());
            }

            AccessoryDAODemo cad3 = new AccessoryDAODemo();
            Accessory c = new Accessory(1, "kieu");
            Accessory cd = new Accessory(1, "kieuhuhu");
            cad3.insertTest(c);
            cad3.updateTest(cd);
            //cad3.deleteTest(cd);
            foreach (Accessory item in cad2.findAllTest(Database.getAccessoryName()))
            {
                Console.WriteLine("hahahaha" + item.getName() + item.getId());
            }

            DatabaseDemo ddd = new DatabaseDemo();
            ddd.initDatabase();
            ddd.findAllTableTest();
        }
    }
}
