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
  public  class StationaryService
    {
        public static List<StationaryModel> Get()
        {
            var data = DataAccessFactory.GetStationaryDataAccess().Get();
            var rdata = new List<StationaryModel>();

            foreach (var item in data)
            {
                rdata.Add(new StationaryModel()
                {
                    Item_Id = item.Item_Id,
                   Item_Name = item.Item_Name,
                    Item_Price = item.Item_Price,
                    Quantity = item.Quantity,

                });

            }
            return rdata;
        }

        public static StationaryModel Get(int id)
        {
            var data = DataAccessFactory.GetStationaryDataAccess().Get(id);
            var rdata = new StationaryModel();
            rdata.Item_Id = data.Item_Id;
            rdata.Item_Name = data.Item_Name;
            rdata.Item_Price = data.Item_Price;
            rdata.Quantity = data.Quantity;

            return rdata;
        }

        public static bool Create(StationaryModel item)
        {
            var stationary = new Stationary_Table()
            {
                Item_Name = item.Item_Name,
                Item_Price = item.Item_Price,
                Quantity = item.Quantity,

            };
            return DataAccessFactory.GetStationaryDataAccess().Create(stationary);
        }

        public static bool Update(StationaryModel item)
        {
            var stationary = new Stationary_Table()
            {
                Item_Id = item.Item_Id,
                Item_Name = item.Item_Name,
                Item_Price = item.Item_Price,
                Quantity = item.Quantity,
                

            };
            return DataAccessFactory.GetStationaryDataAccess().Update(stationary);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetStationaryDataAccess().Delete(id);
            return data;
        }


    }
}

