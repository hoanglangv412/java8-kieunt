using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    public class productDAODemo
    {
        ProductDAO productDAO = new ProductDAO();
        const string PRODUCT = "product";
        public productDAODemo() { }
        public void insertTest(BaseRow row)
        {
            productDAO.Insert(PRODUCT,row);
        }

        public void updateTest(BaseRow row)
        {
            productDAO.Update(PRODUCT,row);
        }

        public void deleteTest(BaseRow row)
        {
            productDAO.Delete(PRODUCT,row);
        }

        public void findAllTest()
        {
            productDAO.findAll();
        }

        public Product findByIdTest(int id)
        {
            return (Product)productDAO.findById(id);
        }

        public Product findByNameTest(string name)
        {
            return productDAO.findByName(name);
        }
    }
}
