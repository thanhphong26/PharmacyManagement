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
    public partial class FMain : Form
    {
        AddClass addClass = new AddClass();
        public FMain()
        {
            InitializeComponent();
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_MinSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            addClass.Add_Form(new F_QLNhanVien(), pn_main);
        }

        private void btn_TTCN_Click(object sender, EventArgs e)
        {
            addClass.Add_Form(new F_TTCaNhan(), pn_main);
        }

        private void btn_LSGD_Click(object sender, EventArgs e)
        {
            addClass.Add_Form(new F_LSGiaoDich(), pn_main);
        }
    }
}
