using BULs;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            ResetFields();
        }
        
        private void ResetFields()
        {
            txtMaHD.Enabled = true;
            txtMaHD.Text = txtCSCu.Text = txtCSMoi.Text = "";
            dtpNgay.Value = dtpNgayCu.Value = DateTime.Now;

            ShowDataGridView();
            ShowComboBox();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;


        }
        private void ShowComboBox()
        {
            KhachHangBUL khBUL = new KhachHangBUL();
            cboKhachHang.DataSource = khBUL.DanhSach();
            cboKhachHang.DisplayMember = "TenKhachHang";
            cboKhachHang.ValueMember = "MaKhachHang";
        }
        private void ShowDataGridView()
        {
            HoaDonBUL hdBUL = new HoaDonBUL();
            dgvHoaDon.DataSource = hdBUL.DanhSach();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaHD.Text = dgvHoaDon.Rows[index].Cells["MaHoaDon"].Value.ToString();
                cboKhachHang.SelectedValue = dgvHoaDon.Rows[index].Cells["MaKhachHang"].Value.ToString();
                txtCSCu.Text = dgvHoaDon.Rows[index].Cells["ChiSoCu"].Value.ToString();
                dtpNgayCu.Value = DateTime.Parse(dgvHoaDon.Rows[index].Cells["NgayCu"].Value.ToString());
                txtCSMoi.Text = dgvHoaDon.Rows[index].Cells["ChiSoMoi"].Value.ToString();
                dtpNgay.Value = DateTime.Parse(dgvHoaDon.Rows[index].Cells["NgayDo"].Value.ToString());

                txtMaHD.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            string maKH = cboKhachHang.SelectedValue.ToString();
            int csCu = int.Parse(txtCSCu.Text);
            DateTime ngayCu = dtpNgayCu.Value;
            int csMoi = int.Parse(txtCSMoi.Text);
            DateTime ngayMoi = dtpNgay.Value;

            HoaDon hd = new HoaDon(maHD, maKH, csCu, ngayCu, csMoi, ngayMoi);

            HoaDonBUL hdBUL = new HoaDonBUL();
            if (hdBUL.ThemHoaDon(hd))
            {
                MessageBox.Show("Thêm bản ghi thành công!");
            }
            else
            {
                MessageBox.Show("Thêm bản ghi thất bại!");
            }
            ResetFields();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            string maKH = cboKhachHang.SelectedValue.ToString();
            int csCu = int.Parse(txtCSCu.Text);
            DateTime ngayCu = dtpNgayCu.Value;
            int csMoi = int.Parse(txtCSMoi.Text);
            DateTime ngayMoi = dtpNgay.Value;

            HoaDon hd = new HoaDon(maHD, maKH, csCu, ngayCu, csMoi, ngayMoi);

            HoaDonBUL hdBUL = new HoaDonBUL();
            if (hdBUL.SuaHoaDon(hd))
            {
                MessageBox.Show("Sửa bản ghi thành công!");
            }
            else
            {
                MessageBox.Show("Sửa bản ghi thất bại!");
            }
            ResetFields();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            HoaDonBUL hdBUL = new HoaDonBUL();
            DialogResult rs = MessageBox.Show("Ban muốn xóa bản ghi này?", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {

                if (hdBUL.XoaHoaDon(maHD))
                {
                    MessageBox.Show("Xóa bản ghi thành công!");

                }
                else
                {
                    MessageBox.Show("Xóa bản ghi thất bại!");
                } 
            }
            ResetFields();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            HoaDonBUL hdBUL = new HoaDonBUL();
            List<HoaDon> dsHD = hdBUL.Tim(maHD);
            if (dsHD.Count>0)
            {
                MessageBox.Show("Tìm thấy bản ghi!");
                dgvHoaDon.DataSource = dsHD;
            }
            else
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }
    }
}
