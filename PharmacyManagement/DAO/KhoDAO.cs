using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.DAO
{
    public class KhoDAO
    {
        DataBase db = new DataBase();
        public DataTable LoadCbbMaCuaHang()
        {
            return db.LoadData("load", "exec AllMaCuaHang");
        }
        public DataTable LoadCbbMaLoai()
        {
            return db.LoadData("load", "select MaLoai from LOAI_SAN_PHAM");
        }
        public DataTable LoadCbbMaNSX()
        {
            return db.LoadData("load", "select MaNSX from NHA_SAN_XUAT");
        }
        public DataTable LoadDgvKho(string macuahang)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@MaCuaHang",
                value = macuahang,
            });
            return db.SelectData("SanPhamTrongKho", lstpara);
        }
        public DataTable LoadDsSapHetHan(string macuahang)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@MaCuaHang",
                value = macuahang,
            });
            return db.SelectData("DsSapHetHan", lstpara);
        }
        public int ThemPhieuNhap(List<CustomParameter> lstpara)
        {
            return db.Excute("ThemPhieuNhap", lstpara);
        }
        public int ThemSanPham(List<CustomParameter> lstpara)
        {
            return db.Excute("ThemSanPham", lstpara);
        }
        public DataTable LoadCbbMaNCC()
        {
            return db.LoadData("load", "exec AllMaNCC");
        }
        public List<CustomParameter> LoadPhieuNhap(string hsd, string ngaysx, string soluong, string giamotsp, string mancc, string masp, string mach)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@HSD",
                value = hsd
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@NSX",
                value = ngaysx
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@SoLuong",
                value = soluong
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@GiaMotSP",
                value = giamotsp
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaNCC",
                value = mancc
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaSP",
                value = masp
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaCuaHang",
                value = mach
            });
            return lstpara;
        }
        public List<CustomParameter> LoadThemSanPham(string masp, string tensp, string donvi, string giaban, string chucnang, string mota, string maloai, string mansx, object image)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@MaSP",
                value = masp
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@TenSP",
                value = tensp
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@DonVi",
                value = donvi
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@GiaBan",
                value = giaban
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@ChucNang",
                value = chucnang
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MoTa",
                value = mota
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaLoai",
                value = maloai
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaNSX",
                value = mansx
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Image",
                value = image
            });
            return lstpara;
        }
    }
}
