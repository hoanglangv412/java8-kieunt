using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    class ProductDAODemo
    {
        ProductDAO productdao = new ProductDAO();
        public void insertTest(BaseRow row)
        {
            productdao.Insert(row);
        }

        public void updateTest(BaseRow row)
        {
            productdao.Update(row);
        }

        public void deleteTest(BaseRow row)
        {
            productdao.Delete(row);
        }

        public void findAllTest()
        {
            productdao.findAll();
        }

        public void findByIdTest(int id)
        {
            productdao.findById(id);
        }

        public void findByNameTest(string name)
        {
            productdao.findByName(name);
        }
    }
}
