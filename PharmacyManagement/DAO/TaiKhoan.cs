using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagement.DAO
{
    public class TaiKhoan
    {
        DataBase db  = new DataBase();
        public void DoiMk(string userName , string mk )
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@userName",
                value = userName,
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@pass",
                value = mk,
            });
            db.ExcuteSQL("update TAI_KHOAN set MatKhau = @pass where TenDangNhap= @userName", lstpara);
        }
        public DataTable KTTaiKhoanTonTai(string userName)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@userName",
                value = userName,
            });
            return db.SelectDataViews("select * from TAI_KHOAN where TenDangNhap= @userName", lstpara);
            
        }
    }
}
