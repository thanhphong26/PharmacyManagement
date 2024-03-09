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
    public partial class F_NhaCungCap : Form
    {
        KhoDAO khoDAO = new KhoDAO();
        public F_NhaCungCap()
        {
            InitializeComponent();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            List<CustomParameter> list = new List<CustomParameter> { new CustomParameter() { key = "@MaNCC", value = txt_MaNCC.Text } };
            int count = khoDAO.DeleteNhaCC(list);
            if (count > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            F_NhaCungCap_Load(sender, e);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            List<CustomParameter> list = new List<CustomParameter> { new CustomParameter() { key = "@MaNCC", value = txt_MaNCC.Text},
                                                                     new CustomParameter() {key = "@TenNCC", value = txt_TenNCC.Text},
                                                                     new CustomParameter() {key = "@DiaChi", value = txt_DiaChi.Text},
                                                                     new CustomParameter() {key = "@SDT", value = txt_SDT.Text} };
            int count = khoDAO.UpdateNhaCC(list);
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            F_NhaCungCap_Load(sender, e);
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            DataTable dt = khoDAO.LoadNCC();
            dataGridView1.DataSource = dt;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara = khoDAO.LoadThemNhaCungCap(txt_MaNCC.Text.ToString(), txt_TenNCC.Text.ToString(), txt_DiaChi.Text.ToString(), txt_SDT.Text.ToString());
            khoDAO.ThemNhaCungCap(lstpara);
            MessageBox.Show("Luu Thanh Cong!");
        }

        private void F_NhaCungCap_Load(object sender, EventArgs e)
        {
            txt_MaNCC.ResetText();
            txt_TenNCC.ResetText();
            txt_DiaChi.ResetText();
            txt_SDT.ResetText();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNCC.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txt_TenNCC.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txt_DiaChi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txt_SDT.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
        }
    }
}
