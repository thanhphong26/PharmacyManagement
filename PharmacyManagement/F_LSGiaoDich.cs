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
    public partial class F_LSGiaoDich : Form
    {
        AddClass addClass = new AddClass();
        public F_LSGiaoDich()
        {
            InitializeComponent();
        }

        private void btn_LocNhapKho_Click(object sender, EventArgs e)
        {
            addClass.Add_Form(new F_LSNhapKho(), pn_GiaoDich);
        }

        private void btn_LocBanHang_Click(object sender, EventArgs e)
        {
            addClass.Add_Form(new F_LSBanHang(), pn_GiaoDich);
        }
    }
}
