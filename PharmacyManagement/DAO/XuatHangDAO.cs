using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.DAO
{
    public class XuatHangDAO
    {
        DataBase db = new DataBase();
        public int AddXuatHang(string maLo, string maHD, int sl)

        {
            List<CustomParameter> lstpara = new List<CustomParameter>();

            lstpara.Add(new CustomParameter()
            {
                key = "@MaLo",
                value = maLo

            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaHd",
                value = maHD

            });

            lstpara.Add(new CustomParameter()
            {
                key = "@SoLuong",
                value = sl

            });

            return db.Excute("InsertXuatHang", lstpara);

        }
    }
}
