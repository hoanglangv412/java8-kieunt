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
            List<Accessory> accessoryList = new List<Accessory>();
            for (int i = 0; i < 10; i++)
            {
                BaseRow accessory = new Accessory(i,"accessory"+i);
                accessoryList.Add((Accessory)accessory);
            }
            List<Category> categoryList = new List<Category>(){
                new Category(){name="CPU",id=1},
                new Category(){name="RAM",id=2},
                new Category(){name="HDD",id=3},
                new Category(){name="MAIN",id=6},
                new Category(){name = "Keyboard", id=4},
                new Category(){name = "Mouse", id= 5},
                new Category(){name = "VGA", id= 7},
                new Category(){name = "Monitor", id= 8},
                new Category(){name = "Case", id= 9},
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
                Console.WriteLine("Category: " + item.id + " " + item.name + " ");
            }
            foreach (Accessory item in database.accessoryTable)
            {
                Console.WriteLine("Accessory:" + item.id + " " + item.name + " ");
            }
        }
    }
}
