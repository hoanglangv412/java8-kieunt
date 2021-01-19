using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.dao.abstracts;
using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    class CategoryDaoDemo
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        public string insertTest(Category row)
        {
            if (categoryDAO.Insert(Database.getCategoryName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public string updateTest(Category row)
        {
            if (categoryDAO.Update(Database.getCategoryName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public string deleteTest(Category row)
        {
            if (categoryDAO.Delete(Database.getCategoryName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }
        public List<IEntity> findAllTest(string name)
        {
            return categoryDAO.findAll(name);
        }
        public IEntity findByIdTest(int id)
        {
            return categoryDAO.findById(id);
        }
    }
}
