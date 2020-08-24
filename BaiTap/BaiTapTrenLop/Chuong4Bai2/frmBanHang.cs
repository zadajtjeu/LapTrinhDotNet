using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4Bai2
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            lblTenHang.Text = txtTenHang.Text;
            lblTongTien.Text = String.Format("${0}", (double.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text)));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTenHang.Text = "";
            txtSoLuong.Clear();
            txtDonGia.Text = String.Empty;
            lblTenHang.Text = "";
            lblTongTien.Text = String.Empty;
            txtTenHang.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
                this.Close();
        }

    }
}
