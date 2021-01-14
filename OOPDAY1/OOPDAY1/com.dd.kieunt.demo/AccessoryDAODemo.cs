using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    class AccessoryDAODemo
    {
        AccessoryDAO accessoryDAO = new AccessoryDAO();
        const string accessoryName = "accessory";
        public void insertTest(Accessory row)
        {
            accessoryDAO.Insert(row);
        }

        public void updateTest(Accessory row)
        {
            accessoryDAO.Update(row);
        }

        public void deleteTest(Accessory row)
        {
            accessoryDAO.Delete(row);
        }

        public void findAllTest()
        {
            accessoryDAO.findAll();
        }

        public void findByIdTest(int id)
        {
            accessoryDAO.findById(id);
        }

        public void findByNameTest(string name)
        {
            accessoryDAO.findByName(name);
        }
    }
}
