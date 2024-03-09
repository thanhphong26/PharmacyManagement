using PharmacyManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class F_DoanhThu : Form
    {
        DoanhThuDAO doanhThuDAO = new DoanhThuDAO();
        KhoDAO khoDAO = new KhoDAO();
        DataBase db = new DataBase();
        public F_DoanhThu()
        {
            InitializeComponent();
            LoadCBB();
        }
        public void LoadCBB()
        {
            cbb_MaCH.DataSource = doanhThuDAO.LoadCbbMaCuaHang();
            cbb_MaCH.DisplayMember = "MaCuaHang";
            cbb_MaCH.SelectedIndex = -1;
            cbb_Thang.Items.Add(1);
            cbb_Thang.Items.Add(2);
            cbb_Thang.Items.Add(3);
            cbb_Thang.Items.Add(4);
            cbb_Thang.Items.Add(5);
            cbb_Thang.Items.Add(6);
            cbb_Thang.Items.Add(7);
            cbb_Thang.Items.Add(8);
            cbb_Thang.Items.Add(9);
            cbb_Thang.Items.Add(10);
            cbb_Thang.Items.Add(11);
            cbb_Thang.Items.Add(12);
            cbb_Nam.Items.Add(2023);
            cbb_Nam.Items.Add(2022);

        }
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            DataTable dt = doanhThuDAO.LoadHDBan(cbb_MaCH.Text, cbb_Thang.Text, cbb_Nam.Text);
            DataTable dt1 = doanhThuDAO.LoadHDNhap(cbb_MaCH.Text, cbb_Thang.Text, cbb_Nam.Text);

            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt1;


            string thang = cbb_Thang.Text;
            string nam = cbb_Nam.Text;
            string maCuaHang = cbb_MaCH.Text;

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection($"Data Source=.;Initial Catalog=Pharmacy;User ID={GlobalData.UserName};Password={GlobalData.Password};"))
            {
                try
                {


                    conn.Open();

                    // Tạo và thực thi SqlCommand
                    using (SqlCommand command = new SqlCommand("select dbo.func_tongtienhoadonban('" + cbb_Thang.Text + "','" + cbb_Nam.Text + "','" + cbb_MaCH.Text + "')", conn))
                    {

                        int tienban = (int)command.ExecuteScalar();

                        // Hiển thị giá trị trên TextBox
                        txt_TienBan.Text = tienban.ToString();


                    }
                    using (SqlCommand command = new SqlCommand("select dbo.func_tongtienhoadonnhap('" + cbb_Thang.Text + "','" + cbb_Nam.Text + "','" + cbb_MaCH.Text + "')", conn))
                    {



                        int tiennhap = (int)command.ExecuteScalar();

                        // Hiển thị giá trị trên TextBox
                        txt_TienNhap.Text = tiennhap.ToString();

                    }
                    using (SqlCommand command = new SqlCommand("select dbo.func_tongsohoadonbanra('" + cbb_Thang.Text + "','" + cbb_Nam.Text + "','" + cbb_MaCH.Text + "')", conn))
                    {
                        // Thực thi hàm SQL và lấy giá trị trả về
                        int hdban = (int)command.ExecuteScalar();

                        // Hiển thị giá trị trên TextBox
                        txt_SoHDBan.Text = hdban.ToString();
                    }
                    using (SqlCommand command = new SqlCommand("select dbo.func_tongsohoadonnhap('" + cbb_Thang.Text + "','" + cbb_Nam.Text + "','" + cbb_MaCH.Text + "')", conn))
                    {
                        // Thực thi hàm SQL và lấy giá trị trả về
                        int hdnhap = (int)command.ExecuteScalar();

                        // Hiển thị giá trị trên TextBox
                        txt_SoHDNhap.Text = hdnhap.ToString();
                    }
                    using (SqlCommand command = new SqlCommand("select dbo.func_loinhuan('" + cbb_Thang.Text + "','" + cbb_Nam.Text + "','" + cbb_MaCH.Text + "')", conn))
                    {
                        // Thực thi hàm SQL và lấy giá trị trả về
                        int loinhuan = (int)command.ExecuteScalar();

                        // Hiển thị giá trị trên TextBox
                        txt_LoiNhuan.Text = loinhuan.ToString();
                    }
                    // Đóng kết nối
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Khong The Thong Ke Loi Nhuan");
                }
            }
        }
    }
}
