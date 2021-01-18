using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    class DatabaseDemoInterface
    {
        DatabaseInterfaces database = DatabaseInterfaces.getInstance();
        /// <summary>
        /// them IEntity vao danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="IEntity"></param>
        public void insertTableTest(string name, IEntity row)
        {
            database.insertTable(name, row);
        }

        /// <summary>
        /// cap nhat danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="IEntity"></param>
        public void updateTableTest(string name, IEntity row)
        {
            database.updateTable(name, row);
        }

        /// <summary>
        /// xoa bang theo row
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="IEntity"></param>
        public void deleteTableTest(string name, IEntity row)
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
        /// lay danh sach theo ten
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns value="List<IEntity>"></returns>
        public List<IEntity> selectTableTest(string name)
        {
            return database.selectTable(name);
        }

        /// <summary>
        ///  khoi tao cac danh sach
        /// </summary>
        public void initDatabase()
        {
            List<Product> productList = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                IEntity product = new Product(i, "product " + i, i);
                productList.Add((Product)product);
            }

            List<Accessory> accessoryList = new List<Accessory>();
            for (int i = 0; i < 10; i++)
            {
                IEntity accessory = new Accessory(i, "accessory " + i);
                accessoryList.Add((Accessory)accessory);
            }

            List<Category> categoryList = new List<Category>();
            for (int i = 0; i < 10; i++)
            {
                IEntity category = new Category(i, "category " + i);
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
        /// in ra danh sach theo thu tu:List<product> - 1, List<Category> - 2, List<Accessory> - 3
        /// </summary>
        public void findAllTableTest()
        {
            List<IEntity> listProduct = database.findAll()[0];
            foreach (Product item in listProduct)
            {
                Console.WriteLine("kekekeProduct: " + item.getId() + item.getName() + item.getCategoryId());
            }

            List<IEntity> listCategory = database.findAll()[1];
            foreach (Category item in listCategory)
            {
                Console.WriteLine("kekekeCategory: " + item.getId() + item.getName());
            }

            List<IEntity> listAccessory = database.findAll()[2];
            foreach (Accessory item in listAccessory)
            {
                Console.WriteLine("kekekeAccessory: " + item.getId() + item.getName());
            }
        }
    }
}
