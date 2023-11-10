using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.DAO
{
    public class NhanVienDAO
    {
        DataBase db = new DataBase();
        public DataTable DanSachNhanVien(string mch)
        {
            string sql = "select * from v_DanhSachNhanVienCuaHang where MaCuaHang LIKE @tukhoa";
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter() { key = "@tukhoa", value = mch });
            return db.SelectDataViews(sql, parameters);
        }

        public DataTable ThongTinNhanVien(string mnv)
        {
            string sql = "select * from v_DanhSachNhanVienCuaHang where MaNhanVien = @tukhoa";
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter() { key = "@tukhoa", value = mnv });
            return db.SelectDataViews(sql, parameters);
        }

        public int Delete(string mnv)
        {
            List<CustomParameter> parameters =  new List<CustomParameter> { new CustomParameter() {key = "@MaNhanVien", value=mnv} };
            return db.Excute("proc_DeleteEmployee", parameters);
        }
        public int Update(List<CustomParameter> parameters)
        {
            return db.Excute("proc_CapNhatThongTinNhanVien", parameters);
        }
    }
}
