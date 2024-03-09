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
    public partial class F_QuanLyKhoHang : Form
    {
        KhoDAO khoDAO = new KhoDAO();
        AddClass addClass = new AddClass();
        public F_QuanLyKhoHang()
        {
            InitializeComponent();
        }
        private void khoHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClass.Add_Form(new F_KhoHang(), panel1);
        }

        private void LoaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClass.Add_Form(new F_LoaiSanPham(), panel1);

        }

        private void SanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClass.Add_Form(new F_ThemSanPham(), panel1);
        }

        private void nhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClass.Add_Form(new F_NhaCungCap(), panel1);
        }

        private void nhaSanXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClass.Add_Form(new F_NhaSanXuat(), panel1);
        }

        private void loSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addClass.Add_Form(new F_PhieuNhapHang(), panel1);
        }
    }
}
