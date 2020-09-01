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
    public partial class frmQLSach : Form
    {
        public frmQLSach()
        {
            InitializeComponent();
        }

        private void frmQLSach_Load(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtMaS.Text = "";
            txtTenS.Text = "";
            txtSoLuong.Text = "";
            ShowComboBoxTG();
            dtpNgayXB.Value = DateTime.Now;

            ShowDGVSach();

            txtMaS.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void ShowComboBoxTG()
        {
            TacGiaBUL tgBUL = new TacGiaBUL();
            cboTacGia.DataSource = tgBUL.DanhSach();
            cboTacGia.DisplayMember = "TenTacGia";
            cboTacGia.ValueMember = "MaTacGia";
        }

        private void ShowDGVSach()
        {
            SachBUL sachBUL = new SachBUL();
            dgvSach.DataSource = sachBUL.DanhSach();

            dgvSach.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvSach.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvSach.Columns["SoLuongCo"].HeaderText = "Số Lượng";
            dgvSach.Columns["MaTacGia"].HeaderText = "Tác Giả";
            dgvSach.Columns["NgayXuatBan"].HeaderText = "Ngày Xuất Bản";

            dgvSach.PerformLayout();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaS.Text = dgvSach.Rows[index].Cells["MaSach"].Value.ToString();
                txtTenS.Text = dgvSach.Rows[index].Cells["TenSach"].Value.ToString();
                txtSoLuong.Text = dgvSach.Rows[index].Cells["SoLuongCo"].Value.ToString();
                cboTacGia.SelectedValue = dgvSach.Rows[index].Cells["MaTacGia"].Value.ToString();
                dtpNgayXB.Value = DateTime.Parse(dgvSach.Rows[index].Cells["NgayXuatBan"].Value.ToString());

                txtMaS.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maS = txtMaS.Text;
            string tenS = txtTenS.Text;
            int sl = int.Parse(txtSoLuong.Text);
            string matg = cboTacGia.SelectedValue.ToString();
            DateTime ngayXB = dtpNgayXB.Value;

            Sach info = new Sach(maS, tenS, sl, matg, ngayXB);

            SachBUL sachBUL = new SachBUL();

            if(sachBUL.ThemSach(info))
            {
                MessageBox.Show("Thêm bản ghi thành công!");
            }
            else
            {
                MessageBox.Show("Không thể thêm bản ghi!");
            }

            ResetFields();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maS = txtMaS.Text;
            string tenS = txtTenS.Text;
            int sl = int.Parse(txtSoLuong.Text);
            string matg = cboTacGia.SelectedValue.ToString();
            DateTime ngayXB = dtpNgayXB.Value;

            Sach info = new Sach(maS, tenS, sl, matg, ngayXB);

            SachBUL sachBUL = new SachBUL();

            if (sachBUL.SuaSach(info))
            {
                MessageBox.Show("Cập nhập bản ghi thành công!");
            }
            else
            {
                MessageBox.Show("Không thể cập nhập bản ghi!");
            }

            ResetFields();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maS = txtMaS.Text;
            SachBUL sachBUL = new SachBUL();

            DialogResult rs = MessageBox.Show("Bạn có muốn xóa bản ghi?", "Xóa bản ghi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (sachBUL.XoaSach(maS))
                {
                    MessageBox.Show("Xóa bản ghi thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhập bản ghi!");
                } 
            }

            ResetFields();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maS = txtMaS.Text;
            SachBUL sachBUL = new SachBUL();
            List<Sach> dsSach = sachBUL.TimSach(maS);

            if (dsSach.Count>0)
            {
                MessageBox.Show("Tìm thấy bản ghi!");
                dgvSach.DataSource = dsSach;
                dgvSach.PerformLayout();
            }
            else
            {
                MessageBox.Show("Không tìm thấy bản ghi!");
                ResetFields();
            }    
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
    }
}
