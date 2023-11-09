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
    public partial class F_QLNhanVien : Form
    {
        public F_QLNhanVien()
        {
            InitializeComponent();
        }
        private string mch;
        DataTable dt = null;
        DataBase db = null;
        private FMain main;
        public void SetForm1Reference(FMain form1)
        {
            main = form1;
        }
        private void reset ()
        {
            txt_MaNV.ResetText();
            txt_TenNV.ResetText();
            cb_MaCV.ResetText();
            rb_Nam.Checked = false;
            rb_Nu.Checked = false;
            td_NgaySinh.ResetText();
            txt_Diachi.ResetText();
            cb_MaCuaHang.ResetText();
            ptb_NhanVien.Image = null;
        }

        private void F_QLNhanVien_Load(object sender, EventArgs e)
        {
            reset(); 
            //string sql = "SELECT * FROM CHUC_VU";
            //dt = db.
            MessageBox.Show(main.MCH);
            if (mch !=null)
            {
                cb_MaCV.Enabled = false;
                cb_MaCuaHang.Enabled = false;
            }
            else 
            {
                
                cb_MaCV.Enabled = true;
                cb_MaCuaHang .Enabled = true;
            }

        }
    }
}
