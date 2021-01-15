using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    class ProductDAO : BaseDAO
    {
        private const string PRODUCT = "product";
        /// <summary>
        /// tim product theo id
        /// </summary>
        /// <param name="name" value="int"></param>
        /// <returns name="product" value="Product"></returns>
        public override BaseRow findById(int id)
        {
            return (Product)database.findById(PRODUCT, id);
        }

        /// <summary>
        /// tim category theo name
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns name="product" value="Product"></returns>
        public Product findByName(string name)
        {
            return (Product)database.findByName(PRODUCT, name);
        }
    }
}
