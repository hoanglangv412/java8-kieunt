using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    public abstract class BaseRowDAO
    {
        //Database database = new Database();
        const string productName = "product";
        const string categoryName = "category";
        const string accessoryName = "accessory";

        public abstract bool Insert(BaseRow row);
        public abstract bool Update(BaseRow row);
        public abstract bool Delete(BaseRow row);
        public abstract List<object> findAll();
    }
}
