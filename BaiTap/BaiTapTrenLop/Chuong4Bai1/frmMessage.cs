using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4Bai1
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = txtTen.Text + ", " + txtThongBao.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTen.Clear();
            txtThongBao.Text = "";
            lblHienThi.Text = "";
            radDen.Checked = true;
            chkHienThi.Checked = true;
        }

        private void radDen_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.ForeColor = Color.Black;
        }

        private void radDo_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.ForeColor = Color.Red;
        }

        private void radVang_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.ForeColor = Color.Yellow;
        }

        private void radXanh_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.ForeColor = Color.Blue;
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            lblHienThi.Visible = chkHienThi.Checked;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picSmall.Visible = false;
            picBig.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
                Close();
        }
    }
}
