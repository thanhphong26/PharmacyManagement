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
        public DataTable SelectAllByDanhMuc(string maDanhMuc)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();

            lstpara.Add(new CustomParameter()
            {
                key = "@MaDanhMuc",
                value = maDanhMuc
            });
            return db.SelectDataViews("Select * from SAN_PHAM join LOAI_SAN_PHAM on" +
                " SAN_PHAM.MaLoai = LOAI_SAN_PHAM.MaLoai and LOAI_SAN_PHAM.MaDanhMucChinh= @MaDanhMuc", lstpara);
        }
        public DataTable SelectAllByLoai(string maLoai)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();

            lstpara.Add(new CustomParameter()
            {
                key = "@MaLoai",
                value = maLoai

            });
            return db.SelectDataViews("Select * from SAN_PHAM join LOAI_SAN_PHAM on SAN_PHAM.MaLoai =  LOAI_SAN_PHAM.MaLoai where  SAN_PHAM.MaLoai = @MaLoai", lstpara);
        }
        public DataTable SelectAllByTuKhoa(string tuKhoa)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();

            lstpara.Add(new CustomParameter()
            {
                key = "@tuKhoa",
                value = tuKhoa

            });
            return db.SelectDataViews("select * from func_getProductListByString (@tuKhoa)", lstpara);
        }
        public DataTable Select1SP(string id ) 
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();

            lstpara.Add(new CustomParameter()
            {
                key = "@MaSp",
                value = id

            });
            return db.SelectDataViews("  select * from SAN_PHAM where MaSP= @MaSp", lstpara);
        }
    }
}
