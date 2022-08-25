using BLL.BOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class InventoryService
    {
        public static List<InventoryModel> Get()
        {
            var data = DataAccessFactory.GetInventoryDataAccess().Get();
            var rdata = new List<InventoryModel>();

            foreach (var item in data)
            {
                rdata.Add(new InventoryModel()
                {
                    Book_Id = item.Book_Id,
                    Book_Name = item.Book_Name,
                    Author_Name = item.Author_Name,
                    Edition = item.Edition,
                    Count = item.Count,
                    Student_Id = item.Student_Id,

                });

            }
            return rdata;
        }

        public static InventoryModel Get(int id)
        {
            var data = DataAccessFactory.GetInventoryDataAccess().Get(id);
            var rdata = new InventoryModel();
            rdata.Book_Id = data.Book_Id;
            rdata.Book_Name = data.Book_Name;
            rdata.Author_Name = data.Author_Name;
            rdata.Edition = data.Edition;
            rdata.Count = data.Count;
            rdata.Student_Id = data.Student_Id;


            return rdata;
        }



        public static bool Create(InventoryModel item)
        {
            var Book = new Inventory_Table()
            {
                Book_Id = item.Book_Id,
                Book_Name = item.Book_Name,
                Author_Name = item.Author_Name,
                Edition = item.Edition,
                Count = item.Count,
                Student_Id = item.Student_Id,

            };
            return DataAccessFactory.GetInventoryDataAccess().Create(Book);
        }

        public static bool Update(InventoryModel item)
        {
            var Inventory = new Inventory_Table()
            {
                Book_Id = item.Book_Id,
                Book_Name = item.Book_Name,
                Author_Name = item.Author_Name,
                Edition = item.Edition,
                Count = item.Count,
                Student_Id = item.Student_Id,


            };
            return DataAccessFactory.GetInventoryDataAccess().Update(Inventory);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetInventoryDataAccess().Delete(id);
            return data;
        }
    }
}
