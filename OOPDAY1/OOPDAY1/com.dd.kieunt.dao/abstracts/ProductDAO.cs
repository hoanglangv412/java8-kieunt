using OOPDAY1.com.dd.kieunt.entity;
using OOPDAY1.com.dd.kieunt.entity.abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    class ProductDAO : BaseDAO
    {
        /// <summary>
        /// tim product theo id
        /// </summary>
        /// <param name="id" value="int"></param>
        /// <returns value="BaseRow"></returns>
        public override BaseRow findById(int id)
        {
            return database.findById(DatabaseAbstracts.getProductName(), id);
        }

        /// <summary>
        /// tim product theo name
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns value="BaseRow"></returns>
        public BaseRow findByName(string name)
        {
            return database.findByName(DatabaseAbstracts.getProductName(), name);
        }
    }
}
