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
        String MCH = null;
        public String MSNV
        {
            get { return msnv; }
            set { msnv = value;}
        }
        AddClass addClass = new AddClass();
        public FMain()
        {
            InitializeComponent();
            
        }
        private void reset_color()
        {
            btn_TrangChu.BackColor = btn_TTCN.BackColor= btn_QLKH.BackColor= btn_BanHang.BackColor = btn_NhapHang.BackColor= btn_LSGD.BackColor= btn_NhanVien.BackColor= btn_DoanhThu.BackColor= Color.FromArgb(200, 255, 255);
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
            btn_NhanVien.BackColor = Color.FromArgb(0, 255, 255);
            addClass.Add_Form(new F_QLNhanVien(), pn_main);
        }

        private void btn_TTCN_Click(object sender, EventArgs e)
        {
            reset_color();
            btn_TTCN.BackColor = Color.FromArgb(0, 255, 255);
            addClass.Add_Form(new F_TTCaNhan(), pn_main);
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            reset_color();
            btn_TrangChu.BackColor = Color.FromArgb(0, 255, 255);
            //addClass.Add_Form(new F_TrangChu(), pn_main);
        }
        
        private void FMain_Load(object sender, EventArgs e)
        {
            btn_TrangChu_Click(sender, e);
        }

        private void btn_LSGD_Click(object sender, EventArgs e)
        {
            reset_color();
            btn_TTCN.BackColor = Color.FromArgb(0, 255, 255);
            addClass.Add_Form(new F_LSGiaoDich(), pn_main);
        }
    }
}
