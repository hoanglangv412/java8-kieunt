using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    public abstract class BaseDAO : IDao
    {
        protected Database database = Database.getInstance();

        /// <summary>
        /// xoa phan tu
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="IEntity"></param>
        /// <returns value="bool"></returns>
        public bool Delete(string name, IEntity row)
        {
            if (database.deleteTable(name, row)) return true;

            return false;
        }

        /// <summary>
        /// them phan tu
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="IEntity"></param>
        /// <returns value="bool"></returns>
        public bool Insert(string name, IEntity row)
        {
            if (database.insertTable(name, row) == 1) return true;

            return false;
        }

        /// <summary>
        /// cap nhat phan tu
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="IEntity"></param>
        /// <returns value="bool"></returns>
        public bool Update(string name, IEntity row)
        {
            if (database.updateTable(name, row) == 1) return true;

            return false;
        }

        /// <summary>
        /// tra ve danh sach phan tu theo ten
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns value="List<IEntity>"></returns>
        public List<IEntity> findAll(string name)
        {
            return database.findOneTable(name);
        }

        public abstract IEntity findById(int id);

        public abstract IEntity findByName(string name);
    }
}
