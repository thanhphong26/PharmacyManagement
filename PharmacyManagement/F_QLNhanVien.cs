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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacyManagement
{
    public partial class F_QLNhanVien : Form
    {
        DataBase db=new DataBase();
        CuaHangDAO cuahang=new CuaHangDAO();
        public F_QLNhanVien()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            cbo_MaCuaHang.DisplayMember = "MaCuaHang";
            cbo_MaCuaHang.DataSource = cuahang.DS_CuaHang();
        }

    }
        
 }

