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
    public partial class F_TTCaNhan : Form
    {
        public F_TTCaNhan()
        {
            InitializeComponent();
            txt_MNV.Enter += textBox1_Enter;
            txt_TenNV.Enter += textBox2_Enter;
            txt_SDT.Enter += textBox3_Enter;   
            txt_DiaChi.Enter += textBox4_Enter;
            txt_TenCuaHang.Enter += textBox5_Enter;
            txt_ChucVu.Enter += textBox6_Enter;
            txt_MaCH.Enter += textBox7_Enter;
            dtp_NgaySinh.MouseDown += dateTimePicker1_MouseDown;
            radioButton1.MouseDown += radioButton1_MouseDown;
            radioButton2.MouseDown += radioButton2_MouseDown;
        }
        DataBase data = new DataBase();
        private string msnv = null;

        private FMain main;

        public void SetForm1Reference(FMain form1)
        {
            main = form1;
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {   
            label1.Focus();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void F_TTCaNhan_Load(object sender, EventArgs e)
        {

            if (main != null)
            { 
            MessageBox.Show(main.MSNV);
            }
            else
            {
                MessageBox.Show("Không kết nối!");
            }

            string sql = "select * from ThongTinNhanVien('NV0002')";
            DataRow dr = null;
            dr = data.Select(sql);
            
            txt_MNV.Text = dr[0].ToString();// Mã nhân viên
            txt_TenNV.Text = dr[1].ToString();// Tên nhân viên
            /*int gt = Convert.ToInt32(dr[2]);
            if (gt > 0)
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;*/
            txt_SDT.Text = dr[3].ToString();
            dtp_NgaySinh.Value = (DateTime)dr[4];
            txt_DiaChi.Text = dr[5].ToString();
            txt_MaCH.Text = dr[6].ToString();
            txt_TenCuaHang.Text = dr[7].ToString();
            txt_ChucVu.Text = dr[8].ToString();
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
        }

        private void radioButton1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
        }

        private void radioButton2_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Focus();
        }
    }
}
