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
    public partial class F_TTCaNhan : Form
    {
        public F_TTCaNhan()
        {
            InitializeComponent();
            textBox1.Enter += textBox1_Enter;
            textBox2.Enter += textBox2_Enter;
            textBox3.Enter += textBox3_Enter;   
            textBox4.Enter += textBox4_Enter;
            textBox5.Enter += textBox5_Enter;
            textBox6.Enter += textBox6_Enter;
            textBox7.Enter += textBox7_Enter;
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
            
        }
    }
}
