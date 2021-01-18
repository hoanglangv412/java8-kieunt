using OOPDAY1.com.dd.kieunt.entity;
using OOPDAY1.com.dd.kieunt.entity.abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    class AccessoryDAO : BaseDAO
    {
        /// <summary>
        /// tim accessory theo id
        /// </summary>
        /// <param name="id" value="int"></param>
        /// <returns value="BaseRow"></returns>
        public override BaseRow findById(int id)
        {
            return (BaseRow)database.findById(DatabaseAbstracts.getAccessoryName(), id);
        }

        /// <summary>
        /// tim accessory theo name
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns value="BaseRow"></returns>
        public BaseRow findByName(string name)
        {
            return database.findByName(DatabaseAbstracts.getAccessoryName(), name);
        }
    }
}
