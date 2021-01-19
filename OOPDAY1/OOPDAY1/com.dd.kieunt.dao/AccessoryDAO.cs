using OOPDAY1.com.dd.kieunt.entity;
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
        /// <returns value="IEntity"></returns>
        public override IEntity findById(int id)
        {
            return database.findById(Database.getAccessoryName(), id);
        }

        /// <summary>
        /// tim accessory theo name
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns value="IEntity"></returns>
        public override IEntity findByName(string name)
        {
            return database.findByName(Database.getAccessoryName(), name);
        }
    }
}
