
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
    public partial class F_BanHang : Form
    {
        private string selectedMaSp;
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        LoDAO LoDAO = new LoDAO();
        AddClass AddClass = new AddClass();
        SanPhamDAO SanPhamDAO = new SanPhamDAO();
        XuatHangDAO xuatHangDAO = new XuatHangDAO();
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        LoaiSanPhamDAO loaiSanPhamDAO = new LoaiSanPhamDAO();
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        CuaHangDAO CuaHangDAO = new CuaHangDAO();
        ConvertImage img = new ConvertImage();
        string maCH;
        string maLo;
        string maNV = GlobalData.UserName;
        int giaBanSp = 0;
        public F_BanHang()
        {
            InitializeComponent();
            maCH = nhanVienDAO.SearchMaCuaHangByMaNV(maNV).Rows[0]["MaCuaHang"].ToString();
            txtTenNhanVien.Text = nhanVienDAO.SearchMaCuaHangByMaNV(maNV).Rows[0]["TenNhanVien"].ToString();
            txtTenCuaHang.Text = CuaHangDAO.Get_TenCuaHang(maCH).Rows[0]["TenCuaHang"].ToString();
            LoadCbbDanhMuc();
            LoadCbbLoai();
            LoadSp(SanPhamDAO.SelectAll());
            lbTongTienCuoi.Text = (int.Parse(lbTongTien.Text) - int.Parse(lbGiamHetDate.Text) - int.Parse(lbTienDungDiem.Text)).ToString();

        }
        private void LoadCbbDanhMuc()
        {
            cbbDanhMuc.DisplayMember = "TenLoai";
            cbbDanhMuc.ValueMember = "MaLoai";
            cbbDanhMuc.DataSource = loaiSanPhamDAO.selectAllDanhMuc();
        }
        private void LoadCbbLoai()
        {
            cbbLoai.DisplayMember = "TenLoai";
            cbbLoai.ValueMember = "MaLoai";
            cbbLoai.DataSource = loaiSanPhamDAO.selectAllLoai();
        }
        private void LoadCbbLoaiByDanhMuc(string maDanhMuc)
        {
            cbbLoai.DisplayMember = "TenLoai";
            cbbLoai.ValueMember = "MaLoai";
            cbbLoai.DataSource = loaiSanPhamDAO.selectAllLoaiByDanhMuc(maDanhMuc);
        }
        private void LoadLoSp(DataTable dt)
        {
            dgvLoSpOfCH.DataSource = dt;
            int tongKho = 0;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int soluong;
                    if (int.TryParse(dt.Rows[i]["SoLuong"].ToString(), out soluong))
                    {
                        tongKho += soluong;
                    }
                    else
                    {
                    }
                }
            }
            txtTongKho.Text = tongKho.ToString();

        }
        private void LoadSp(DataTable data)
        {
            pnDSSanPham.Controls.Clear();
            int rowCount = data.Rows.Count;
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ColumnCount = 4;
            // Thiết lập kích thước cột bằng nhau
            float columnWidth = 100f / tableLayoutPanel1.ColumnCount;
            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, columnWidth));
            }


            tableLayoutPanel1.AutoScroll = true;
            pnDSSanPham.Controls.Add(tableLayoutPanel1);
            for (int i = 0; i < rowCount; i++)
            {
                Panel childPanelCol = new Panel();
                //childPanelCol.Size = new Size(272, 527);
                childPanelCol.Size = new Size(272,272);
                childPanelCol.Dock = DockStyle.Top;
                tableLayoutPanel1.Controls.Add(childPanelCol, i, 1);
                string maSp = data.Rows[i]["MaSP"].ToString();
                string tenSp = data.Rows[i]["TenSP"].ToString();
                string chucNang = data.Rows[i]["ChucNang"].ToString();

                Image image = data.Rows[i]["Image"] != DBNull.Value && data.Rows[i]["Image"] != null
                 ? img.ConvertToImage((byte[])data.Rows[i]["Image"])
                  : GetDefaultImage();

                F1SanPham f1SanPham = new F1SanPham(maSp, tenSp, chucNang,image);
                f1SanPham.MaSpSelected += F1SanPham_MaSpSelected;
                AddClass.Add_Form(f1SanPham, childPanelCol);

            }

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
        private void LoadTTSP(DataRow dataRow)
        {
            txtNameSp.Text = dataRow["TenSp"].ToString();
            txtDonVi.Text = "Đơn vị: " + dataRow["DonVi"].ToString();
            txtGiaBan.Text = "Giá bán: " + dataRow["GiaBan"].ToString() + "Đ";
            giaBanSp = int.Parse(dataRow["GiaBan"].ToString());
            txtMota.Text = "Mô tả: " + dataRow["MoTa"].ToString();
            pSp.Image = dataRow["Image"] != DBNull.Value && dataRow["Image"] != null
                ? img.ConvertToImage((byte[])dataRow["Image"])
                 : GetDefaultImage();
        }
        private void F1SanPham_MaSpSelected(object sender, string maSp)
        {
            selectedMaSp = maSp;
            DataTable dt = LoDAO.SelectLoByMaSPAndCuaHang(maCH, maSp);
            LoadLoSp(dt);
            DataRow dataRow = SanPhamDAO.Select1SP(maSp).Rows[0];
            LoadTTSP(dataRow);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        int TienGiamDoGanDate = 0;
        bool isGanHetDate = false;
        private void dgvLoSpOfCH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgvLoSpOfCH.RowCount - 1)
            {
                isGanHetDate = false;
                nUDSoluong.Maximum = int.Parse(dgvLoSpOfCH.Rows[e.RowIndex].Cells["SL"].Value.ToString());
                nUDSoluong.Value = int.Parse(dgvLoSpOfCH.Rows[e.RowIndex].Cells["SL"].Value.ToString());

                maLo = dgvLoSpOfCH.Rows[e.RowIndex].Cells["Lo"].Value.ToString();
                DateTime HSD = Convert.ToDateTime(dgvLoSpOfCH.Rows[e.RowIndex].Cells["HSD"].Value);
                TimeSpan timeRemaining = HSD - DateTime.Today;

                if (timeRemaining.TotalDays <= 30)
                {
                    isGanHetDate = true;
                }
            }
        }
        //mua
        private void button1_Click(object sender, EventArgs e)
        {
            if (isGanHetDate) { TienGiamDoGanDate = ((int.Parse(nUDSoluong.Value.ToString()) * giaBanSp)) / 10; }
            object[] rowData = { txtNameSp.Text, nUDSoluong.Value.ToString(), (nUDSoluong.Value * giaBanSp).ToString(), maLo, TienGiamDoGanDate.ToString() };
            dgvHoaDon.Rows.Add(rowData);
            int tongTienHoaDon = 0;
            int GiamHetDate = 0;
            TienGiamDoGanDate = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
            {

                GiamHetDate += int.Parse(dgvHoaDon.Rows[i].Cells["Giam"].Value.ToString());
                tongTienHoaDon += int.Parse(dgvHoaDon.Rows[i].Cells["Tien"].Value.ToString());
            }
            lbTongTien.Text = tongTienHoaDon.ToString();
            lbGiamHetDate.Text = GiamHetDate.ToString();
            lbTongTienCuoi.Text = (int.Parse(lbTongTien.Text) - int.Parse(lbGiamHetDate.Text) - int.Parse(lbTienDungDiem.Text)).ToString();

        }

        private void btnSearchKH_Click(object sender, EventArgs e)
        {
            DataRow dtRow = khachHangDAO.SelectKH_By_SDT(txtSDT.Text);
            if (dtRow != null)
            {
                txtTenKH.Text = dtRow["TenKhachHang"].ToString();
                txtDiaChi.Text = dtRow["DiaChi"].ToString();
                nUPDiem.Value = int.Parse(dtRow["Diem"].ToString());

            }
            else
            {
                MessageBox.Show("Khách hàng này chưa từng mua ");
            }
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            khachHangDAO.AddKh(txtTenKH.Text, txtDiaChi.Text, txtSDT.Text);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            khachHangDAO.AddKHandHoaDon(maNV, txtSDT.Text, txtTenKH.Text, txtDiaChi.Text);

            string maHoaDon = hoaDonDAO.MaMoiTao();
            for (int i = 0; i < dgvHoaDon.RowCount - 1; i++)
            {
                string maLo = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
                int soluong = int.Parse(dgvHoaDon.Rows[i].Cells["SoLuongOfHoaDon"].Value.ToString());
                xuatHangDAO.AddXuatHang(maLo, maHoaDon, soluong);
            }
            if (isDungDiem)
            {
                hoaDonDAO.CapNhapDiemTich(maHoaDon, int.Parse(nUPDiem.Value.ToString()));
            }
            new FHoaDonKH(maHoaDon, txtTenCuaHang.Text, txtTenNhanVien.Text, txtTenKH.Text,
                int.Parse(lbTienDungDiem.Text) + int.Parse(lbGiamHetDate.Text), lbTongTien.Text).ShowDialog();

        }

        private void lbTenSp_Click(object sender, EventArgs e)
        {

        }
        int setDoi = 0;
        private void cbbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSp(SanPhamDAO.SelectAllByDanhMuc(cbbDanhMuc.SelectedValue.ToString()));
            setDoi = 1;
            LoadCbbLoaiByDanhMuc(cbbDanhMuc.SelectedValue.ToString());
            setDoi = 0;
        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (setDoi == 0)
                LoadSp(SanPhamDAO.SelectAllByLoai(cbbLoai.SelectedValue.ToString()));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText;
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                searchText = "s";
            }
            else searchText = txtSearch.Text;

            LoadSp(SanPhamDAO.SelectAllByTuKhoa(searchText));
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLoSpOfCH.RowCount - 1)
            {
                dgvHoaDon.Rows.RemoveAt(e.RowIndex);
                int tongTienHoaDon = 0;
                int GiamHetDate = 0;
                TienGiamDoGanDate = 0;
                for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                {
                    GiamHetDate += int.Parse(dgvHoaDon.Rows[i].Cells["Giam"].Value.ToString());
                    tongTienHoaDon += int.Parse(dgvHoaDon.Rows[i].Cells["Tien"].Value.ToString());
                }
                lbTongTien.Text = tongTienHoaDon.ToString();
                lbGiamHetDate.Text = GiamHetDate.ToString();
            }
            lbTongTienCuoi.Text = (int.Parse(lbTongTien.Text) - int.Parse(lbGiamHetDate.Text) - int.Parse(lbTienDungDiem.Text)).ToString();
        }
        bool isDungDiem = false;
        private void btnDung_Click(object sender, EventArgs e)
        {
            if (!isDungDiem) { isDungDiem = true; } else { isDungDiem = false; }
            if (isDungDiem) btnDung.BackColor = SystemColors.ActiveCaption; else btnDung.BackColor = Color.FromArgb(62, 132, 254);

            if (isDungDiem)
            {
                lbTienDungDiem.Text = (nUPDiem.Value * 1000).ToString();

            }
            else lbTienDungDiem.Text = "0";
            lbTongTienCuoi.Text = (int.Parse(lbTongTien.Text) - int.Parse(lbGiamHetDate.Text) - int.Parse(lbTienDungDiem.Text)).ToString();

        }

        private void dgvLoSpOfCH_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dgvLoSpOfCH.Rows[e.RowIndex];
            DateTime HSD = Convert.ToDateTime(row.Cells["HSD"].Value);
            TimeSpan timeRemaining = HSD - DateTime.Today;

            if (timeRemaining.TotalDays <= 30)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
