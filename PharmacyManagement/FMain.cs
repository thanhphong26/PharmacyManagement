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
        public FMain()
        {
            InitializeComponent();
            FLogin flogin = new FLogin();
            Application.Run(flogin);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_MinSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AddForm2ToPanel()
        {
            F_QLNhanVien form2 = new F_QLNhanVien(pn_main);
            form2.TopLevel = false;
            panel1.Controls.Add(form2);
            form2.Show();
        }
        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            AddForm2ToPanel();
        }
    }
}
