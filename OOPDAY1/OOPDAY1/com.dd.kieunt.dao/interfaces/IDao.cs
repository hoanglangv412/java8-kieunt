using OOPDAY1.com.dd.kieunt.entity.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    public interface IDao
    {
        public bool Insert(string name, IEntity row);
        public bool Update(string name, IEntity row);
        public bool Delete(string name, IEntity row);
        public List<IEntity> findAll(string name);
        public IEntity findById(int id);
        public IEntity findByName(string name);
    }
}
