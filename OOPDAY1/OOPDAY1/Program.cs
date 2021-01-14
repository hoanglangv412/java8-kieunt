using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity;
using OOPDAY1.com.dd.kieunt.demo;
using System;
using System.Collections.Generic;

namespace OOPDAY1
{
    class Program
    {
        static void Main(string[] args) {
            CategoryDaoDemo cdd = new CategoryDaoDemo();
            Category a = new Category();
            a.id = 1;
            a.name = "kieu";
            cdd.insertTest(a);
            Console.WriteLine(cdd.findAllTest());
        }
    }
}
