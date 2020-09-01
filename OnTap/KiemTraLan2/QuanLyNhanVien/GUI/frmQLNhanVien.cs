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
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtLuongCB.Text = "";
            txtNgayCong.Text = "";
            txtPhuCap.Text = "";

            txtMaNV.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTim.Enabled = true;

            ShowDSNhanVien();
            ShowComboBoxChucVu();
        }

        private void ShowDSNhanVien()
        {
            NhanVienBUL nvBUL = new NhanVienBUL();
            dgvNhanVien.DataSource = nvBUL.DanhSach();

            dgvNhanVien.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns["TenNhanVien"].HeaderText = "Họ Tên";
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns["LuongCanBan"].HeaderText = "Lương Căn Bản";
            dgvNhanVien.Columns["NgayCong"].HeaderText = "Số Ngày Công";
            dgvNhanVien.Columns["PhuCap"].HeaderText = "Phụ Cấp";
            dgvNhanVien.Columns["MaChucVu"].HeaderText = "Chức Vụ";

            dgvNhanVien.PerformLayout();
        }

        private void ShowComboBoxChucVu()
        {
            ChucVuBUL cvBUL = new ChucVuBUL();
            cboCV.DataSource = cvBUL.DanhSach();
            cboCV.DisplayMember = "TenChucVu";
            cboCV.ValueMember = "MaChucVu";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaNV.Text = dgvNhanVien.Rows[index].Cells["MaNhanVien"].Value.ToString();
                txtHoTen.Text = dgvNhanVien.Rows[index].Cells["TenNhanVien"].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dgvNhanVien.Rows[index].Cells["NgaySinh"].Value.ToString());
                txtLuongCB.Text = dgvNhanVien.Rows[index].Cells["LuongCanBan"].Value.ToString();
                txtNgayCong.Text = dgvNhanVien.Rows[index].Cells["NgayCong"].Value.ToString();
                txtPhuCap.Text = dgvNhanVien.Rows[index].Cells["PhuCap"].Value.ToString();
                cboCV.SelectedValue = dgvNhanVien.Rows[index].Cells["MaChucVu"].Value.ToString();

                txtMaNV.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnTim.Enabled = false; 
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            double luongCB = double.Parse(txtLuongCB.Text);
            int ngayCong = int.Parse(txtNgayCong.Text);
            double phuCap = double.Parse(txtPhuCap.Text);
            string maCV = cboCV.SelectedValue.ToString();

            NhanVien nv = new NhanVien(maNV, tenNV, ngaySinh, luongCB, ngayCong, phuCap, maCV);
            NhanVienBUL nvBUL = new NhanVienBUL();
            if (nvBUL.ThemNhanVien(nv))
            {
                MessageBox.Show("Thêm bản ghi thành công!");
                ResetFields();
            }
            else
            {
                MessageBox.Show("Thêm bản ghi thất bại!");
                ResetFields();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            double luongCB = double.Parse(txtLuongCB.Text);
            int ngayCong = int.Parse(txtNgayCong.Text);
            double phuCap = double.Parse(txtPhuCap.Text);
            string maCV = cboCV.SelectedValue.ToString();

            NhanVien nv = new NhanVien(maNV, tenNV, ngaySinh, luongCB, ngayCong, phuCap, maCV);
            NhanVienBUL nvBUL = new NhanVienBUL();
            if (nvBUL.SuaNhanVien(nv))
            {
                MessageBox.Show("Cập nhập bản ghi thành công!");
                ResetFields();
            }
            else
            {
                MessageBox.Show("Cập nhập bản ghi thất bại!");
                ResetFields();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            NhanVienBUL nvBUL = new NhanVienBUL();
            if (nvBUL.XoaNhanVien(maNV))
            {
                MessageBox.Show("Xóa bản ghi thành công!");
                ResetFields();
            }
            else
            {
                MessageBox.Show("Xóa nhập bản ghi thất bại!");
                ResetFields();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            NhanVienBUL nvBUL = new NhanVienBUL();
            List<NhanVien> dsNhanVien = nvBUL.TimNhanVien(maNV);
            
            if (dsNhanVien.Count > 0)
            {
                dgvNhanVien.DataSource = dsNhanVien;
                dgvNhanVien.PerformLayout();
                MessageBox.Show("Tìm thấy bản ghi!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy bản ghi");
                ResetFields();
            }
        }
    }
}
