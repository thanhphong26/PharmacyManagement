using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class F_LSGiaoDich : Form
    {
        AddClass addClass = new AddClass();
        CuaHangDAO cuahang=new CuaHangDAO();
        DataBase db= new DataBase();    
        public F_LSGiaoDich()
        {
            InitializeComponent();
            LoadData(cb_CuaHang);
            LoadData(cb_CuaHangBH);
        }
        public void LoadData(ComboBox cbb)
        {
            cbb.DisplayMember = "MaCuaHang";
            cbb.DataSource = cuahang.DS_CuaHang();
        }
        private void btn_LocNhapKho_Click(object sender, EventArgs e)
        {
            PhieuNhapDAO phieuNhap=new PhieuNhapDAO();
            DataTable dt=new DataTable();
           // textBox1.Text= dt_NgayBD.Value.Date.ToString("yyyy-MM-dd");
            dt = phieuNhap.ThongKeNhapHang(dt_NgayBD.Value.Date.ToString("yyyy-MM-dd"), dt_NgayKT.Value.Date.ToString("yyyy-MM-dd"),cb_CuaHang.Text);
            addClass.Add_Form(new F_LSNhapKho(dt), pn_GiaoDich);

        }

        private void btn_LocBanHang_Click(object sender, EventArgs e)
        {
           string beginDate = dt_NgayBDBanHang.Value.Date.ToString("yyyy-MM-dd");
            string endDate=dt_NgayKTBanHang.Value.Date.ToString("yyyy-MM-dd");
            string maCH=cb_CuaHangBH.Text;
           
            PhieuNhapDAO phieuNhap = new PhieuNhapDAO();
            DataTable dt = new DataTable();
            // textBox1.Text= dt_NgayBD.Value.Date.ToString("yyyy-MM-dd");
            dt = phieuNhap.DSHoaDon(beginDate, endDate, maCH);
            addClass.Add_Form(new F_LSBanHang(dt), pn_GiaoDich);

           
        }
    }
}
