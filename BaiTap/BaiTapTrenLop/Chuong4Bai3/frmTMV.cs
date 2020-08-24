using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4Bai3
{
    public partial class frmTMV : Form
    {
        private double TongTien = 0;
        const int TRANG_DIEM = 125, LAM_TOC = 60, LAM_MONG = 35, MAT_XA = 200;

        public frmTMV()
        {
            InitializeComponent();
        }

        private void chkTrangDiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrangDiem.Checked)
                TongTien += TRANG_DIEM;
            else
                TongTien -= TRANG_DIEM;
            lblTongTien.Text = TongTien.ToString("C1");
        }

        private void chkLamToc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLamToc.Checked)
                TongTien += LAM_TOC;
            else
                TongTien -= LAM_TOC;
            lblTongTien.Text = TongTien.ToString("C1");
        }

        private void chkMatXa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMatXa.Checked)
                TongTien += MAT_XA;
            else
                TongTien -= MAT_XA;
            lblTongTien.Text = TongTien.ToString("C1");
        }

        private void chkLamMong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLamMong.Checked)
                TongTien += LAM_MONG;
            else
                TongTien -= LAM_MONG;
            lblTongTien.Text = TongTien.ToString("C1");
        }



        private void btnTinh_Click(object sender, EventArgs e)
        {
            double ptGiamGia = 0, soTienGiam = 0, soTienTra = 0;
            if (rad0.Checked)
                ptGiamGia = 0;
            if (rad10.Checked)
                ptGiamGia = 0.1;
            if (rad20.Checked)
                ptGiamGia = 0.2;
            soTienGiam = TongTien * ptGiamGia;
            soTienTra = TongTien - soTienGiam;
            lblGiamGia.Text = soTienGiam.ToString("C1");
            lblTongTra.Text = soTienTra.ToString("C1");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            chkLamMong.Checked = false;
            chkLamToc.Checked = false;
            chkMatXa.Checked = false;
            chkTrangDiem.Checked = false;
            rad0.Checked = true;
            lblGiamGia.Text = "";
            lblTongTien.Text = "";
            lblTongTra.Text = "";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn kết thúc chương trình?", 
                "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
