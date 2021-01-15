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
        private const string ACCESSORY = "accessory";
        public string insertTest(Accessory row)
        {
            if (accessoryDAO.Insert(ACCESSORY, row)){
                return "SUCCESS";
            }
            return "FAIL";
        }

        public string updateTest(Accessory row)
        {
            if (accessoryDAO.Update(ACCESSORY, row))
            {
                return "SUCCESS";
            }
            return "FAIL";
        }

        public string deleteTest(Accessory row)
        {
            if (accessoryDAO.Delete(ACCESSORY, row))
            {
                return "SUCCESS";
            }
            return "FAIL";
        }

        public void findAllTest()
        {
            accessoryDAO.findAll();
        }

        public BaseRow findByIdTest(int id)
        {
            return accessoryDAO.findById(id);
        }

        public Accessory findByNameTest(string name)
        {
            return accessoryDAO.findByName(name);
        }
    }
}
