using PharmacyManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class F_PhieuNhapHang : Form
    {
        KhoDAO khoDAO = new KhoDAO();
        public F_PhieuNhapHang()
        {
            InitializeComponent();
            LoadCBB();
        }
        public void LoadCBB()
        {
            cbb_MaCH.DataSource = khoDAO.LoadCbbMaCuaHang();
            cbb_MaCH.DisplayMember = "MaCuaHang";
            cbb_MaCH.SelectedIndex = -1;
            cbb_MNCC.DataSource = khoDAO.LoadCbbMaNCC();
            cbb_MNCC.DisplayMember = "MaNCC";
            cbb_MNCC.SelectedIndex = -1;
        }
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            KhoDAO kDAO = new KhoDAO();
            DataTable dt = kDAO.LoadNhapHang();
            dataGridView1.DataSource = dt;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string format = "dd/MM/yyyy";
            DateTime hsd;
            DateTime nsx;
            DateTime.TryParseExact(txt_hsd.Text, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out hsd);
            DateTime.TryParseExact(txt_nsx.Text, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out nsx);
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara = khoDAO.LoadPhieuNhap(hsd.ToString(), nsx.ToString(), txt_SoLuong.Text, txt_Gia1SP.Text, cbb_MNCC.Text.ToString(), txt_MaSP.Text.ToString(), cbb_MaCH.Text.ToString());
            khoDAO.ThemPhieuNhap(lstpara);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_MaCH.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            cbb_MNCC.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            txt_MaSP.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txt_hsd.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            txt_nsx.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            txt_SoLuong.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txt_Gia1SP.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
        }
    }
}
