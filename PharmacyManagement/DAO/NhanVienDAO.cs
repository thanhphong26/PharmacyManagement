using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.DAO
{
    public class NhanVienDAO
    {
        DataBase db=new DataBase();
        public DataTable DanhSachNhanVien(string mch)
        {
            string sql = "select * from v_DanhSachNhanVienCuaHang where MaCuaHang LIKE @tukhoa";
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter() { key = "@tukhoa", value = mch });
            return db.SelectDataViews(sql, parameters);
        }
        public DataTable ThongTinNhanVien(string mnv)
        {
            string sql = "select * from func_ThongTinNhanVien(@tukhoa)";
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter() { key = "@tukhoa", value = mnv });
            return db.SelectDataViews(sql, parameters);
        }
        public int Delete(string mnv)
        {
            List<CustomParameter> parameters = new List<CustomParameter> { new CustomParameter() { key = "@MaNV", value = mnv } };
            return db.Excute("proc_XoaNhanVien", parameters);
        }
        public int Update(List<CustomParameter> parameters)
        {
            return db.Excute("proc_CapNhatThongTinNhanVien", parameters);
        }
        public DataTable SearchMaCuaHangByMaNV(string mnv)
        {
            List<CustomParameter> parameters = new List<CustomParameter> { new CustomParameter() { key = "@MaNhanVien", value = mnv } };
            return db.SelectDataViews("Select * from Nhan_Vien where Nhan_Vien.MaNhanVien = @MaNhanVien", parameters);
        }
    }
}
