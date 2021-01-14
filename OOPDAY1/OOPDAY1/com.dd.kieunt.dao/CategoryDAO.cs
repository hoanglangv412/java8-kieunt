using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    class CategoryDAO : BaseRowDAO
    {
        const string categoryName = "category";
        Database database = new Database();

        /// <summary>
        /// xoa 1 phan tu trong danh sach
        /// </summary>
        /// <param name="row" value="object"></param>
        /// <returns name="checkAction" value="bool"></returns>
        public override bool Delete(BaseRow row)
        {
            bool checkAction = false;
            if (database.deleteTable(categoryName, row)) checkAction = true;

            return checkAction;
        }

        /// <summary>
        /// lay toan bo danh sach
        /// </summary>
        public override List<object> findAll()
        {
            List<object> returnList = new List<object>();
            foreach (Category item in database.categoryTable)
            {
                returnList.Add(item);
            }
            return returnList;
        }

        /// <summary>
        /// them vao danh sach
        /// </summary>
        /// <param name="row" value="object"></param>
        /// <returns name="checkAction" value="bool"></returns>
        public override bool Insert(BaseRow row)
        {
            bool checkAction = false;
            if (database.insertTable(categoryName, row) == 1) checkAction = true;

            return checkAction;
        }

        /// <summary>
        /// cap nhat vao danh sach
        /// </summary>
        /// <param name="row" value="object"></param>
        /// <returns name="checkAction" value="bool"></returns>
        public override bool Update(BaseRow row)
        {
            bool checkAction = false;
            if (database.updateTable(categoryName, row) == 1) checkAction = true;

            return checkAction;
        }
        /// <summary>
        /// tim phan tu theo id
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns name="category" value="Category"></returns>
        public Category findById(int name)
        {
            Category category = new Category();
            foreach(Category item in database.categoryTable)
            {
                if(item.id == name)
                {
                    category = item;
                }
            }

            return category;
        }
    }
}
