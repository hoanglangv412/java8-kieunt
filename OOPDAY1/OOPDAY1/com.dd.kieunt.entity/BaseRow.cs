using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.entity
{
    public abstract class BaseRow
    {
        public int id;
        public string name;
        public BaseRow(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public BaseRow() { }
    }
}
