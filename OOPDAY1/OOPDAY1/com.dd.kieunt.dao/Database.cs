using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    public class Database
    {
        public List<Product> productTable = new List<Product>();
        public List<Category> categoryTable = new List<Category>();
        public List<Accessory> accessoryTable = new List<Accessory>();
        public Database instant;
        public Database() { }
        /// <summary>
        /// them object vao bang
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        /// <returns name="flag" value="int"></returns>
        public int insertTable(string name, object row)
        {
            int flag = 0;
            if (name == "product")
            {
                productTable.Add((Product)row);
                flag = 1;
            }
            if (name == "category")
            {
                categoryTable.Add((Category)row);
                flag = 1;
            }
            if (name == "accessory")
            {
                accessoryTable.Add((Accessory)row);
                flag = 1;
            }
            return flag;
        }
        /// <summary>
        /// update table 
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        /// <returns name="flag" value="int"></returns>
        public int updateTable(string name, object row)
        {
            int flag = 0;
            if (name == "product")
            {
                Product product = new Product();
                product = (Product)row;
                foreach (Product item in productTable)
                {
                    if (item.id == product.id)
                    {
                        item.name = product.name;
                        item.categoryId = product.categoryId;
                        flag = 1;
                    }
                }
            }
            if (name == "category")
            {
                Category category = new Category();
                category = (Category)row;
                foreach (Category item in categoryTable)
                {
                    if (item.categoryId == category.categoryId)
                    {
                        item.name = category.name;
                        flag = 1;
                    }
                }
            }
            if (name == "accessory")
            {
                Accessory accessory = new Accessory();
                accessory = (Accessory)row;
                foreach (Accessory item in accessoryTable)
                {
                    if (item.accessoryId == accessory.accessoryId)
                    {
                        item.name = accessory.name;
                        flag = 1;
                    }
                }
            }
            return flag;
        }
        /// <summary>
        /// xoa object trong bang
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        /// <returns></returns>
        public bool deleteTable(string name, object row)
        {
            bool value = false;
            if (name == "product")
            {
                Product product = new Product();
                product = (Product)row;
                foreach (Product item in productTable)
                {
                    if (item.id == product.id)
                    {
                        productTable.Remove(item);
                        value = true;
                    }
                }
            }
            if (name == "category")
            {
                Category category = new Category();
                category = (Category)row;
                foreach (Category item in categoryTable)
                {
                    if (item.categoryId == category.categoryId)
                    {
                        categoryTable.Remove(item);
                        value = true;
                    }
                }
            }
            if (name == "accessory")
            {
                Accessory accessory = new Accessory();
                accessory = (Accessory)row;
                foreach (Accessory item in accessoryTable)
                {
                    if (item.accessoryId == accessory.accessoryId)
                    {
                        accessoryTable.Remove(item);
                        value = true;
                    }
                }
            }
            return value;
        }
        /// <summary>
        /// xoa toan bo danh sách
        /// </summary>
        /// <param name="name" value="string"></param>
        public void truncateTable(string name)
        {
            if (name == "product")
            {
                foreach (Product item in productTable)
                {
                    productTable.Remove(item);
                }
            }
            if (name == "accessory")
            {
                foreach (Accessory item in accessoryTable)
                {
                    accessoryTable.Remove(item);
                }
            }
            if (name == "category")
            {
                foreach (Category item in categoryTable)
                {
                    categoryTable.Remove(item);
                }

            }
        }
        /// <summary>
        /// in ra danh sach
        /// </summary>
        public void printTableTest()
        {
            Console.WriteLine(productTable.Count);
            //foreach (Category item in database.categoryTable)
            //{
            //    Console.WriteLine("bro");
            //    Console.WriteLine("Category: " + item.categoryId + " " + item.name + " ");
            //}
            //foreach (Accessory item in database.accessoryTable)
            //{
            //    Console.WriteLine("Accessory:" + item.accessoryId + " " + item.name + " ");
            //}
        }
    }
}
