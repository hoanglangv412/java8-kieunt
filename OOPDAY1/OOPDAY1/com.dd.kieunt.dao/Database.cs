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
        const string productName = "product";
        const string categoryName = "category";
        const string accessoryName = "accessory";

        /// <summary>
        /// them object vao bang
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        /// <returns name="checkAction" value="int"></returns>
        public int insertTable(string name, BaseRow row)
        {
            int checkAction = 0;
            if (name == productName)
            {
                productTable.Add((Product)row);
                checkAction = 1;
            }

            if (name == categoryName)
            {
                categoryTable.Add((Category)row);
                checkAction = 1;
            }

            if (name == accessoryName)
            {
                accessoryTable.Add((Accessory)row);
                checkAction = 1;
            }

            return checkAction;
        }

        /// <summary>
        /// lay danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns name="returnList" value="List<object>"></returns>
        public List<object> selectTable(string name)
        {
            List<object> returnList = new List<object>();
            if (name == productName)
            {
                foreach (Product item in productTable)
                {
                    returnList.Add(item);
                }
            }

            if (name == categoryName)
            {
                foreach (Category item in categoryTable)
                {
                    returnList.Add(item);
                }
            }

            if (name == accessoryName)
            {
                foreach (Accessory item in accessoryTable)
                {
                    returnList.Add(item);
                }
            }

            return returnList;
        }

        /// <summary>
        /// update table 
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        /// <returns name="checkAction" value="int"></returns>
        public int updateTable(string name, object row)
        {
            int checkAction = 0;
            if (name == productName)
            {
                Product product = new Product();
                product = (Product)row;
                for(int i = 0; i < productTable.Count; i++)
                {
                    if(productTable[i].id == product.id)
                    {
                        productTable[i] = product;
                        checkAction = 1;
                    }
                }
            }

            if (name == categoryName)
            {
                Category category = new Category();
                category = (Category)row;
                for (int i = 0; i < categoryTable.Count; i++)
                {
                    if (categoryTable[i].id == category.id)
                    {
                        categoryTable[i] = category;
                        checkAction = 1;
                    }
                }
            }

            if (name == accessoryName)
            {
                Accessory accessory = new Accessory();
                accessory = (Accessory)row;
                for (int i = 0; i < accessoryTable.Count; i++)
                {
                    if (accessoryTable[i].id == accessory.id)
                    {
                        accessoryTable[i] = accessory;
                        checkAction = 1;
                    }
                }
            }

            return checkAction;
        }

        /// <summary>
        /// xoa object trong bang
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        /// <returns></returns>
        public bool deleteTable(string name, object row)
        {
            bool isDeleted = false;
            if (name == productName)
            {
                Product product = new Product();
                product = (Product)row;
                productTable.RemoveAt(productTable.FindIndex(item => item.id == product.id));
                isDeleted = true;
            }

            if (name == categoryName)
            {
                Category category = new Category();
                category = (Category)row;
                categoryTable.RemoveAt(categoryTable.FindIndex(item => item.id == category.id));
                isDeleted = true;
            }

            if (name == accessoryName)
            {
                Accessory accessory = new Accessory();
                accessory = (Accessory)row;
                accessoryTable.RemoveAt(accessoryTable.FindIndex(item => item.id == accessory.id));
                isDeleted = true;
            }

            return isDeleted;
        }

        /// <summary>
        /// xoa toan bo danh sách
        /// </summary>
        /// <param name="name" value="string"></param>
        public void truncateTable(string name)
        {
            if (name == productName)
            {
                productTable.Clear();
            }

            if (name == accessoryName)
            {
                productTable.Clear();
            }

            if (name == categoryName)
            {
                productTable.Clear();
            }
        }

        /// <summary>
        /// in ra danh sach
        /// </summary>
        public void printTable()
        {
            foreach (Product item in productTable)
            {
                Console.WriteLine("Product: " + item.id + " " + item.name + " " + item.categoryId + " ");
            }

            foreach (Category item in categoryTable)
            {
                Console.WriteLine("Category: " + item.id + " " + item.name + " ");
            }

            foreach (Accessory item in accessoryTable)
            {
                Console.WriteLine("Accessory:" + item.id + " " + item.name + " ");
            }
        }
    }
}
