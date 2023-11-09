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
        private string role;
        FMain main = new FMain();
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
            if (rbtn_nv.Checked)
            {
                role = "CV01";
            }
            else if (rbtn_ql.Checked)
            {
                role = "CV02";
            }
            else
            {
                role = "CV03";
            }

                main.MSNV = txt_TaiKhoan.Text;


            //Kiểm tra đăng nhập
            //Lấy mã cửa hàng
            //Nhận Role
            main.MCH = "CH01";
                main.Show();
                this.Hide();
        }

    }
}
