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
using System.Windows.Markup;


namespace PharmacyManagement
{
    public partial class FMain : Form
    {
        
        private String msnv = null;
        private String mch = null;
        public String MSNV
        {
            get { return msnv; }
            set { msnv = value;}
        }
        public string MCH
        {
            get { return mch; }
            set { mch = value; }
        }
        AddClass addClass = new AddClass();
        public FMain(string msnv )
        {
            InitializeComponent();
            //btn_TTCN.Hide();
        }
        private void reset_color()
        {
            btn_TrangChu.BackColor = btn_TTCN.BackColor= btn_QLKH.BackColor= btn_BanHang.BackColor = btn_LSGD.BackColor= btn_NhanVien.BackColor= btn_DoanhThu.BackColor= Color.FromArgb(9, 38, 82);
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btn_MinSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            reset_color();
            btn_NhanVien.BackColor = Color.FromArgb(138,164,249);
            addClass.Add_Form( new F_QLNhanVien(), pn_main);
        }

        private void btn_TTCN_Click(object sender, EventArgs e)
        {
            reset_color();
            btn_TTCN.BackColor = Color.FromArgb(138,164,249);
            addClass.Add_Form(new F_ThongTinCaNhan(), pn_main);
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            reset_color();
            btn_TrangChu.BackColor = Color.FromArgb(138,164,249);
            addClass.Add_Form(new F_TrangChu(), pn_main);
        }
        
        private void FMain_Load(object sender, EventArgs e)
        {
            btn_TrangChu_Click(sender, e);
        }

        private void btn_LSGD_Click(object sender, EventArgs e)
        {
            reset_color();
            btn_LSGD.BackColor = Color.FromArgb(138,164,249);
            addClass.Add_Form(new F_LSGiaoDich(), pn_main);
        }

        private void btn_QLKH_Click(object sender, EventArgs e)
        {
            reset_color();
            btn_QLKH.BackColor = Color.FromArgb(138,164,249);
            addClass.Add_Form(new F_QuanLyKhoHang(), pn_main);
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            reset_color();
            btn_DoanhThu.BackColor = Color.FromArgb(138,164,249);
            addClass.Add_Form(new F_DoanhThu(), pn_main);
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            reset_color();
            btn_BanHang.BackColor = Color.FromArgb(138,164,249);
            addClass.Add_Form(new F_BanHang(), pn_main);
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất không!", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Hide();
                FLogin fLogin = new FLogin();
                fLogin.ShowDialog();
            }
        }
    }
}
