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
    public class RegService { 
    public static List<Reg> Get()
        { 
        var data = DataAccessFactory.GetUserDataAccess().Get();
        var rdata = new List<Reg>();
        foreach (var item in data)
        {
            rdata.Add(new Reg()
            {
                Id = item.Id,
                Username = item.Username,
                Password = item.Password,
                Type = item.Type

            });
        }
        return rdata;
    }
    public static bool Create(Reg item)
    {
        var student = new Login_Table()
        {
            Id = item.Id,
            Username = item.Username,
            Password = item.Password,
            Type = item.Type

        };
        return DataAccessFactory.GetUserDataAccess().Create(student);
    }
}
}
