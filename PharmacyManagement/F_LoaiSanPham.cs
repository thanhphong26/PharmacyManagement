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
    public partial class F_LoaiSanPham : Form
    {
        KhoDAO kho = new KhoDAO();
        public F_LoaiSanPham()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            List<CustomParameter> list = new List<CustomParameter> { new CustomParameter() { key = "@MaLoai", value = txt_MaLoai.Text},
                                                                     new CustomParameter() {key = "@TenLoai", value = txt_TenLoai.Text},
                                                                     new CustomParameter() {key = "@MaDanhMucChinh", value = cb_MaDanhMucChinh.Text} };
            int count = kho.InsertLoaiSP(list);
            if (count > 0)
            {
                MessageBox.Show("Thêm thành công!");
            }
            F_LoaiSanPham_Load(sender, e);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            List<CustomParameter> list = new List<CustomParameter> { new CustomParameter() { key = "@MaLoai", value = txt_MaLoai.Text},
                                                                     new CustomParameter() {key = "@TenLoai", value = txt_TenLoai.Text},
                                                                     new CustomParameter() {key = "@MaDanhMucChinh", value = cb_MaDanhMucChinh.Text} };
            int count = kho.UpdateLoaiSP(list);
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            F_LoaiSanPham_Load(sender, e);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            List<CustomParameter> list = new List<CustomParameter> { new CustomParameter() { key = "@MaLoai", value = txt_MaLoai.Text } };
            int count = kho.DeleteLoaiSP(list);
            if (count > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            F_LoaiSanPham_Load(sender, e);
        }

        private void dg_Loai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_MaDanhMucChinh.SelectedIndex = -1;
            txt_MaLoai.Text = Convert.ToString(dg_Loai.CurrentRow.Cells[0].Value);
            txt_TenLoai.Text = Convert.ToString(dg_Loai.CurrentRow.Cells[1].Value);
            if (Convert.ToString(dg_Loai.CurrentRow.Cells[2].Value) != "")
                cb_MaDanhMucChinh.SelectedIndex = cb_MaDanhMucChinh.FindString(Convert.ToString(dg_Loai.CurrentRow.Cells[2].Value));
        }

        private void F_LoaiSanPham_Load(object sender, EventArgs e)
        {
            txt_MaLoai.ResetText();
            txt_TenLoai.ResetText();
            dg_Loai.DataSource = kho.LoadCbbMaLoai();
            cb_MaDanhMucChinh.DisplayMember = "MaLoai";
            cb_MaDanhMucChinh.DataSource = kho.LoadCbbMaLoai();
            cb_MaDanhMucChinh.SelectedIndex = -1;
        }
    }
}
