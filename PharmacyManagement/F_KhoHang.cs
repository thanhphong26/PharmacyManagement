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
    public partial class F_KhoHang : Form
    {
        KhoDAO khoDAO = new KhoDAO();
        public F_KhoHang()
        {
            InitializeComponent();
            LoadCBB();
        }
        public void LoadCBB()
        {
            cbb_MaCH.DataSource = khoDAO.LoadCbbMaCuaHang();
            cbb_MaCH.DisplayMember = "MaCuaHang";
            cbb_MaCH.SelectedIndex = -1;
        }
        private void btn_qlykho_Tim_Click(object sender, EventArgs e)
        {

            KhoDAO kDAO = new KhoDAO();
            DataTable dt = kDAO.LoadDgvKho(cbb_MaCH.Text);
            dataGridView1.DataSource = dt;
            DataTable dt1 = kDAO.LoadDsSapHetHan(cbb_MaCH.Text);
            dataGridView2.DataSource = dt1;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
