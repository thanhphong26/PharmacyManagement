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
    public partial class F_NhaSanXuat : Form
    {
        KhoDAO khoDAO = new KhoDAO();
        public F_NhaSanXuat()
        {
            InitializeComponent();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            DataTable dt = khoDAO.LoadNSX();
            dataGridView1.DataSource = dt;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara = khoDAO.LoadThemNhaSanXuat(txt_MaNSX.Text.ToString(), txt_TenNSX.Text.ToString(), txt_DiaChi.Text.ToString());
            khoDAO.ThemNhaSanXuat(lstpara);
            MessageBox.Show("Luu Thanh Cong!");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            List<CustomParameter> list = new List<CustomParameter> { new CustomParameter() { key = "@MaNSX", value = txt_MaNSX.Text } };
            int count = khoDAO.DeleteNSX(list);
            if (count > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            F_NhaSanXuat_Load(sender, e);
        }

        private void F_NhaSanXuat_Load(object sender, EventArgs e)
        {
            txt_MaNSX.ResetText();
            txt_TenNSX.ResetText();
            txt_DiaChi.ResetText();
        }

       

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            List<CustomParameter> list = new List<CustomParameter> { new CustomParameter() { key = "@MaNSX", value = txt_MaNSX.Text},
                                                                     new CustomParameter() {key = "@TenNSX", value = txt_TenNSX.Text},
                                                                     new CustomParameter() {key = "@DiaChi", value = txt_DiaChi.Text} };
            int count = khoDAO.UpdateNSX(list);
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            F_NhaSanXuat_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNSX.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txt_TenNSX.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txt_DiaChi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
        }
    }
}
