using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public class PhieuNhapDAO
    {
        DataBase db=new DataBase();
        public DataTable ThongKeNhapHang(String ngayBatDau, String ngayKetThuc, String maCuaHang)
        {
           /* ngayBatDau=ngayBatDau.Date;
            ngayKetThuc=ngayKetThuc.Date;*/

            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@Begin",
                value = ngayBatDau
            }) ; 
            lstpara.Add(new CustomParameter()
            {
                key = "@End",
                value = ngayKetThuc
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaCuaHang",
                value = maCuaHang

            });
            return db.SelectData("proc_ThongKeNhapHang", lstpara);
        }
        public DataTable DSHoaDon(String ngayBatDau, String ngayKetThuc, String maCuaHang)
        {

            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@Begin",
                value = ngayBatDau
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@End",
                value = ngayKetThuc
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaCuaHang",
                value = maCuaHang

            });
            return db.SelectDataViews("SELECT * FROM DanhSachHoaDon WHERE NgayBan > @Begin AND NgayBan < @End AND MaCuaHang = @MaCuaHang", lstpara);
        }
    }
}
