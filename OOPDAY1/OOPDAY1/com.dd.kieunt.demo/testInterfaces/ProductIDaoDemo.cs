using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.dao.interfaces;
using OOPDAY1.com.dd.kieunt.entity;
using OOPDAY1.com.dd.kieunt.entity.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo.testInterfaces
{
    public class ProductIDAODemo
    {
        ProductIDAO productIDAO = new ProductIDAO();
        public ProductIDAODemo() { }
        public string insertTest(Product row)
        {
            if (productIDAO.Insert(DatabaseInterfaces.getProductName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public string updateTest(Product row)
        {
            if (productIDAO.Update(DatabaseInterfaces.getProductName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public string deleteTest(Product row)
        {
            if (productIDAO.Delete(DatabaseInterfaces.getProductName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public List<IEntity> findAllTest(string name)
        {
            return productIDAO.findAll(name);
        }

        public Product findByIdTest(int id)
        {
            return (Product)productIDAO.findById(id);
        }

        public Product findByNameTest(string name)
        {
            return (Product)productIDAO.findByName(name);
        }
    }
}
