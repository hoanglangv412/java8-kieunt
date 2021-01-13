using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.entity
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int categoryId { get; set; }
        public Product() { }
        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }
    }
}
