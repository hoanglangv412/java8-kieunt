using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.entity
{
    public class Accessory
    {
        public int accessoryId { get; set; }
        public string name { get; set; }
        public Accessory() { }
        public Accessory(int accessoryId, string name)
        {
            this.accessoryId = accessoryId;
            this.name = name;
        }
    }
}
