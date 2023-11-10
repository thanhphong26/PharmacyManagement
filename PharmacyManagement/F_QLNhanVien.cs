using PharmacyManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PharmacyManagement
{
    public partial class F_QLNhanVien : Form
    {
        DataBase db=new DataBase();
        CuaHangDAO cuahang=new CuaHangDAO();
        ChucVuDAO chucvu=new ChucVuDAO();
        NhanVienDAO nhanvien=new NhanVienDAO();
        Chuyen img = new Chuyen();
        private string mch, mnv;
        private byte[] pic = null;
        private FMain form = null;

        public F_QLNhanVien()
        {
            InitializeComponent();
            LoadComboBox();

        }
        public void SetFormReference(FMain form)
        {
            this.form = form;
        }

        private void reset()
        {
            txt_MaNV.ResetText();
            txt_TenNV.ResetText();
            cb_MaCV.ResetText();
            rdio_Nam.Checked = false;
            rdio_Nu.Checked = false;
            txt_SDT.ResetText();
            dt_NgaySinh.ResetText();
            txt_Diachi.ResetText();
            cbo_MaCuaHang.ResetText();
            ptb_NhanVien.Image = null;
            dgv_DSNV.Refresh();
        }

        private void F_QLNhanVien_Load(object sender, EventArgs e)
        {
            reset();
            mch = form.MCH;
            LoadComboBox();
            if (mch != "")
            {
                cbo_MaCuaHang.Text = mch;
                cb_MaCV.Enabled = false;
                cbo_MaCuaHang.Enabled = false;
            }
            else
            {
                mch = "%";
                cb_MaCV.Enabled = true;
                cbo_MaCuaHang.Enabled = true;
            }

            dgv_DSNV.DataSource = nhanvien.DanSachNhanVien(mch);
        }

        public void LoadComboBox()
        {
            cbo_MaCuaHang.DisplayMember = "MaCuaHang";
            cbo_MaCuaHang.DataSource = cuahang.DS_CuaHang();

            cb_MaCV.DisplayMember = "TenChucVu";
            cb_MaCV.ValueMember = "MaChucVu";
            cb_MaCV.DataSource=chucvu.DS_ChucVu();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@MaNhanVien",
                value = txt_MaNV.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@TenNhanVien",
                value = txt_TenNV.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@NgaySinh",
                value = dt_NgaySinh.Value.Date.ToString("yyyy-MM-dd")
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@SDT",
                value = txt_SDT.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@GioiTinh",
                value = (rdio_Nam.Checked==true? "0":"1")
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = txt_Diachi.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaChucVu",
                value = cb_MaCV.SelectedValue.ToString()
            }) ;
            lstpara.Add(new CustomParameter()
            {
                key = "@MaCuaHang",
                value = cbo_MaCuaHang.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Image",
                value =pic
            });
            int cmd = db.Excute("proc_ThemNhanVien", lstpara);
            if (cmd > 0)
            {
                MessageBox.Show("Thêm nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Không thể thêm mới");
            }
            F_QLNhanVien_Load(sender, e);
        }

        private void dgv_DSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = Convert.ToString(dgv_DSNV.CurrentRow.Cells[0].Value);
            txt_TenNV.Text = Convert.ToString(dgv_DSNV.CurrentRow.Cells[1].Value);
            dt_NgaySinh.Value = Convert.ToDateTime(dgv_DSNV.CurrentRow.Cells[2].Value);
            txt_SDT.Text = Convert.ToString(dgv_DSNV.CurrentRow.Cells[3].Value);
            if (Convert.ToInt32(dgv_DSNV.CurrentRow.Cells[4].Value) == 0)
                rdio_Nam.Checked = true;
            else 
                rdio_Nu.Checked = true;
            txt_Diachi.Text = Convert.ToString(dgv_DSNV.CurrentRow.Cells[5].Value);
            cbo_MaCuaHang.SelectedIndex = cbo_MaCuaHang.FindString(Convert.ToString(dgv_DSNV.CurrentRow.Cells[7].Value));
            cb_MaCV.SelectedIndex = cb_MaCV.FindString(Convert.ToString(dgv_DSNV.CurrentRow.Cells[6].Value));
            ptb_NhanVien.Image = img.convertimage((byte[])dgv_DSNV.CurrentRow.Cells[8].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(ptb_NhanVien.ImageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            pic = br.ReadBytes((int)fs.Length);
            List<CustomParameter> lstpara = new List<CustomParameter>();
            lstpara.Add(new CustomParameter()
            {
                key = "@MaNhanVien",
                value = txt_MaNV.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@TenNhanVien",
                value = txt_TenNV.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@NgaySinh",
                value = dt_NgaySinh.Value.Date.ToString("yyyy-MM-dd")
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@SDT",
                value = txt_SDT.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@GioiTinh",
                value = (rdio_Nam.Checked == true ? "0" : "1")
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = txt_Diachi.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaChucVu",
                value = cb_MaCV.SelectedValue.ToString()
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaCuaHang",
                value = cbo_MaCuaHang.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@Image",
                value = pic
            });
            if (nhanvien.Update(lstpara) != -100)
                MessageBox.Show("Sửa thành công!");
            F_QLNhanVien_Load(sender, e);
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            if (nhanvien.Delete(txt_MaNV.Text) != -100)

            F_QLNhanVien_Load(sender, e);
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string picPath = dialog.FileName.ToString();
                ptb_NhanVien.ImageLocation = picPath;

                FileStream fs = new FileStream(picPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                pic = br.ReadBytes((int)fs.Length);
            }
        }

    }
        
 }

