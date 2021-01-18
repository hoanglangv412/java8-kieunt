using OOPDAY1.com.dd.kieunt.entity;
using OOPDAY1.com.dd.kieunt.entity.abstracts;
using OOPDAY1.com.dd.kieunt.entity.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao.interfaces
{
    class ProductIDAO : IDao
    {
        DatabaseInterfaces database = DatabaseInterfaces.getInstance();

        /// <summary>
        /// xoa 1 phan tu theo danh sach 
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
        /// tra ve toan bo danh sach theo ten
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns value="List<IEntity>"></returns>
        public List<IEntity> findAll(string name)
        {
            return database.findOneTable(name);
        }

        /// <summary>
        /// tim product theo id
        /// </summary>
        /// <param name="id" value="id"></param>
        /// <returns value="IEntity"></returns>
        public IEntity findById(int id)
        {
            return (IEntity)database.findById(DatabaseInterfaces.getProductName(), id);
        }

        /// <summary>
        /// tim product theo name
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns value="IEntity"></returns>
        public IEntity findByName(string name)
        {
            return (IEntity)database.findByName(DatabaseInterfaces.getProductName(), name);
        }

        /// <summary>
        /// them vao danh sach 1 doi tuong truyen vao
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
        /// cap nhat danh sach voi 1 doi tuong truyen vao
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="IEntity"></param>
        /// <returns value="bool"></returns>
        public bool Update(string name, IEntity row)
        {
            if (database.updateTable(name, row) == 1) return true;

            return false;
        }
    }
}
