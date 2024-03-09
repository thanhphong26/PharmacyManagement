using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.DAO
{
    public class ChucVuDAO
    {
        DataBase db = new DataBase();
        public DataTable DS_ChucVu()
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            return db.LoadData("load", "select * from CHUC_VU");
        }
    }
}
