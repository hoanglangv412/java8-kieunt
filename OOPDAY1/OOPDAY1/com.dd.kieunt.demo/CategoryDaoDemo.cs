using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    class CategoryDaoDemo
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        const string CATEGORY = "category";
        public string insertTest(BaseRow row)
        {
            if (categoryDAO.Insert(CATEGORY, row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public string updateTest(BaseRow row)
        {
            if (categoryDAO.Update(CATEGORY, row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public string deleteTest(BaseRow row)
        {
            if (categoryDAO.Delete(CATEGORY, row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }
        public void findAllTest()
        {
            categoryDAO.findAll();
        }
        public BaseRow findByIdTest(int id)
        {
            return categoryDAO.findById(id);
        }
        public Category findByNameTest(string name)
        {
            return (Category)categoryDAO.findByName(name);
        }
    }
}
