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
        Database database = new Database();
        /// <summary>
        /// them object vao danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        public void insertTableTest(string name, object row)
        {
            database.insertTable(name, row);
        }
        /// <summary>
        /// cap nhat danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        public void updateTableTest(string name, object row)
        {
            database.updateTable(name, row);
        }
        /// <summary>
        /// xoa bang theo row
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        public void deleteTableTest(string name, object row)
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
        ///  tao bang
        /// </summary>
        public void initDatabase()
        {
            List<Product> productList = new List<Product>(){
                new Product(){name="CPU",id=750,categoryId=1},
                new Product(){name="RAM",id=500,categoryId=2},
                new Product(){name="HDD",id=40,categoryId=3},
                new Product(){name="MAIN",id=400,categoryId=4},
                new Product(){name = "Keyboard", id=8, categoryId=5},
                new Product(){name = "Mouse", id= 50, categoryId= 6},
                new Product(){name = "VGA", id= 35, categoryId= 7},
                new Product(){name = "Monitor", id= 278, categoryId= 8},
                new Product(){name = "Case", id= 28, categoryId= 9},
            };
            List<Accessory> accessoryList = new List<Accessory>(){
                new Accessory(){name="CPU",accessoryId=750},
                new Accessory(){name="RAM",accessoryId=50},
                new Accessory(){name="HDD",accessoryId=40},
                new Accessory(){name="MAIN",accessoryId=400},
                new Accessory(){name = "Keyboard", accessoryId=8},
                new Accessory(){name = "Mouse", accessoryId= 550},
                new Accessory(){name = "VGA", accessoryId= 35},
                new Accessory(){name = "Monitor", accessoryId= 28},
                new Accessory(){name = "Case", accessoryId= 258},
            };
            List<Category> categoryList = new List<Category>(){
                new Category(){name="CPU",categoryId=1},
                new Category(){name="RAM",categoryId=2},
                new Category(){name="HDD",categoryId=3},
                new Category(){name="MAIN",categoryId=6},
                new Category(){name = "Keyboard", categoryId=4},
                new Category(){name = "Mouse", categoryId= 5},
                new Category(){name = "VGA", categoryId= 7},
                new Category(){name = "Monitor", categoryId= 8},
                new Category(){name = "Case", categoryId= 9},
            };
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
            foreach (Product item in database.productTable)
            {
                Console.WriteLine("Product: " + item.id + " " + item.name + " ");
            }
            foreach (Category item in database.categoryTable)
            {
                Console.WriteLine("Category: " + item.categoryId + " " + item.name + " ");
            }
            foreach (Accessory item in database.accessoryTable)
            {
                Console.WriteLine("Accessory:" + item.accessoryId + " " + item.name + " ");
            }
        }
    }
}
