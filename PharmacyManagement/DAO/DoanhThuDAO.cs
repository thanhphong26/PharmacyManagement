using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement.DAO
{
    public class DoanhThuDAO
    {
        DataBase db = new DataBase();
        public DataTable LoadCbbMaCuaHang()
        {
            return db.LoadData("load", "select MaCuaHang from CUA_HANG ");
        }
        public DataTable LoadHDBan(string macuahang, string thang, string nam)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@MaCuaHang",
                value = macuahang,
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Thang",
                value = thang,
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Nam",
                value = nam,
            });
            return db.SelectData("proc_Ds_Ban", lstpara);
        }
        public DataTable LoadHDNhap(string macuahang, string thang, string nam)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@MaCuaHang",
                value = macuahang,
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Thang",
                value = thang,
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Nam",
                value = nam,
            });
            return db.SelectData("proc_DsNhap", lstpara);
        }
    }
}
