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

namespace GUIs
{
    public partial class frmQLSinhVien : Form
    {
        public frmQLSinhVien()
        {
            InitializeComponent();
        }

        private void frmQLSinhVien_Load(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ShowComboBoxLop(string maKhoa)
        {
            LopHocBUL lopBUL = new LopHocBUL();
            List<LopHoc> dsLop = lopBUL.DanhSach(maKhoa);
            cboLop.DataSource = dsLop;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }

        private void ShowComboBoxKhoa()
        {
            KhoaBUL khoaBUL = new KhoaBUL();
            List<Khoa> dsKhoa = khoaBUL.DanhSach();
            cboKhoa.DataSource = dsKhoa;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }

        private void ShowDataGridView()
        {
            SinhVienBUL svBUL = new SinhVienBUL();
            List<SinhVien> dsSinhVien = svBUL.DanhSach();
            dgvSinhVien.DataSource = dsSinhVien;
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhoa = cboKhoa.SelectedValue.ToString();
            ShowComboBoxLop(maKhoa);
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMaSV.Text = dgvSinhVien.Rows[index].Cells["MaSinhVien"].Value.ToString();
            txtHoTen.Text = dgvSinhVien.Rows[index].Cells["HoTen"].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(dgvSinhVien.Rows[index].Cells["NgaySinh"].Value.ToString());
            string gioiTinh = dgvSinhVien.Rows[index].Cells["GioiTinh"].Value.ToString();
            if (gioiTinh == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;

            string maLop = dgvSinhVien.Rows[index].Cells["MaLop"].Value.ToString();
            KhoaBUL khoaBUL = new KhoaBUL();
            Khoa khoainfo = khoaBUL.TimKhoaTheoLop(maLop);
            cboKhoa.SelectedValue = khoainfo.MaKhoa;

            cboLop.SelectedValue = maLop;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnTim.Enabled = false;
            txtMaSV.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            radNam.Checked = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnTim.Enabled = true;
            txtMaSV.Enabled = true;

            ShowDataGridView();
            ShowComboBoxKhoa();
            ShowComboBoxLop(cboKhoa.SelectedValue.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            DialogResult rs = MessageBox.Show("Bạn muốn xóa bản ghi đang chọn?", "Xóa bản ghi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                SinhVienBUL svBUL = new SinhVienBUL();
                if (svBUL.XoaSinhVien(maSV))
                {
                    MessageBox.Show("Xóa bản ghi thành công!");
                    ResetFields();
                }
                else
                {
                    MessageBox.Show("Không thể xóa sinh viên có mã " + maSV);
                }  
            }   
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = "Nam";
            if (radNu.Checked)
                gioiTinh = "Nữ";
            string maLop = cboLop.SelectedValue.ToString();

            SinhVien sv = new SinhVien(maSV, hoTen, ngaySinh, gioiTinh, maLop);
            SinhVienBUL svBUL = new SinhVienBUL();

            if(svBUL.ThemSinhVien(sv))
            {
                MessageBox.Show("Thêm thành công!");
                ResetFields();
            }
            else
            {
                MessageBox.Show("Không thể thêm sinh viên! ");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = "Nam";
            if (radNu.Checked)
                gioiTinh = "Nữ";
            string maLop = cboLop.SelectedValue.ToString();

            SinhVien sv = new SinhVien(maSV, hoTen, ngaySinh, gioiTinh, maLop);
            SinhVienBUL svBUL = new SinhVienBUL();

            if (svBUL.SuaThongTin(sv))
            {
                MessageBox.Show("Cập nhập thành công!");
                ResetFields();
            }
            else
            {
                MessageBox.Show("Không thể cập nhập bản ghi! ");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            SinhVienBUL svBUL = new SinhVienBUL();
            List<SinhVien> dsSinhVien = svBUL.TimTheoMa(maSV);
            if (dsSinhVien.Count > 0)
            {
                dgvSinhVien.DataSource = dsSinhVien;
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy bản ghi! ");
            }
        }
    }
}
