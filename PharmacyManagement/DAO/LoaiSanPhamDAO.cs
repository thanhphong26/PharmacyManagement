using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.DAO
{
    public class LoaiSanPhamDAO
    {
        DataBase db = new DataBase();

        public DataTable selectAllLoai()
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            return db.SelectDataViews("SELECT * FROM LOAI_SAN_PHAM WHERE MaDanhMucChinh IS NOT NULL", lstpara);
        }
        public DataTable selectAllDanhMuc()
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            return db.SelectDataViews("SELECT * FROM LOAI_SAN_PHAM WHERE MaDanhMucChinh IS NULL", lstpara);
        }
        public DataTable selectAllLoaiByDanhMuc(string maDanhMuc)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@DanhMuc",
                value = maDanhMuc

            });
            return db.SelectDataViews("SELECT * FROM LOAI_SAN_PHAM WHERE  MaDanhMucChinh = @DanhMuc", lstpara);
        }
    }
}
