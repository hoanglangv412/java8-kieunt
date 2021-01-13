using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    class CategoryDaoDemo
    {
        /// <summary>
        /// insert vao danh sach
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <param name="row" value="Category"></param>
        public void insertTest(string name,Category row)
        {
            Database database = new Database();
            database.insertTable("category",row);
        }
    }
}
