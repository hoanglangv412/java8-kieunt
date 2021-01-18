using OOPDAY1.com.dd.kieunt.entity;
using OOPDAY1.com.dd.kieunt.entity.abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao.abstracts
{
    class CategoryDAO : BaseDAO
    {
        /// <summary>
        /// tim baserow theo id
        /// </summary>
        /// <param name="id" value="int"></param>
        /// <returns value="BaseRow"></returns>
        public override BaseRow findById(int id)
        {
            return (BaseRow)database.findById(DatabaseAbstracts.getCategoryName(), id);
        }
    }
}
