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
    public partial class frmQLSanPham : Form
    {
        public frmQLSanPham()
        {
            InitializeComponent();
        }

        private void frmQLSanPham_Load(object sender, EventArgs e)
        {
            ShowSanPhamToDGV();

            FillDataDanhMuc();
        }

        private void ShowSanPhamToDGV()
        {
            SanPhamBUL spb = new SanPhamBUL();
            dgvSanPham.DataSource = spb.DanhSach();
            dgvSanPham.PerformLayout();
        }

        private void FillDataDanhMuc()
        {
            DanhMucBUL dmb = new DanhMucBUL();
            cboDanhMuc.DataSource = dmb.DanhSach();
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "MaDanhMuc";
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvSanPham.Rows[e.RowIndex];
            txtMaSP.Text = dgvRow.Cells["MaSanPham"].Value.ToString();
            txtTenSP.Text = dgvRow.Cells["TenSanPham"].Value.ToString();
            txtSoLuong.Text = dgvRow.Cells["SoLuong"].Value.ToString();
            txtDonGia.Text = dgvRow.Cells["DonGia"].Value.ToString();
            cboDanhMuc.SelectedValue = dgvRow.Cells["MaDanhMuc"].Value.ToString();

            //Disable Button and Text box
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnTim.Enabled = false;
            txtMaSP.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            ShowSanPhamToDGV();
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            cboDanhMuc.SelectedIndex = 0;

            //Disable Button and Text box
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTim.Enabled = true;
            txtMaSP.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            double donGia = double.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            string maDM = cboDanhMuc.SelectedValue.ToString();

            SanPhamDTO sp = new SanPhamDTO(maSP, tenSP, donGia, soLuong, maDM);

            SanPhamBUL spBUL = new SanPhamBUL();
            if(spBUL.InsertSanPham(sp))
            {
                ResetFields();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thêm sản phẩm! Vui lòng nhập lại!");
                txtMaSP.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SanPhamBUL spBUL = new SanPhamBUL();
            string maSP = txtMaSP.Text;
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa bản ghi này?", "Xóa bản ghi", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (spBUL.DeleteSanPham(maSP))
                {
                    ResetFields();
                    MessageBox.Show("Xóa thành công!");
                }
                else
                    MessageBox.Show("Xóa Thất Bại, Vui lòng thử lại!"); 
            }

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            SanPhamBUL spBUL = new SanPhamBUL();
            string maSP = txtMaSP.Text;
            List<SanPhamDTO> sp = spBUL.FindSanPham(maSP);
            if (sp.Count > 0)
            {
                dgvSanPham.DataSource = sp;
                dgvSanPham.PerformLayout();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm có mã " + maSP);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            double donGia = double.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            string maDM = cboDanhMuc.SelectedValue.ToString();

            SanPhamDTO sp = new SanPhamDTO(maSP, tenSP, donGia, soLuong, maDM);
            SanPhamBUL spBUL = new SanPhamBUL();
            if (spBUL.ModifySanPham(sp))
            {
                ResetFields();
                MessageBox.Show("Cập nhập thành công!");
            }
            else
            {
                MessageBox.Show("Lỗi không thể thêm sản phẩm! Vui lòng nhập lại!");
                txtMaSP.Focus();
            }
        }
    }
}
