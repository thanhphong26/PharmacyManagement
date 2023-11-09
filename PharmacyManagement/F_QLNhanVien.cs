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
        private byte[] pic = null;
        public F_QLNhanVien()
        {
            InitializeComponent();
            LoadComboBox();
        }
        public void LoadComboBox()
        {
            cbo_MaCuaHang.DisplayMember = "MaCuaHang";
            cbo_MaCuaHang.DataSource = cuahang.DS_CuaHang();

            cb_MaCV.DisplayMember = "MaChucVu";
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
                value = (rdio_Nam.Checked==true? 0:1)
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@DiaChi",
                value = txt_Diachi.Text
            });
            lstpara.Add(new CustomParameter()
            {
                key = "@MaChucVu",
                value = cb_MaCV.Text
            });
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

