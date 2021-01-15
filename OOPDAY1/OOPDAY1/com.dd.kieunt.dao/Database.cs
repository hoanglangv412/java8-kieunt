using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    public class Database
    {
        private List<Product> productTable = new List<Product>();
        private List<Category> categoryTable = new List<Category>();
        private List<Accessory> accessoryTable = new List<Accessory>();
        private const string PRODUCT = "product";
        private const string CATEGORY = "category";
        private const string ACCESSORY = "accessory";
        private static Database instance;
        private Database() { }

        /// <summary>
        /// khoi tao database
        /// </summary>
        /// <returns>tra ve database</returns>
        public static Database getInstance()
        {
            if(instance == null)
            {
                instance = new Database();
            }

            return instance;
        }
        /// <summary>
        /// them object vao bang
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        /// <returns name="checkAction" value="int"></returns>
        public int insertTable(string name, BaseRow row)
        {
            int productTableBefore = name == PRODUCT
                ? productTable.Count
                : name == CATEGORY
                ? categoryTable.Count
                : accessoryTable.Count;

            if (name == PRODUCT)
            {
                productTable.Add((Product)row);
                if(productTableBefore <= productTable.Count)
                {
                    return 0;
                }else
                {
                    return 1;
                }
            }

            if (name == CATEGORY)
            {

                categoryTable.Add((Category)row);
                if (productTableBefore <= categoryTable.Count)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            if (name == ACCESSORY)
            {
                accessoryTable.Add((Accessory)row);
                if (productTableBefore <= accessoryTable.Count)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            return 0;
        }

        /// <summary>
        /// lay danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns name="returnList" value="List<object>"></returns>
        public List<object> selectTable(string name)
        {
            List<object> returnList = new List<object>();
            if (name == PRODUCT)
            {
                foreach (Product item in productTable)
                {
                    returnList.Add(item);
                }

                return returnList;
            }

            if (name == CATEGORY)
            {
                foreach (Category item in categoryTable)
                {
                    returnList.Add(item);
                }

                return returnList;
            }

            if (name == ACCESSORY)
            {
                foreach (Accessory item in accessoryTable)
                {
                    returnList.Add(item);
                }

                return returnList;
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
            if (name == PRODUCT)
            {
                Product product = new Product();
                product = (Product)row;
                if (productTable.FindIndex(item => item.getId().Equals(product.getId())) >= 0)
                {
                    productTable[productTable.FindIndex(item => item.getId().Equals(product.getId()))] = product;
                    return 1;
                }
                else return 0;
            }

            if (name == CATEGORY)
            {
                Category category = new Category();
                category = (Category)row;
                if (categoryTable.FindIndex(item => item.getId().Equals(category.getId())) >= 0)
                {
                    categoryTable[categoryTable.FindIndex(item => item.getId().Equals(category.getId()))] = category;
                    return 1;
                }
                else return 0;
            }

            if (name == ACCESSORY)
            {
                Accessory accessory = new Accessory();
                accessory = (Accessory)row;
                if (accessoryTable.FindIndex(item => item.getId().Equals(accessory.getId())) >= 0)
                {
                    accessoryTable[accessoryTable.FindIndex(item => item.getId().Equals(accessory.getId()))] = accessory;
                    return 1;
                }
                else return 0;
            }

            return 0;
        }

        /// <summary>
        /// xoa object trong bang
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="object"></param>
        /// <returns></returns>
        public bool deleteTable(string name, object row)
        {
            int tableCount = 0;
            if (name == PRODUCT)
            {
                tableCount = productTable.Count;
                Product product = new Product();
                product = (Product)row;
                productTable.RemoveAt(productTable.FindIndex(item => item.getId() == product.getId()));
                if (tableCount > productTable.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (name == CATEGORY)
            {
                tableCount = categoryTable.Count;
                Category category = new Category();
                category = (Category)row;
                categoryTable.RemoveAt(categoryTable.FindIndex(item => item.getId() == category.getId()));
                if (tableCount > categoryTable.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (name == ACCESSORY)
            {
                tableCount = accessoryTable.Count;
                Accessory accessory = new Accessory();
                accessory = (Accessory)row;
                accessoryTable.RemoveAt(accessoryTable.FindIndex(item => item.getId() == accessory.getId()));
                if (tableCount > categoryTable.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// xoa toan bo danh sách
        /// </summary>
        /// <param name="name" value="string"></param>
        public void truncateTable(string name)
        {
            if (name == PRODUCT)
            {
                productTable.Clear();
            }

            if (name == ACCESSORY)
            {
                productTable.Clear();
            }

            if (name == CATEGORY)
            {
                productTable.Clear();
            }
        }

        public object findById(string name,int id)
        {
            object returnObject = null;
            if (name == PRODUCT)
            {
                returnObject = productTable[productTable.FindIndex(item => item.getId() == id)];
            }

            if (name == ACCESSORY)
            {
                returnObject = accessoryTable[accessoryTable.FindIndex(item => item.getId() == id)];
            }

            if (name == CATEGORY)
            {
                returnObject = categoryTable[categoryTable.FindIndex(item => item.getId() == id)];
            }
            return returnObject;
        }

        public object findByName(string name, string objName)
        {
            if (name == PRODUCT)
            {
                return productTable[productTable.FindIndex(item => item.getName() == objName)];
            }

            if (name == ACCESSORY)
            {
                return accessoryTable[accessoryTable.FindIndex(item => item.getName() == objName)];
            }

            if (name == CATEGORY)
            {
                return categoryTable[categoryTable.FindIndex(item => item.getName() == objName)];
            }
            return null;
        }
        /// <summary>
        /// in ra danh sach
        /// </summary>
        public void printTable()
        {
            foreach (Product item in productTable)
            {
                Console.WriteLine("Product: " + item.getId() + " " + item.getName() + " " + item.getCategoryId() + " ");
            }

            foreach (Category item in categoryTable)
            {
                Console.WriteLine("Category: " + item.getId() + " " + item.getName() + " ");
            }

            foreach (Accessory item in accessoryTable)
            {
                Console.WriteLine("Accessory:" + item.getId() + " " + item.getName() + " ");
            }
        }
        /// <summary>
        /// in ra bang theo ten
        /// </summary>
        /// <param name="name"></param>
        public void printTable(string name)
        {
            if (name == PRODUCT)
            {
                foreach (Product item in productTable)
                {
                    Console.WriteLine("Product: " + item.getId() + " " + item.getName() + " " + item.getCategoryId() + " ");
                }
            }

            if (name == ACCESSORY)
            {
                foreach (Accessory item in accessoryTable)
                {
                    Console.WriteLine("Accessory:" + item.getId() + " " + item.getName() + " ");
                }
            }

            if (name == CATEGORY)
            {
                foreach (Category item in categoryTable)
                {
                    Console.WriteLine("Category: " + item.getId() + " " + item.getName() + " ");
                }
            }
        }

    }
}
