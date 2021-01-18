using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.entity;
using OOPDAY1.com.dd.kieunt.entity.abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo
{
    class AccessoryDAODemo
    {
        AccessoryDAO accessoryDAO = new AccessoryDAO();
        public string insertTest(Accessory row)
        {
            if (accessoryDAO.Insert(DatabaseAbstracts.getAccessoryName(), row)){
                return "SUCCESS";
            }
            return "FAIL";
        }

        public string updateTest(Accessory row)
        {
            if (accessoryDAO.Update(DatabaseAbstracts.getAccessoryName(), row))
            {
                return "SUCCESS";
            }
            return "FAIL";
        }

        public string deleteTest(Accessory row)
        {
            if (accessoryDAO.Delete(DatabaseAbstracts.getAccessoryName(), row))
            {
                return "SUCCESS";
            }
            return "FAIL";
        }

        public List<BaseRow> findAllTest(string name)
        {
            return accessoryDAO.findAll(name);
        }

        public BaseRow findByIdTest(int id)
        {
            return accessoryDAO.findById(id);
        }

        public Accessory findByNameTest(string name)
        {
            return (Accessory)accessoryDAO.findByName(name);
        }
    }
}
