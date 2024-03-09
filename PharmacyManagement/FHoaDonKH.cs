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
    public partial class FHoaDonKH : Form
    {
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        public FHoaDonKH(string maHD, string tenCh, string tenNV, string tenKH, int tienGiam, string tongTien)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.DataSource = hoaDonDAO.HienThiHoaDon(maHD);
            lbTongTienCuoi.Text = hoaDonDAO.TongTienCuoi(maHD) + "vnd";
            lbTenKH.Text = tenKH;
            lbTenNV.Text = tenNV;
            lbTenCuaHang.Text = tenCh;
            lbTongGiam.Text = tienGiam.ToString() +"vnd";
            lbTongTien.Text = tongTien + "vnd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
