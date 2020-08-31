using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        private static List<HocSinh> dsHocSinh = new List<HocSinh>();
        public Form1()
        {
            InitializeComponent();
        }
        void HienThiThem()
        {
            for (int i = 0; i < dsHocSinh.Count; i++)
            {
                lstThongTin.Items.Add(dsHocSinh[i].HoTen);
                lstThongTin.Items[i].SubItems.Add(dsHocSinh[i].GioiTinh);
                lstThongTin.Items[i].SubItems.Add(dsHocSinh[i].Toan.ToString());
                lstThongTin.Items[i].SubItems.Add(dsHocSinh[i].Van.ToString());
                lstThongTin.Items[i].SubItems.Add(dsHocSinh[i].NgoaiNgu.ToString());
                lstThongTin.Items[i].SubItems.Add(dsHocSinh[i].DiemThapNhat().ToString());
                lstThongTin.Items[i].SubItems.Add(dsHocSinh[i].diemKetQua().ToString());
                lstThongTin.Items[i].SubItems.Add(dsHocSinh[i].XepLoai().ToString());
            }
        }

        void Xoa()
        {
            txtHoTen.Clear();
            chkNu.Checked = false;
            txtToan.Clear();
            txtVan.Clear();
            txtNgoaiNgu.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string gioiTinh = "Nam";
            if (chkNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            double toan = double.Parse(txtToan.Text);
            double van = double.Parse(txtVan.Text);
            double ngoaiNgu = double.Parse(txtNgoaiNgu.Text);
            HocSinh hs1 = new HocSinh(hoTen, gioiTinh, toan, van, ngoaiNgu);
            dsHocSinh.Add(hs1);
            lbCount.Text = dsHocSinh.Count.ToString();

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            HienThiThem();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit ?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
