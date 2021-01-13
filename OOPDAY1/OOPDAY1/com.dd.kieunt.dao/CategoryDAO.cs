using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    class CategoryDAO
    {
        /// <summary>
        /// them category
        /// </summary>
        /// <param name="row" value="category"></param>
        /// <returns name="flag" value="bool"></returns>
        public bool insertCategory(Category row)
        {
            bool flag = false;
            Database database = new Database();
            if(database.insertTable("category", row) == 1) flag = true;
            return flag;
        }
    }
}
