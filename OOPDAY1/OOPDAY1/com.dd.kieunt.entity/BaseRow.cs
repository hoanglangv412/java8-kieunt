using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.entity
{
    public abstract class BaseRow
    {
        private int id;
        private string name;

        public virtual int getId()
        {
            return this.id;
        }

        public virtual void setId(int id)
        {
            this.id = id;
        }

        public virtual string getName()
        {
            return this.name;
        }

        public virtual void setName(string name)
        {
            this.name = name;
        }

        public BaseRow(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public BaseRow() { }
    }
}
