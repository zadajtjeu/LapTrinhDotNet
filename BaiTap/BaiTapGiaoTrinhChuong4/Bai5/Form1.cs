using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        private string textHPNY = "Chúc mừng năm mới - Happy New Year";
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int len = lbHNY.Text.Length;
            if (len == textHPNY.Length)
            {
                lbHNY.Text = "";
            }
            else
            {
                lbHNY.Text = textHPNY.Substring(0, len + 1);
            }
            
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            if (btnDung.Text == "Dừng")
            {
                btnDung.Text = "Chạy";
                timer1.Enabled = false;
            }
            else if (btnDung.Text == "Chạy")
            {
                btnDung.Text = "Dừng";
                timer1.Enabled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
