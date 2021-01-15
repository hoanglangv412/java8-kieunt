using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    class AccessoryDAO : BaseDAO
    {
        private const string ACCESSORY = "accessory";
        /// <summary>
        /// tim accessory theo id
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns value="BaseRow"></returns>
        public override BaseRow findById(int id)
        {
            return (BaseRow)database.findById(ACCESSORY, id);
        }

        /// <summary>
        /// tim accessory theo name
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns value="BaseRow"></returns>
        public Accessory findByName(string name)
        {
            return (Accessory)database.findByName(ACCESSORY, name);
        }
    }
}
