using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class UserReg : IRepo<Login_Table, int, bool>
    {
        private Library_ManagementEntities4 db;

        public UserReg(Library_ManagementEntities4 db)
        {
            this.db = db;
        }
        public bool Create(Login_Table obj)
        {
            db.Login_Table.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            db.Login_Table.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<Login_Table> Get()
        {
            return db.Login_Table.ToList();
        }

        public Login_Table Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Login_Table obj)
        {
            throw new NotImplementedException();
        }
    }
}
