using PharmacyManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class F_ThemSanPham : Form
    {
        private byte[] pic=null;
        KhoDAO khoDAO = new KhoDAO();
        public F_ThemSanPham()
        {
            InitializeComponent();
            LoadCBB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string picPath = dialog.FileName.ToString();
                ptb_SanPham.ImageLocation = picPath;

                FileStream fs = new FileStream(picPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                pic = br.ReadBytes((int)fs.Length);
            }
        }

        public void LoadCBB()
        {
            cbb_ml.DataSource = khoDAO.LoadCbbMaLoai();
            cbb_ml.DisplayMember = "MaLoai";
            cbb_ml.SelectedIndex = -1;
            cbb_mnsx.DataSource = khoDAO.LoadCbbMaNSX();
            cbb_mnsx.DisplayMember = "MaNSX";
            cbb_mnsx.SelectedIndex = -1;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara = khoDAO.LoadThemSanPham(txt_MaSP.Text.ToString(), txt_TenSP.Text.ToString(), txt_DonVi.Text.ToString(), txt_GiaBan.Text, txt_Chucnang.Text.ToString(), txt_MoTa.Text.ToString(), cbb_ml.Text.ToString(), cbb_mnsx.Text.ToString(),pic);
            khoDAO.ThemSanPham(lstpara);
            MessageBox.Show("Luu Thanh Cong!");
        }
    }
}
