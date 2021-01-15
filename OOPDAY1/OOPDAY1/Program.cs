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
            ProductDAO db = new ProductDAO();
            productDAODemo pdm = new productDAODemo();
            CategoryDaoDemo cdm = new CategoryDaoDemo();
            Category ca = new Category();
            ca.setId(1);
            ca.setName("catakglsajglksajs");
            cdm.insertTest(ca);
            Console.WriteLine(cdm.findByNameTest("catakglsajglksajs").getName());
            Product b = new Product();
            b.setId(1);
            b.setName("kieuca");
            b.setCategoryId(2);
            Product c = new Product();
            c.setId(2);
            c.setName("hhahahahahaha");
            c.setCategoryId(2);
            //BaseRow a = new Category();
            //a.id = 1;
            //a.name = "kakâkakakakkâkakak";
            ////db.Insert("category", a);
            pdm.insertTest(b);
            pdm.insertTest(c);
            //db.Delete("product",c);
            pdm.findAllTest();
            Console.WriteLine(pdm.findByIdTest(1).getName());
            Console.WriteLine("kakakakaka" + pdm.findByNameTest("kieuca").getName());
        }
    }
}
