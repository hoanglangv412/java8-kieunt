using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.entity
{
    public class Product:BaseRow
    {
        public int categoryId;
        public Product():base() { }
        public Product(int id, string name, int categoryId) : base(id, name)
        {
            this.categoryId = categoryId;
        }
    }
}
