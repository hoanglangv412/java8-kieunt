using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.entity
{
    public class Category
    {
        public int categoryId { get; set; }
        public string name { get; set; }
        public Category() { }
        public Category(int categoryId, string name)
        {
            this.categoryId = categoryId;
            this.name = name;
        }
    }
}
