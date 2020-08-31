using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGiai_Click(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(txtSob.Text, out value) == false)
            {
                lbNghiem.Text = "Nhập lại hệ số b";
                txtSob.Clear();
                txtSob.Focus();
            }
            else if (Int32.TryParse(txtSoc.Text, out value) == false)
            {
                lbNghiem.Text = "Nhập lại hệ số c";
                txtSoc.Clear();
                txtSoc.Focus();
            }
            else
            {
                int b = Int32.Parse(txtSob.Text);
                int c = Int32.Parse(txtSoc.Text);
                XuLi pt = new XuLi(b, c);
                lbNghiem.Text = pt.GiaiPT();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSob.Clear();
            txtSoc.Clear();
            lbNghiem.Text = string.Empty;
            txtSob.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit ?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
