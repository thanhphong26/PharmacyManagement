using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DataRow SelectKH_By_SDT(string sdt)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();

            lstpara.Add(new CustomParameter()
            {
                key = "@SDT",
                value = sdt

            });
            DataTable dt = db.SelectDataViews("   select KHACH_HANG.TenKhachHang , KHACH_HANG.MaKhachHang,  KHACH_HANG.DiaChi , KHACH_HANG.SDT,KHACH_HANG.DiaChi,THE_TICH_DIEM.Diem,THE_TICH_DIEM.MaThe " +
                "from KHACH_HANG left join THE_TICH_DIEM on KHACH_HANG.MaKhachHang= THE_TICH_DIEM.MaKhachHang " +
                "where KHACH_HANG.SDT= @SDT", lstpara);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else return null;

            
        }
        public void AddKHandHoaDon(string maNV ,string sdt , string tenKH, string diaChi)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
       
            lstpara.Add(new CustomParameter()
            {
                key = "@maNV",
                value = maNV

            });
            lstpara.Add(new CustomParameter()
            {
                key = "@txtSDT",
                value = sdt

            });

            lstpara.Add(new CustomParameter()
            {
                key = "@txtTenKH ",
                value = tenKH

            });
            lstpara.Add(new CustomParameter()
            {
                key = "@txtDiaChi ",
                value = diaChi

            });
            db.SelectData("pro_transaction_Khach_HoaDon",lstpara);
        }
        public string MaMoiTao()
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            return db.SelectData("SELECT dbo.GetMaxKhachHang() AS MaKHMoiNhat", lstpara).Rows[0]["MaKHMoiNhat"].ToString();

        }
        public int AddKh(string tenKH , string diaChi,string sdt) 
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();

            lstpara.Add(new CustomParameter()
            {
                key = "@Ten",
                value = tenKH

            });
            lstpara.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = diaChi

            });

            lstpara.Add(new CustomParameter()
            {
                key = "@SDT",
                value = sdt

            });
            
            return db.ExcuteSQL("insert into KHACH_HANG(TenKhachHang, DiaChi, SDT) values(@Ten, @DiaChi, @SDT)", lstpara); 
            
        }
    }
}
