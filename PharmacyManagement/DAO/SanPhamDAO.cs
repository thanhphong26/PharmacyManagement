using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.DAO
{
    public class SanPhamDAO
    {
        DataBase db = new DataBase();
        public DataTable SelectAll()
        {
            return db.LoadData("load", "Select * from SAN_PHAM");
        }
    }
}
