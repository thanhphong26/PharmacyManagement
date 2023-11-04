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
    public partial class FBanHang : Form
    {
        AddClass AddClass=new AddClass();
        SanPhamDAO SanPhamDAO = new SanPhamDAO();
        public FBanHang()
        {
            InitializeComponent();
            AddPanels(SanPhamDAO.SelectAll());
        }
        private void AddPanels(DataTable data)
        {
            int rowCount = data.Rows.Count;

            for (int i = 1; i <= rowCount; i+=4)
            {
                Panel childPanelRow = new Panel();
                childPanelRow.BackColor = SystemColors.Control;
                childPanelRow.Size = new Size(570, 570);
                childPanelRow.Dock = DockStyle.Top;
                
                for (int j = i; j <= Math.Min(i+4, rowCount); j ++)
                {
                    Panel childPanelCol = new Panel();
                    childPanelCol.BackColor = System.Drawing.Color.LightBlue;
                    childPanelCol.Size = new Size(570, 570);
                    childPanelCol.Dock = DockStyle.Left;
                    childPanelRow.Controls.Add(childPanelCol);
                    String maSp = data.Rows[j-1]["MaSP"].ToString();
                    String tenSp = data.Rows[j-1]["TenSP"].ToString();
                    String chucNang = data.Rows[j - 1]["ChucNang"].ToString();
                    
                    AddClass.Add_Form(new F1SanPham(maSp,tenSp,chucNang), childPanelCol);
                }
                   
                pnDSSanPham.Controls.Add(childPanelRow);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
