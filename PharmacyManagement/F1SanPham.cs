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
    public partial class F1SanPham : Form
    {
        string maSpClicked;
        public F1SanPham(string maSp, string tenSp, string chucNang, Image image)
        {
            InitializeComponent();
            txtTenSp.Text = tenSp;
            txtMaSp.Text = maSp;
            textBox1.Text = "Chức năng: "+ chucNang;
            maSpClicked = maSp;
            pictureBox1.Image = image;

        }
        public event EventHandler<string> MaSpSelected;

        private void button1_Click(object sender, EventArgs e)
        {
            EventHandler<string> handler = MaSpSelected;
            if (handler != null)
            {
                handler(this, maSpClicked);
            }
        }

        private void lbTenSp_Click(object sender, EventArgs e)
        {

        }

        private void txtTenSp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
