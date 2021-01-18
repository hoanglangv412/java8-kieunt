﻿using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity;
using OOPDAY1.com.dd.kieunt.entity.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    public class DatabaseDemo
    {
        DatabaseAbstracts database = DatabaseAbstracts.getInstance();
        /// <summary>
        /// them BaseRow vao danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="BaseRow"></param>
        public void insertTableTest(string name, BaseRow row)
        {
            database.insertTable(name, row);
        }

        /// <summary>
        /// cap nhat danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="BaseRow"></param>
        public void updateTableTest(string name, BaseRow row)
        {
            database.updateTable(name, row);
        }

        /// <summary>
        /// xoa bang theo row
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="BaseRow"></param>
        public void deleteTableTest(string name, BaseRow row)
        {
            database.deleteTable(name, row);
        }

        /// <summary>
        /// xoa toan bo danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        public void truncateTableTest(string name)
        {
            database.truncateTable(name);
        }

        /// <summary>
        /// tra ve danh sach theo ten
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns value="List<BaseRow>"></returns>
        public List<BaseRow> selectTableTest(string name)
        {
            return database.selectTable(name);
        }

        /// <summary>
        ///  khoi tao bang
        /// </summary>
        public void initDatabase()
        {
            List<Product> productList = new List<Product>();
            for(int i = 0; i < 10; i++)
            {
                BaseRow product = new Product(i, "product " + i,i);
                productList.Add((Product)product);
            }

            List<Accessory> accessoryList = new List<Accessory>();
            for (int i = 0; i < 10; i++)
            {
                BaseRow accessory = new Accessory(i,"accessory "+i);
                accessoryList.Add((Accessory)accessory);
            }

            List<Category> categoryList = new List<Category>();
            for (int i = 0; i < 10; i++)
            {
                BaseRow category = new Category(i, "category " + i);
                categoryList.Add((Category)category);
            }

            for (int i = 0; i < productList.Count; i++)
            {
                database.insertTable(DatabaseAbstracts.getProductName(), productList[i]);
            }

            for (int i = 0; i < categoryList.Count; i++)
            {
                database.insertTable(DatabaseAbstracts.getCategoryName(), categoryList[i]);
            }

            for (int i = 0; i < accessoryList.Count; i++)
            {
                database.insertTable(DatabaseAbstracts.getAccessoryName(), accessoryList[i]);
            }
        }

        /// <summary>
        /// in ra danh sach theo thu tu:List<product> - 1, List<Category> - 2, List<Accessory> - 3
        /// </summary>
        public void findAllTableTest()
        {
            List<BaseRow> listProduct = database.findAll()[0];
            foreach (Product item in listProduct)
            {
                Console.WriteLine("kekekeProduct: " + item.getId() + item.getName() + item.getCategoryId());
            }

            List<BaseRow> listCategory = database.findAll()[1];
            foreach (Category item in listCategory)
            {
                Console.WriteLine("kekekeCategory: " + item.getId() + item.getName());
            }

            List<BaseRow> listAccessory = database.findAll()[2];
            foreach (Accessory item in listAccessory)
            {
                Console.WriteLine("kekekeAccessory: " + item.getId() + item.getName());
            }
        }
    }
}
