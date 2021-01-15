using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    public class DatabaseDemo
    {
        Database database = Database.getInstance();
        /// <summary>
        /// them object vao danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        public void insertTableTest(string name, BaseRow row)
        {
            database.insertTable(name, row);
        }
        /// <summary>
        /// cap nhat danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        public void updateTableTest(string name, BaseRow row)
        {
            database.updateTable(name, row);
        }
        /// <summary>
        /// xoa bang theo row
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
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

        public List<object> selectTableTest(string name)
        {
            return database.selectTable(name);
        }
        /// <summary>
        ///  tao bang
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
                database.insertTable("product", productList[i]);
            }
            for (int i = 0; i < categoryList.Count; i++)
            {
                database.insertTable("category", categoryList[i]);
            }
            for (int i = 0; i < accessoryList.Count; i++)
            {
                database.insertTable("accessory", accessoryList[i]);
            }
        }
        /// <summary>
        /// in ra bang
        /// </summary>
        public void printTableTest()
        {
            database.printTable();
        }
    }
}
