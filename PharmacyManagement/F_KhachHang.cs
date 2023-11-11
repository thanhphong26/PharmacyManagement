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
    public partial class F_KhachHang : Form
    {
        public F_KhachHang()
        {
            InitializeComponent();
        }
        private FMain form;
        private string mvn;
        private string mch;
        KhachHangDAO kh = new KhachHangDAO();

        private string mkh;
        private string tkh;
        private string dc;
        private string sdt;
        private int diem;

        public void SetFormReference(FMain form)
        {
            this.form = form;
        }

        private void F_KhachHang_Load(object sender, EventArgs e)
        {
             mvn = form.MSNV;
            mch = form.MCH;
            txt_MaKhachHang.ResetText();
            txt_TenKhachHang.ResetText();
            txt_Diachi.ResetText();
            txt_SDT.ResetText();    
            txt_Diem.ResetText();
            dg_DachSachKhachHang.DataSource = kh.DanhSachKhachHang();
        }

        private void dg_DachSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKhachHang.Text = Convert.ToString(dg_DachSachKhachHang.CurrentRow.Cells[0].Value);
            txt_TenKhachHang.Text = Convert.ToString(dg_DachSachKhachHang.CurrentRow.Cells[1].Value);
            txt_Diachi.Text = Convert.ToString(dg_DachSachKhachHang.CurrentRow.Cells[2].Value);
            txt_SDT.Text = Convert.ToString(dg_DachSachKhachHang.CurrentRow.Cells[3].Value);
            txt_Diem.Text = Convert.ToString(dg_DachSachKhachHang.CurrentRow.Cells[4].Value);

        }

        private void btn_DatLai_Click(object sender, EventArgs e)
        {
            F_KhachHang_Load(sender, e);
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            mkh = (txt_MaKhachHang.Text == "") ? "%" : txt_MaKhachHang.Text.Trim()+"%";
            tkh = (txt_TenKhachHang.Text == "") ? "%" : txt_TenKhachHang.Text.Trim()+"%";
            dc = (txt_Diachi.Text == "") ? "%" : txt_Diachi.Text.Trim() + "%";
            sdt = (txt_SDT.Text =="")?"%":txt_SDT.Text.Trim() + "%";
            diem = (txt_Diem.Text =="")? 0 : Convert.ToInt32(txt_Diem.Text);

            List<CustomParameter> list = new List<CustomParameter> { new CustomParameter() { key = "@MaKhachHang", value = mkh },
                                                                     new CustomParameter() { key = "@TenKhachHang", value = tkh},
                                                                     new CustomParameter() { key = "@DiaChi", value = dc},
                                                                     new CustomParameter() { key = "@SDT", value = sdt},
                                                                     new CustomParameter() { key = "@Diem", value = diem}};
            dg_DachSachKhachHang.DataSource = kh.Tim(list);

        }
    }
}
