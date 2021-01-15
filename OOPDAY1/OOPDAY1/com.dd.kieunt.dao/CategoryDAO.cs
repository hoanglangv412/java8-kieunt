using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    class CategoryDAO : IDao
    {
        Database database = Database.getInstance();
        private const string CATEGORY = "category";
        ///// <summary>
        ///// tim category theo id
        ///// </summary>
        ///// <param name="name" value="string"></param>
        ///// <returns value="BaseRow"></returns>
        //public override BaseRow findById(int id)
        //{
        //    return (BaseRow)database.findById(CATEGORY, id);
        //}

        ///// <summary>
        ///// tim category theo name
        ///// </summary>
        ///// <param name="name" value="string"></param>
        ///// <returns value="BaseRow"></returns>
        //public Category findByName(string name)
        //{
        //    return (Category)database.findByName(CATEGORY, name);
        //}
        public bool Delete(string name, BaseRow row)
        {
            if (database.deleteTable(name, row)) return true;

            return false;
        }

        public void findAll()
        {
            database.printTable();
        }

        public BaseRow findById(int id)
        {
            return (BaseRow)database.findById(CATEGORY, id);
        }
        public BaseRow findByName(string name)
        {
            return (Category)database.findByName(CATEGORY, name);
        }

        public void findOneTable(string name)
        {
            database.printTable(name);
        }

        public bool Insert(string name, BaseRow row)
        {
            if (database.insertTable(name, row) == 1) return true;

            return false;
        }

        public bool Update(string name, BaseRow row)
        {
            if (database.updateTable(name, row) == 1) return true;

            return false;
        }
    }
}
