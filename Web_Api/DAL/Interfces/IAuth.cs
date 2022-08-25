using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfces
{
   public interface IAuth<CLASS>
    {
        CLASS Authenticate(string username, string password);
    }
}
