using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    class ProductDAO : BaseRowDAO
    {
        const string productName = "product";
        Database database = new Database();

        /// <summary>
        /// them Product
        /// </summary>
        /// <param name="row" value="Product"></param>
        /// <returns name="checkAction" value="bool"></returns>
        public override bool Insert(BaseRow row)
        {
            bool checkAction = false;
            if (database.insertTable(productName, row) == 1) checkAction = true;

            return checkAction;
        }

        /// <summary>
        /// sua Product
        /// </summary>
        /// <param name="row" value="Product"></param>
        /// <returns name="checkAction" value="bool"></returns>
        public override bool Update(BaseRow row)
        {
            bool checkAction = false;
            if (database.updateTable(productName, row) == 1) checkAction = true;

            return checkAction;
        }

        /// <summary>
        /// xoa Product
        /// </summary>
        /// <param name="row" value="Product"></param>
        /// <returns name="checkAction" value="bool"></returns>
        public override bool Delete(BaseRow row)
        {
            bool checkAction = false;
            if (database.deleteTable(productName, row)) checkAction = true;

            return checkAction;
        }

        /// <summary>
        /// in ra tat ca danh sach
        /// </summary>
        public override List<object> findAll()
        {
            List<object> returnList = new List<object>();
            foreach (Product item in database.productTable)
            {
                returnList.Add(item);
            }
            return returnList;
        }

        /// <summary>
        /// tim product theo id
        /// </summary>
        /// <param name="name" value="int"></param>
        /// <returns name="product" value="Product"></returns>
        public Product findById(int name)
        {
            Product product = new Product();
            foreach (Product item in database.productTable)
            {
                if (item.id == name)
                {
                    product = item;
                }
            }

            return product;
        }

        /// <summary>
        /// tim category theo name
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns name="product" value="Product"></returns>
        public Product findByName(string name)
        {
            Product product = new Product();
            foreach (Product item in database.productTable)
            {
                if (item.name == name)
                {
                    product = item;
                }
            }

            return product;
        }
    }
}
