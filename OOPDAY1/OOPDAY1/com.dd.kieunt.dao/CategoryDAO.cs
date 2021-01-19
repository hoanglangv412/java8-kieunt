using OOPDAY1.com.dd.kieunt.entity;
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
        /// <returns value="IEntity"></returns>
        public override IEntity findById(int id)
        {
            return database.findById(Database.getCategoryName(), id);
        }

        /// <summary>
        /// tim baserow theo name
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns value="IEntity"></returns>
        public override IEntity findByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
