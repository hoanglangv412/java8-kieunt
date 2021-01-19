using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    public class ProductDAODemo
    {
        ProductDAO productDAO = new ProductDAO();
        public ProductDAODemo() { }
        public string insertTest(Product row)
        {
            if (productDAO.Insert(Database.getProductName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public string updateTest(Product row)
        {
            if (productDAO.Update(Database.getProductName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public string deleteTest(Product row)
        {
            if (productDAO.Delete(Database.getProductName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public List<IEntity> findAllTest(string name)
        {
            return productDAO.findAll(name);
        }

        public Product findByIdTest(int id)
        {
            return (Product)productDAO.findById(id);
        }

        public Product findByNameTest(string name)
        {
            return (Product)productDAO.findByName(name);
        }
    }
}
