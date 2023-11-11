using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.DAO
{
    public class KhachHangDAO
    {
        DataBase db = new DataBase();
        public DataTable DanhSachKhachHang()
        {
            return db.SelectDataViews("select * from v_DanhSachKhachHang", null);
        }
        public DataTable Tim(List<CustomParameter> list)
        {
            return db.SelectDataViews("SELECT * FROM func_TimKhachhang(@MaKhachHang, @TenKhachHang, @DiaChi, @SDT, @Diem)", list);
        }
    }
}
