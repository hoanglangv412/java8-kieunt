using OOPDAY1.com.dd.kieunt.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDAY1.com.dd.kieunt.dao
{
    class AccessoryDAO : BaseRowDAO
    {
        const string accessoryName = "accessory";
        Database database = new Database();

        /// <summary>
        /// them vao danh sach
        /// </summary>
        /// <param name="row" value="object"></param>
        /// <returns name="checkAction" value="bool"></returns>
        public override bool Insert(BaseRow row)
        {
            bool checkAction = false;
            if (database.insertTable(accessoryName, row) == 1) checkAction = true;

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
            if (database.updateTable(accessoryName, row) == 1) checkAction = true;

            return checkAction;
        }

        /// <summary>
        /// xoa 1 phan tu trong danh sach
        /// </summary>
        /// <param name="row" value="object"></param>
        /// <returns name="checkAction" value="bool"></returns>
        public override bool Delete(BaseRow row)
        {
            bool checkAction = false;
            if (database.deleteTable(accessoryName, row)) checkAction = true;

            return checkAction;
        }

        /// <summary>
        /// lay toan bo danh sach
        /// </summary>
        public override List<object> findAll()
        {
            List<object> returnList = new List<object>();
            foreach (Accessory item in database.accessoryTable)
            {
                returnList.Add(item);
            }
            return returnList;
        }

        /// <summary>
        /// tim category theo id
        /// </summary>
        /// <param name="name" value="int"></param>
        /// <returns name="accessory" value="Accessory"></returns>
        public Accessory findById(int name)
        {
            Accessory accessory = new Accessory();
            foreach (Accessory item in database.accessoryTable)
            {
                if(item.id == name)
                {
                    accessory = item;
                }
            }

            return accessory;
        }

        /// <summary>
        /// tim category theo name
        /// </summary>
        /// <param name="name" value="string"></param>
        /// <returns name="accessory" value="Accessory"></returns>
        public Accessory findByName(string name)
        {
            Accessory accessory = new Accessory();
            foreach (Accessory item in database.accessoryTable)
            {
                if (item.name == name)
                {
                    accessory = item;
                }
            }

            return accessory;
        }
    }
}
