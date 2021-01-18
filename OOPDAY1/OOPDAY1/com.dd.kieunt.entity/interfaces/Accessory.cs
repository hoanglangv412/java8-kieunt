using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.entity.interfaces
{
    public class Accessory : IEntity
    {
        private int id;
        private string name;
        public Accessory() { }
        public Accessory(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

    }
}
