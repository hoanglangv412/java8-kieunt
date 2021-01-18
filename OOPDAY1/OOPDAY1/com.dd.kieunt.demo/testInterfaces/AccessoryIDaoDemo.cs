using OOPDAY1.com.dd.kieunt.dao;
using OOPDAY1.com.dd.kieunt.dao.interfaces;
using OOPDAY1.com.dd.kieunt.entity;
using OOPDAY1.com.dd.kieunt.entity.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.demo.testInterfaces
{
    class AccessoryIDAODemo
    {
        AccessoryIDAO accessoryIDAO = new AccessoryIDAO();
        public string insertTest(Accessory row)
        {
            if (accessoryIDAO.Insert(DatabaseInterfaces.getAccessoryName(), row)){
                return "SUCCESS";
            }

            return "FAIL";
        }

        public string updateTest(Accessory row)
        {
            if (accessoryIDAO.Update(DatabaseInterfaces.getAccessoryName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public string deleteTest(Accessory row)
        {
            if (accessoryIDAO.Delete(DatabaseInterfaces.getAccessoryName(), row))
            {
                return "SUCCESS";
            }

            return "FAIL";
        }

        public List<IEntity> findAllTest(string name)
        {
            return accessoryIDAO.findAll(name);
        }

        public IEntity findByIdTest(int id)
        {
            return accessoryIDAO.findById(id);
        }

        public Accessory findByNameTest(string name)
        {
            return (Accessory)accessoryIDAO.findByName(name);
        }
    }
}
