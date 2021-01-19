using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.entity
{
    public interface IEntity
    {
        public int getId();

        public void setId(int id);

        public string getName();

        public void setName(string name);
    }
}
