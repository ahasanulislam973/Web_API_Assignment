using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
  public  class StationaryRepo : IRepo<Stationary_Table, int, bool>
    {
        Library_ManagementEntities4 db = new Library_ManagementEntities4();

        public StationaryRepo(Library_ManagementEntities4 db)
        {
            this.db = db;
        }
        //this is create
        public bool Create(Stationary_Table obj)
        {
            db.Stationary_Table.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

       
        public bool Delete(int Item_Id)
        {
            db.Stationary_Table.Remove(Get(Item_Id));
            db.SaveChanges();
            return true;
        }

        public List<Stationary_Table> Get()
        {
            return db.Stationary_Table.ToList();
        }

        public Stationary_Table Get(int id)
        {
            return db.Stationary_Table.SingleOrDefault(s => s.Item_Id == id);
        }

        public bool Update(Stationary_Table obj)
        {
            var exst = db.Stationary_Table.FirstOrDefault(s => s.Item_Id == obj.Item_Id);
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
