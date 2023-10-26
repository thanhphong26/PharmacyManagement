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
    public partial class F_QLNhanVien : Form
    {
        public F_QLNhanVien()
        {
            InitializeComponent();
        }
        private Panel panelFromForm1;

        public F_QLNhanVien(Panel panel)
        {
            InitializeComponent();
            panelFromForm1 = panel;
        }
    }
}
