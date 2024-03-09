using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.DAO
{
   public class HoaDonDAO
    {
        DataBase db = new DataBase();

        public DataTable HienThiHoaDon(string maHD)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@maHoaDon",
                value = maHD

            });
            return db.SelectData("proc_GetHoaDonSummary",lstpara);
        }
        public string TongTienCuoi(string maHD)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@maHoaDon",
                value = maHD

            });
            return db.SelectData("proc_GetLastSumHD", lstpara).Rows[0]["TongTien"].ToString() ;
        }
        public int TaoHoaDon(string maKH, string maNV)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();

            lstpara.Add(new CustomParameter()
            {
                key = "@MaKH",
                value = maKH

            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaNV",
                value = maNV

            });
           
            return db.ExcuteSQL("insert into HOA_DON(MaKhachHang, MaNhanVien) values(@MaKH , @MaNV)", lstpara);

        }
        public string MaMoiTao()
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            return db.LoadData("load", "SELECT dbo.GetMaxHoaDon() AS MaHoaDonMoiNhat;").Rows[0]["MaHoaDonMoiNhat"].ToString();

        }
        public void CapNhapDiemTich(string maHd, int diem)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@MaHD",
                value = maHd

            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Diem",
                value = diem

            });
            db.SelectData("proc_TruDiemTich", lstpara);
        }
    }
}
