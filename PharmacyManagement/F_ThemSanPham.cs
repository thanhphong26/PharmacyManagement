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
        KhoDAO KhoDAO = new KhoDAO();
        DataBase db=new DataBase();
        ConvertImage img=new ConvertImage();
        public F_ThemSanPham()
        {
            InitializeComponent();
            LoadCBB();
        }
        public void LoadCBB()
        {
            cbb_ml.DataSource = KhoDAO.LoadCbbMaLoai();
            cbb_ml.DisplayMember = "MaLoai";
            cbb_ml.SelectedIndex = -1;
            cbb_mnsx.DataSource = KhoDAO.LoadCbbMaNSX();
            cbb_mnsx.DisplayMember = "MaNSX";
            cbb_mnsx.SelectedIndex = -1;
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(pictureBox1.ImageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            pic = br.ReadBytes((int)fs.Length);

            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@MaSP",
                value = txt_MaSP.Text,
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@TenSP",
                value = txt_TenSP.Text,
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@DonVi",
                value = txt_DonVi.Text,
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@GiaBan",
                value = txt_GiaBan.Text,
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@ChucNang",
                value = txt_Chucnang.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MoTa",
                value = txt_MoTa.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaLoai",
                value = cbb_ml.Text.ToString()
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaNSX",
                value = cbb_mnsx.Text.ToString()
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Image",
                value = pic
            });
            int cmd = db.Excute("proc_ThemSanPham", lstpara);
            if (cmd > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Không thể thêm mới");
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            DataTable dt = KhoDAO.LoadSanPham();
            dataGridView1.DataSource = dt;
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            List<CustomParameter> list = new List<CustomParameter> { new CustomParameter() { key = "@MaSP", value = txt_MaSP.Text } };
            int count = KhoDAO.DeleteSP(list);
            if (count > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            F_ThemSanPham_Load(sender, e);
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string picPath = dialog.FileName.ToString();
                pictureBox1.ImageLocation = picPath;

                FileStream fs = new FileStream(picPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                pic = br.ReadBytes((int)fs.Length);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenSP.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txt_MaSP.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txt_DonVi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txt_GiaBan.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            txt_MoTa.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            txt_Chucnang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            cbb_ml.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            cbb_mnsx.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            object cellValue = dataGridView1.CurrentRow.Cells[8].Value;

            if (cellValue != null && cellValue != DBNull.Value)
            {
                // If the value is not null, convert it to an image and set it to pictureBox1
                pictureBox1.Image = img.ConvertToImage((byte[])cellValue);
            }
            else
            {
                // If the value is null, set a default image to pictureBox1
                pictureBox1.Image = GetDefaultImage(); // Replace DefaultImage with the name of your default image resource
            }
            //pictureBox1.Image = img.ConvertToImage((byte[])dataGridView1.CurrentRow.Cells[8].Value);
        }
        private Image GetDefaultImage()
        {
            // Tạo một hình ảnh mặc định
            Bitmap defaultImage = new Bitmap(200, 200);
            using (Graphics graphics = Graphics.FromImage(defaultImage))
            {
                graphics.Clear(Color.LightGray);
                graphics.DrawString("Image", new Font("Arial", 12), Brushes.Black, new PointF(50, 90));
            }
            return defaultImage;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            List<CustomParameter> list = new List<CustomParameter> { new CustomParameter() { key = "@MaSP", value = txt_MaSP.Text},
                                                                     new CustomParameter() {key = "@TenSP", value = txt_TenSP.Text},
                                                                     new CustomParameter() {key = "@DonVi", value = txt_DonVi.Text},
                                                                     new CustomParameter() {key = "@MoTa", value = txt_MoTa.Text},
                                                                     new CustomParameter() {key = "@ChucNang", value = txt_Chucnang.Text},
                                                                     new CustomParameter() {key = "@GiaBan", value = txt_GiaBan.Text},
                                                                     new CustomParameter() {key = "@MaLoai", value = cbb_ml.Text},
                                                                     new CustomParameter() {key = "@MaNSX", value = cbb_mnsx.Text},
                                                                     new CustomParameter() { key = "@Image", value = pic} };
            int count = KhoDAO.UpdateSP(list);
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            F_ThemSanPham_Load(sender, e);
        }

        private void F_ThemSanPham_Load(object sender, EventArgs e)
        {

            txt_MaSP.ResetText();
            txt_TenSP.ResetText();
            txt_Chucnang.ResetText();
            txt_DonVi.ResetText();
            txt_GiaBan.ResetText();
            txt_MoTa.ResetText();
            cbb_ml.ResetText();
            cbb_mnsx.ResetText();
        }
    }
}
