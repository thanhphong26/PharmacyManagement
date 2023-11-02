using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement
{
    public class CuaHangDAO
    {
        DataBase db=new DataBase();
        public DataTable DS_CuaHang()
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            return db.LoadData("load","select MaCuaHang from CUA_HANG");
        }
        
    }
}
