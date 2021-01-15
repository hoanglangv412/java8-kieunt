using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    public abstract class BaseDAO
    {
        protected Database database = Database.getInstance();

        /// <summary>
        /// them 1 phan tu vao danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="BaseRow"></param>
        /// <returns value="bool"></returns>
        public virtual bool Insert(string name,BaseRow row) {
            if (database.insertTable(name, row) == 1) return true;

            return false;
        }

        /// <summary>
        /// cap nhat 1 phan tu vao danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="BaseRow"></param>
        /// <returns value="bool"></returns>
        public virtual bool Update(string name,BaseRow row)
        {
            if (database.updateTable(name, row) == 1) return true;

            return false;
        }

        /// <summary>
        /// xoa 1 phan tu vao danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="BaseRow"></param>
        /// <returns value="bool"></returns>
        public virtual bool Delete(string name,BaseRow row)
        {
            if (database.deleteTable(name, row)) return true;

            return false;
        }

        /// <summary>
        /// in ra toan bo bang
        /// </summary>
        public virtual void findAll()
        {
            database.printTable();
        }

        /// <summary>
        /// in ra 1 bang theo ten
        /// </summary>
        /// <param name="name" value="string"></param>
        public virtual void findOneTable(string name)
        {
            database.printTable(name);
        }

        /// <summary>
        /// tim phan tu theo id
        /// </summary>
        /// <param name="id" value="int"></param>
        /// <returns></returns>
        public abstract BaseRow findById(int id);
    }
}
