using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.entity
{
    public class Product:BaseRow
    {
        private int categoryId;

        public Product():base() { }
        public Product(int id, string name,int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }
        public int getCategoryId()
        {
            return this.categoryId;
        }
        public void setCategoryId(int categoryId)
        {
            this.categoryId = categoryId;
        }
    }
}
