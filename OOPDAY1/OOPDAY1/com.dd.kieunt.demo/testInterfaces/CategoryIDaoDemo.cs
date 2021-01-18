using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.dao.interfaces;
using OOPDAY1.com.dd.kieunt.entity;
using OOPDAY1.com.dd.kieunt.entity.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo.testInterfaces
{
    class CategoryIDaoDemo
    {
        CategoryIDAO categoryIDAO = new CategoryIDAO();
        public string insertTest(Category row)
        {
            if (categoryIDAO.Insert(DatabaseInterfaces.getCategoryName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public string updateTest(Category row)
        {
            if (categoryIDAO.Update(DatabaseInterfaces.getCategoryName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public string deleteTest(Category row)
        {
            if (categoryIDAO.Delete(DatabaseInterfaces.getCategoryName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }
        public List<IEntity> findAllTest(string name)
        {
            return categoryIDAO.findAll(name);
        }

        public IEntity findByIdTest(int id)
        {
            return categoryIDAO.findById(id);
        }
    }
}
