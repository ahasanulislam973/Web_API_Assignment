using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BOs
{
    public class InventoryModel
    {
        public int Book_Id { get; set; }
        public string Book_Name { get; set; }
        public string Author_Name { get; set; }
        public string Edition { get; set; }
        public Nullable<int> Count { get; set; }
        public string Student_Id { get; set; }
    }
}
