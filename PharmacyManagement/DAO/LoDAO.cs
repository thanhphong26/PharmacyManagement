using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.DAO
{
    public class LoDAO
    {
        DataBase db = new DataBase();
        public DataTable SelectLoByMaSPAndCuaHang(string maCuaHang,string maSp)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
           
            lstpara.Add(new CustomParameter()
            {
                key = "@MaCuaHang",
                value = maCuaHang

            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaSP",
                value = maSp

            });
            return db.SelectData("sp_SelectLoByMaCuaHangMaSP", lstpara);
        }
    }
}
