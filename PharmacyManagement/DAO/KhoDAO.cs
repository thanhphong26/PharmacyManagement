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
            return db.LoadData("load", "select MaCuaHang from CUA_HANG");
        }
        public int InsertLoaiSP(List<CustomParameter> list)
        {
            return db.Excute("pro_ThemLoai", list);
        }

        public int DeleteLoaiSP(List<CustomParameter> list)
        {
            return db.Excute("pro_XoaLoai", list);
        }

        public int UpdateLoaiSP(List<CustomParameter> list)
        {
            return db.Excute("pro_SuaLoai", list);
        }

        public int DeleteNSX(List<CustomParameter> list)
        {
            return db.Excute("pro_XoaNSX", list);
        }

        public int UpdateNSX(List<CustomParameter> list)
        {
            return db.Excute("pro_SuaNSX", list);
        }
        public int UpdateLoSP(List<CustomParameter> list)
        {
            return db.Excute("pro_SuaLo", list);
        }
        public int DeleteLoSP(List<CustomParameter> list)
        {
            return db.Excute("pro_XoaLo", list);
        }
        public int UpdateNhaCC(List<CustomParameter> list)
        {
            return db.Excute("pro_SuaNhaCC", list);
        }
        public int DeleteNhaCC(List<CustomParameter> list)
        {
            return db.Excute("pro_XoaNhaCC", list);
        }
        public int UpdateSP(List<CustomParameter> list)
        {
            return db.Excute("pro_SuaSP", list);
        }
        public int DeleteSP(List<CustomParameter> list)
        {
            return db.Excute("pro_XoaSP", list);
        }
        public DataTable LoadCbbMaLoai()
        {
            return db.LoadData("load", "select * from LOAI_SAN_PHAM");
        }
        public DataTable LoadNSX()
        {
            return db.LoadData("load", "select * from NHA_SAN_XUAT");
        }
        public DataTable LoadNCC()
        {
            return db.LoadData("load", "select * from NHA_CUNG_CAP");
        }

        public DataTable LoadSanPham()
        {
            return db.LoadData("load", "select * from SAN_PHAM");
        }
        public DataTable LoadNhapHang()
        {
            return db.LoadData("load", "exec PhieuNhapHang");
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
            return db.Excute("proc_ThemSanPham", lstpara);
        }
        public int ThemNhaCungCap(List<CustomParameter> lstpara)
        {
            return db.Excute("proc_ThemNhaCungCap", lstpara);
        }
        public int ThemNhaSanXuat(List<CustomParameter> lstpara)
        {
            return db.Excute("proc_ThemNhaSanXuat", lstpara);
        }
        public DataTable LoadCbbMaNCC()
        {
            return db.LoadData("load", "select MaNCC from NHA_CUNG_CAP");
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

        public List<CustomParameter> LoadThemNhaCungCap(string mancc, string tenncc, string diachi, string sdt)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@MaNCC",
                value = mancc
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@TenNCC",
                value = tenncc
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = diachi
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@SDT",
                value = sdt
            });

            return lstpara;
        }
        public List<CustomParameter> LoadThemNhaSanXuat(string mansx, string tennsx, string diachi)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@MaNSX",
                value = mansx
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@TenNSX",
                value = tennsx
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = diachi
            });


            return lstpara;
        }
    }
}
