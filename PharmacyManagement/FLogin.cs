using PharmacyManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    
    public partial class FLogin : Form
    {
        NhanVienDAO nhanvien = new NhanVienDAO();
        TaiKhoan taiKhoan = new TaiKhoan();
        public FLogin()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra đăng nhập
            //đúng
            GlobalData.UserName = txt_TaiKhoan.Text; // Lấy giá trị từ TextBox tên người dùng
            GlobalData.Password = txt_MatKhau.Text;
            bool isDataTableNull = (taiKhoan.KTTaiKhoanTonTai(txt_TaiKhoan.Text) == null || taiKhoan.KTTaiKhoanTonTai(txt_TaiKhoan.Text).Rows.Count == 0);
            if (!isDataTableNull)
            {
                if (taiKhoan.KTTaiKhoanTonTai(txt_TaiKhoan.Text).Rows[0]["MatKhau"].ToString() == txt_MatKhau.Text)
                {
                    FMain main = new FMain(txt_TaiKhoan.Text);
                    main.MSNV = txt_TaiKhoan.Text;
                    DataTable dt = nhanvien.ThongTinNhanVien(txt_TaiKhoan.Text);
                    GlobalData.MCH = dt.Rows[0][7].ToString();
                    GlobalData.MCV = dt.Rows[0]["MaChucVu"].ToString();
                    //MessageBox.Show(GlobalData.MCH );
                    main.Show();
                    this.Hide();
                } 
                else MessageBox.Show("Sai mat khau");
            }
            else MessageBox.Show("khong ton tai tai khoan nay ");
            
            //sai
           
        }
    }
}
