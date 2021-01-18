using OOPDAY1.com.dd.kieunt.entity;
using OOPDAY1.com.dd.kieunt.entity.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    public class DatabaseAbstracts
    {
        private List<Product> productTable = new List<Product>();
        private List<Category> categoryTable = new List<Category>();
        private List<Accessory> accessoryTable = new List<Accessory>();
        private static string PRODUCT = "product";
        private static string CATEGORY = "category";
        private static string ACCESSORY = "accessory";
        private static DatabaseAbstracts instance;
        private DatabaseAbstracts() { }

        /// <summary>
        /// lay ten category
        /// </summary>
        /// <returns value="string"></returns>
        public static string getCategoryName()
        {
            return CATEGORY;
        }

        /// <summary>
        /// lay ten product
        /// </summary>
        /// <returns value="string"></returns>
        public static string getProductName()
        {
            return PRODUCT;
        }

        /// <summary>
        /// lay ten accessory
        /// </summary>
        /// <returns value="string"></returns>
        public static string getAccessoryName()
        {
            return ACCESSORY;
        }

        /// <summary>
        /// khoi tao database
        /// </summary>
        /// <returns>tra ve database</returns>
        public static DatabaseAbstracts getInstance()
        {
            if(instance == null)
            {
                instance = new DatabaseAbstracts();
            }

            return instance;
        }

        /// <summary>
        /// them BaseRow vao bang
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="BaseRow"></param>
        /// <returns value="int"></returns>
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
                    return 1;
                }else
                {
                    return 0;
                }
            }

            if (name == CATEGORY)
            {

                categoryTable.Add((Category)row);
                if (productTableBefore <= categoryTable.Count)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            if (name == ACCESSORY)
            {
                accessoryTable.Add((Accessory)row);
                if (productTableBefore <= accessoryTable.Count)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            return 0;
        }

        /// <summary>
        /// lay danh sach theo ten
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns value="List<object>"></returns>
        public List<BaseRow> selectTable(string name)
        {
            if (name == PRODUCT) {
                return productTable.Cast<BaseRow>().ToList();
            }

            if (name == CATEGORY)
            {
                return categoryTable.Cast<BaseRow>().ToList();
            }

            if (name == ACCESSORY)
            {
                return accessoryTable.Cast<BaseRow>().ToList();
            }

            return null;
        }

        /// <summary>
        /// update table 
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="BaseRow"></param>
        /// <returns value="int"></returns>
        public int updateTable(string name, BaseRow row)
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
        /// <param name="row" value="BaseRow"></param>
        /// <returns value="bool"></returns>
        public bool deleteTable(string name, BaseRow row)
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
                accessoryTable.Clear();
            }

            if (name == CATEGORY)
            {
                categoryTable.Clear();
            }
        }

        /// <summary>
        /// tim baserow theo id
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="id" value="int"></param>
        /// <returns value="BaseRow"></returns>
        public BaseRow findById(string name,int id)
        {
            if (name == PRODUCT)
            {
                return productTable[productTable.FindIndex(item => item.getId() == id)];
            }

            if (name == ACCESSORY)
            {
                return accessoryTable[accessoryTable.FindIndex(item => item.getId() == id)];
            }

            if (name == CATEGORY)
            {
                return categoryTable[categoryTable.FindIndex(item => item.getId() == id)];
            }
            return null;
        }

        /// <summary>
        /// tim baserow theo name
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="id" value="int"></param>
        /// <returns value="BaseRow"></returns>
        public BaseRow findByName(string name, string objName)
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
        /// tra ve danh sach theo thu tu:List<product> - 1, List<Category> - 2, List<Accessory> - 3
        /// </summary>
        public List<List<BaseRow>> findAll()
        {
            return new List<List<BaseRow>> { productTable.Cast<BaseRow>().ToList(), categoryTable.Cast<BaseRow>().ToList(), accessoryTable.Cast<BaseRow>().ToList()};
        }

        /// <summary>
        /// tra ve danh sach theo ten
        /// </summary>
        /// <param name="name" value="string"></param>
        public List<BaseRow> findOneTable(string name)
        {
            if (name == PRODUCT)
            {
                return productTable.Cast<BaseRow>().ToList();
            }

            if (name == ACCESSORY)
            {
                return accessoryTable.Cast<BaseRow>().ToList();
            }

            if (name == CATEGORY)
            {
                return categoryTable.Cast<BaseRow>().ToList();
            }
            return null;
        }
    }
}
