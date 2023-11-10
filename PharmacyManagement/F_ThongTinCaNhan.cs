using PharmacyManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class F_ThongTinCaNhan : Form
    {
        public F_ThongTinCaNhan()
        {
            InitializeComponent();
            txt_MNV.Enter += txt_MNV_Enter;
            txt_TenNV.Enter += txt_MNV_Enter;
            txt_SDT.Enter += txt_MNV_Enter;
            txt_DiaChi.Enter += txt_MNV_Enter;
            txt_TenCuaHang.Enter += txt_MNV_Enter;
            txt_ChucVu.Enter += txt_MNV_Enter;
            txt_MaCH.Enter += txt_MNV_Enter;
        }

        DataBase data = new DataBase();
        private string msnv = null;
        private FMain main;
        NhanVienDAO nhanvien = new NhanVienDAO();
        DataTable dt = new DataTable();

        public void SetFormReference(FMain form1)
        {
            main = form1;
        }
        private void F_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            msnv = main.MSNV;
            MessageBox.Show(msnv);
            dt = nhanvien.ThongTinNhanVien(msnv);
            DataRow dr = dt.Rows[0];
            txt_MNV.Text = dr[0].ToString();
            txt_TenNV.Text = dr[1].ToString();
            dtp_NgaySinh.Value = Convert.ToDateTime(dr[2]);
            txt_SDT.Text = dr[3].ToString();
            if (Convert.ToInt16(dr[4]) == 0)
                rdio_Nam.Checked = true;
            else
                rdio_Nu.Checked = true; 
            txt_DiaChi.Text = dr[5].ToString();
            txt_ChucVu.Text = dr[6].ToString();
            txt_TenCuaHang.Text = dr[7].ToString();
        }

        private void txt_MNV_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void control_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
        }
    }
}
