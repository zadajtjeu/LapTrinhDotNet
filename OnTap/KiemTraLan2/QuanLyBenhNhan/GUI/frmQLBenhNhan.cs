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
    public partial class frmQLBenhNhan : Form
    {
        public frmQLBenhNhan()
        {
            InitializeComponent();
        }

        private void frmQLBenhNhan_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        private void ReLoad()
        {
            txtMaBN.Text = txtHoTen.Text = txtBHXH.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            radNam.Checked = true;
            ShowComboBox();
            ShowDataGridView();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaBN.Enabled = true;
        }
        private void ShowComboBox()
        {
            KhoaKhamBUL khoaBUL = new KhoaKhamBUL();
            cboKhoa.DataSource = khoaBUL.DanhSach();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }
        private void ShowDataGridView()
        {
            BenhNhanBUL bnBUL = new BenhNhanBUL();
            dgvBenhNhan.DataSource = bnBUL.DanhSach();
        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaBN.Text = dgvBenhNhan.Rows[index].Cells["MaBenhNhan"].Value.ToString();
                txtHoTen.Text = dgvBenhNhan.Rows[index].Cells["TenBenhNhan"].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(dgvBenhNhan.Rows[index].Cells["NgaySinh"].Value.ToString());
                txtBHXH.Text = dgvBenhNhan.Rows[index].Cells["MaBHXH"].Value.ToString();
                string gioiTinh = dgvBenhNhan.Rows[index].Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
                cboKhoa.SelectedValue = dgvBenhNhan.Rows[index].Cells["MaKhoa"].Value.ToString();
                

                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaBN.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maBN = txtMaBN.Text;
            string tenBN = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = "";
            if (radNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            string maBHXH = txtBHXH.Text;
            string maKhoa = cboKhoa.SelectedValue.ToString();

            BenhNhan bn = new BenhNhan(maBN, tenBN, ngaySinh, gioiTinh, maBHXH, maKhoa);

            BenhNhanBUL bnBUL = new BenhNhanBUL();
            if (bnBUL.Them(bn))
            {
                MessageBox.Show("Thêm bản ghi thành công!");
            }
            else
            {
                MessageBox.Show("Thêm bản ghi thất bại!");

            }
            ReLoad();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maBN = txtMaBN.Text;
            string tenBN = txtHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = "";
            if (radNam.Checked == true)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            string maBHXH = txtBHXH.Text;
            string maKhoa = cboKhoa.SelectedValue.ToString();

            BenhNhan bn = new BenhNhan(maBN, tenBN, ngaySinh, gioiTinh, maBHXH, maKhoa);

            BenhNhanBUL bnBUL = new BenhNhanBUL();
            if (bnBUL.Sua(bn))
            {
                MessageBox.Show("Sửa bản ghi thành công!");
            }
            else
            {
                MessageBox.Show("Sửa bản ghi thất bại!");

            }
            ReLoad();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maBN = txtMaBN.Text;
            BenhNhanBUL bnBUL = new BenhNhanBUL();
            DialogResult rs = MessageBox.Show("Bạn muốn xóa bản ghi này?", "Xóa bản ghi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (bnBUL.Xoa(maBN))
                {
                    MessageBox.Show("Xóa bản ghi thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa bản ghi thất bại!");

                } 
            }
            ReLoad();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maBN = txtMaBN.Text;
            BenhNhanBUL bnBUL = new BenhNhanBUL();
            List<BenhNhan> dsBN = bnBUL.Tim(maBN);
            if (dsBN.Count>0)
            {
                MessageBox.Show("Tìm thấy bản ghi!");
                dgvBenhNhan.DataSource = dsBN;
            }
            else
                {
                 MessageBox.Show("Không tìm thấy bản ghi!");
                ReLoad();
            }
            
        }
    }
}
