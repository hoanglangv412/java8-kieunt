using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    public interface IDao
    {
        public bool Insert(string name, BaseRow row);
        public bool Update(string name, BaseRow row);
        public bool Delete(string name, BaseRow row);
        public void findAll();
        public void findOneTable(string name);
        public BaseRow findById(int id);
    }
}
