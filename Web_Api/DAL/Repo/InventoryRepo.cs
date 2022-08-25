using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class InventoryRepo : IRepo<Inventory_Table, int, bool>
    {
        Library_ManagementEntities4 db = new Library_ManagementEntities4();

        public InventoryRepo(Library_ManagementEntities4 db)
        {
            this.db = db;
        }
        //this is create
        public bool Create(Inventory_Table obj)
        {
            db.Inventory_Table.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

      

        public bool Delete(int id)
        {
            db.Inventory_Table.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<Inventory_Table> Get()
        {
            return db.Inventory_Table.ToList();
        }

        public Inventory_Table Get(int id)
        {
            return db.Inventory_Table.SingleOrDefault(s => s.Book_Id == id);
        }

        public bool Update(Inventory_Table obj)
        {
            var exst = db.Inventory_Table.FirstOrDefault(s => s.Book_Id == obj.Book_Id);
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}

